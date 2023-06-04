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
using Newtonsoft.Json;
using LivrariaFive.Controller;

namespace LivrariaFive.View
{
    public partial class FormCarrinho : Form
    {
        private Carrinho carrinho;
        private Cliente cliente;
        private ItemDeCompraController itemDeCompraController;



        public FormCarrinho(Carrinho carrinho, Cliente cliente)
        {
            InitializeComponent();
            this.carrinho = carrinho;
            this.cliente = cliente;
            itemDeCompraController = new ItemDeCompraController();

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
            dgvCarrinho.Columns["Id"].HeaderText = "Imagem";
            dgvCarrinho.Columns["Id"].DefaultCellStyle.NullValue = null; // Define a célula vazia como nula

            dgvCarrinho.Columns["Imagem"].Width = 100;
            dgvCarrinho.Columns["Imagem"].HeaderText = "Imagem";
            dgvCarrinho.Columns["Imagem"].DefaultCellStyle.NullValue = null; // Define a célula vazia como nula
            dgvCarrinho.Columns["Imagem"].ReadOnly = true; // Torna a coluna somente leitura

            dgvCarrinho.Columns["Titulo"].Width = 300;
            dgvCarrinho.Columns["Titulo"].HeaderText = "Título";
            dgvCarrinho.Columns["Titulo"].ReadOnly = true; // Torna a coluna somente leitura

            dgvCarrinho.Columns["Quantidade"].Width = 100;
            dgvCarrinho.Columns["Quantidade"].HeaderText = "Quantidade";

            dgvCarrinho.Columns["Preco"].Width = 100;
            dgvCarrinho.Columns["Preco"].HeaderText = "Preço";
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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = itemId });
                

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

      

    }
}
