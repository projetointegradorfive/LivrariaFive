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
    public partial class FormPedido : Form
    {

        private Pedido pedido;
        private ItemDeCompraController itemDeCompraController;
        private LivroForm livroForm;


        public FormPedido(Pedido pedido, LivroForm livroForm)
        {
            this.livroForm = livroForm;

            InitializeComponent();
            this.pedido = pedido;
            itemDeCompraController = new ItemDeCompraController();

            cbxFormaPagamento.Items.Add("Cartão de Crédito");
            cbxFormaPagamento.Items.Add("Cartão de Débito");
            cbxFormaPagamento.Items.Add("Boleto Bancário");
            cbxFormaPagamento.Items.Add("Pix");

        }
        private void FormPedido_Load(object sender, EventArgs e)
        {
            // Adicionar colunas ao DataGridView
            dgvpedido.Columns.Add("Imagem", "Imagem");
            dgvpedido.Columns.Add("Titulo", "Título");
            dgvpedido.Columns.Add("Quantidade", "Quantidade");
            dgvpedido.Columns.Add("Preco", "Preço");
            cbxFormaPagamento.SelectedIndex = 0;

            ConfigurarGrade();
            CarregarItensPedido();

        }

        public void ConfigurarGrade()
        {

            dgvpedido.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvpedido.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvpedido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvpedido.Columns["Imagem"].Width = 100;
            dgvpedido.Columns["Imagem"].HeaderText = "Imagem";
            dgvpedido.Columns["Imagem"].DefaultCellStyle.NullValue = null; // Define a célula vazia como nula
            dgvpedido.Columns["Imagem"].ReadOnly = true; // Torna a coluna somente leitura

            dgvpedido.Columns["Titulo"].Width = 300;
            dgvpedido.Columns["Titulo"].HeaderText = "Título";
            dgvpedido.Columns["Titulo"].ReadOnly = true; // Torna a coluna somente leitura

            dgvpedido.Columns["Quantidade"].Width = 100;
            dgvpedido.Columns["Quantidade"].Name = "Quantidade";
            dgvpedido.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvpedido.Columns["Quantidade"].ReadOnly = true; // Torna a coluna somente leitura

            dgvpedido.Columns["Preco"].Width = 100;
            dgvpedido.Columns["Preco"].HeaderText = "Preço";
            dgvpedido.Columns["Preco"].Name = "Preco";
            dgvpedido.Columns["Preco"].DefaultCellStyle.Format = "C2"; // Formato de moeda (R$)
            dgvpedido.Columns["Preco"].ReadOnly = true; // Torna a coluna somente leitura
        }

        private void CarregarItensPedido()
        {
            lblEnderecoCliente.Text = pedido.Cliente.Endereco;
            lblTotalPedido.Text = (pedido.PrecoTotalPedido - 15).ToString();
            lblTotalComFrete.Text = (pedido.PrecoTotalPedido).ToString();
            
            dgvpedido.Rows.Clear();

            foreach (ItemDeCompra item in pedido.ItensDeCompra)
            {
                DataGridViewRow row = new DataGridViewRow();
                //row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id });

                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCell.Value = item.Livro.Imagem;
                row.Cells.Add(imageCell);

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Livro.Titulo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Quantidade });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecoLivro });
                row.Tag = item;

                dgvpedido.Rows.Add(row);
            }

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {        
            this.Close();
            livroForm.Show();

        }

        private void btnFazerPagamento_Click(object sender, EventArgs e)
        {
            string formaPagamentoSelecionada = cbxFormaPagamento.SelectedItem.ToString();

            // Verificar a forma de pagamento selecionada e abrir o formulário correspondente
            if (formaPagamentoSelecionada == "Cartão de Crédito" || formaPagamentoSelecionada == "Cartão de Débito")
            {
                FormPagamentoCartao formCartao = new FormPagamentoCartao(pedido);
                formCartao.ShowDialog(); // Abre o formulário como diálogo
            }
            //else if (formaPagamentoSelecionada == "Boleto Bancário")
            //{
            //    FormBoletoBancario formBoletoBancario = new FormBoletoBancario();
            //    formBoletoBancario.ShowDialog(); // Abre o formulário como diálogo
            //}
            //else if (formaPagamentoSelecionada == "Pix")
            //{
            //    FormPix formPix = new FormPix();
            //    formPix.ShowDialog(); // Abre o formulário como diálogo
            //}else
            //{
            //    // Forma de pagamento inválida
            //    MessageBox.Show("Forma de pagamento inválida. Selecione uma opção válida.");
            //}

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            livroForm.Show();
        }
    }
}
