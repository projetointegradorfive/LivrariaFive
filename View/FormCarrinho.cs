using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaFive.Model;
using System.IO;
using LivrariaFive.Controller;

namespace LivrariaFive.View
{


    public partial class FormCarrinho : Form
    {
        private Carrinho carrinho;
        private Cliente cliente;
        private ItemDeCompraController itemDeCompraController;
        private CarrinhoController carrinhoController;



        public FormCarrinho(Carrinho carrinho, Cliente cliente)
        {
            InitializeComponent();
            this.carrinho = carrinho;
            this.cliente = cliente;
            itemDeCompraController = new ItemDeCompraController();
            carrinhoController = new CarrinhoController();

        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            // Adicionar colunas ao DataGridView
            dgvCarrinho.Columns.Add("Id", "Id");
            dgvCarrinho.Columns.Add("Imagem", "Imagem");
            dgvCarrinho.Columns.Add("Titulo", "Título");
            dgvCarrinho.Columns.Add("Quantidade", "Quantidade");
            dgvCarrinho.Columns.Add("Preco", "Preço");

            ConfigurarGrade();
            // Carregar os itens do carrinho
            CarregarItensCarrinho();

        }


        private void ConfigurarGrade()
        {
            dgvCarrinho.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvCarrinho.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvCarrinho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvCarrinho.Columns["Id"].Width = 100;
            dgvCarrinho.Columns["Id"].HeaderText = "ID";
            dgvCarrinho.Columns["Id"].DefaultCellStyle.NullValue = null; // Define a célula vazia como nula

            dgvCarrinho.Columns["Imagem"].Width = 100;
            dgvCarrinho.Columns["Imagem"].HeaderText = "Imagem";
            dgvCarrinho.Columns["Imagem"].DefaultCellStyle.NullValue = null; // Define a célula vazia como nula
            dgvCarrinho.Columns["Imagem"].ReadOnly = true; // Torna a coluna somente leitura

            dgvCarrinho.Columns["Titulo"].Width = 300;
            dgvCarrinho.Columns["Titulo"].HeaderText = "Título";
            dgvCarrinho.Columns["Titulo"].ReadOnly = true; // Torna a coluna somente leitura

            dgvCarrinho.Columns["Quantidade"].Width = 100;
            dgvCarrinho.Columns["Quantidade"].Name = "Quantidade";
            dgvCarrinho.Columns["Quantidade"].HeaderText = "Quantidade";

            dgvCarrinho.Columns["Preco"].Width = 100;
            dgvCarrinho.Columns["Preco"].HeaderText = "Preço";
            dgvCarrinho.Columns["Preco"].Name = "Preco";
            dgvCarrinho.Columns["Preco"].DefaultCellStyle.Format = "C2"; // Formato de moeda (R$)
            dgvCarrinho.Columns["Preco"].ReadOnly = true; // Torna a coluna somente leitura

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Selecionado";
            checkBoxColumn.Width = 110;
            checkBoxColumn.Name = "checkBoxColumn";
            checkBoxColumn.ReadOnly = false; // Definindo a coluna como somente leitura
            dgvCarrinho.Columns.Add(checkBoxColumn);
        }


        private void CarregarItensCarrinho()
        {
            dgvCarrinho.Rows.Clear();

            foreach (ItemDeCompra item in carrinho.ItensDeCompra)
            {
                DataGridViewRow row = new DataGridViewRow();

                // Adicione o código para obter o ID do ItemDeCompra
                int itemId = itemDeCompraController.ObterIdItemDeCompra(item.Livro.Id, carrinho.Id);
                item.Id = itemId;

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id });

                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCell.Value = item.Livro.Imagem;
                row.Cells.Add(imageCell);

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Livro.Titulo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Quantidade });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecoLivro });
                row.Tag = item;

                dgvCarrinho.Rows.Add(row);
            }

        }


        private List<ItemDeCompra> ObterItensDeCompraSelecionados()
        {
            List<ItemDeCompra> itensSelecionados = new List<ItemDeCompra>();

            foreach (DataGridViewRow row in dgvCarrinho.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;


                if (checkBoxCell != null && checkBoxCell.Value != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    ItemDeCompra item = row.Tag as ItemDeCompra;
                    if (item != null)
                    {
                        // Obter a quantidade atualizada
                        int novaQuantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);

                        // Atualizar a quantidade no objeto item
                        item.Quantidade = novaQuantidade;

                        itensSelecionados.Add(item);

                    }
                }
            }

            return itensSelecionados;
        }

        private void btnRemoverItemCarrinho_Click(object sender, EventArgs e)
        {
            List<ItemDeCompra> itensSelecionados = ObterItensDeCompraSelecionados();

            foreach (ItemDeCompra item in itensSelecionados)
            {
                itemDeCompraController.RemoverItemDoCarrinho(carrinho, item.Livro.Id);
            }

            CarregarItensCarrinho();
            CalcularTotalItensSelecionados();
            atualizarPrecoTotalCarrinho();
        }

        private void btnLimparCarrinho_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja remover todos os produtos do seu carrinho?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                itemDeCompraController.LimparCarrinho(carrinho);
                CarregarItensCarrinho();
            }
        }

        private void dgvCarrinho_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCarrinho.Columns["Quantidade"].Index)
            {
                DataGridViewRow row = dgvCarrinho.Rows[e.RowIndex];
                ItemDeCompra item = row.Tag as ItemDeCompra;
                int novaQuantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);

                // Atualize a quantidade no banco de dados
                itemDeCompraController.AtualizarQuantidadeItem(carrinho.Id, item.Livro.Id, novaQuantidade);
                atualizarPrecoTotalCarrinho();



            }
        }

        private void atualizarPrecoTotalCarrinho()
        {
            double total = CalcularTotalItensSelecionados();
            lblPrecoTotalCarrinho.Text = total.ToString("C");

        }

        private double CalcularTotalItensSelecionados()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvCarrinho.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && checkBoxCell.Value != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    object precoValue = row.Cells["Preco"].Value;
                    object quantidadeValue = row.Cells["Quantidade"].Value;

                    if (precoValue != null && quantidadeValue != null)
                    {
                        double precoUnitario = Convert.ToDouble(precoValue);
                        int quantidade = Convert.ToInt32(quantidadeValue);
                        double subtotal = precoUnitario * quantidade;
                        total += subtotal;
                    }
                }
            }

            return total;
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvCarrinho.Columns["checkBoxColumn"].Index && e.RowIndex != -1)
                {
                    DataGridViewCheckBoxCell checkBoxCell = dgvCarrinho.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;

                    if (checkBoxCell != null)
                    {
                        dgvCarrinho.EndEdit();

                        atualizarPrecoTotalCarrinho();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar o valor total do carrinho: " + ex.Message);
            }
        }

        private void btnEfetuarPedido_Click(object sender, EventArgs e)
        {
            List<ItemDeCompra> itensSelecionados = ObterItensDeCompraSelecionados();


            Pedido pedido = new Pedido();
            pedido.ItensDeCompra = itensSelecionados;
            pedido.Data = DateTime.Now; // Exemplo: usando a data atual
            pedido.PrecoTotalPedido = CalcularTotalItensSelecionados() + 15; // Calcula o preço total dos itens selecionados
            pedido.FormaPagamento = "Cartão"; // Exemplo: forma de pagamento selecionada no formulário
            pedido.Status = "Em andamento"; // Exemplo: status inicial do pedido
            pedido.Cliente = cliente; // Define o objeto Cliente completo



            // Oculta o formulário de carrinho e mostra o formulário de pedido
            LivroForm livroForm = new LivroForm(cliente);
            FormPedido formPedido = new FormPedido(pedido, livroForm, carrinho, cliente);

            livroForm.Hide();
            this.Hide();

            formPedido.ShowDialog();
        }

        private void btnSelecionarTudo_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvCarrinho.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    // se o checkbox estiver desmarcado
                    if (checkBoxCell.Value == null || !Convert.ToBoolean(checkBoxCell.Value))
                    {
                        //marca o checbox
                        checkBoxCell.Value = true;
                    }
                    else
                    {
                        //desmarca o checkbox
                        checkBoxCell.Value = false;
                    }
                }
            }
            // atualiza o preco total da compra
            atualizarPrecoTotalCarrinho();

        }
    }
}
