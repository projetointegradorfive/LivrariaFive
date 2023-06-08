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
        public FormPedido(Pedido pedido)
        {

            InitializeComponent();
            this.pedido = pedido;

            itemDeCompraController = new ItemDeCompraController();

        }
        private void FormPedido_Load(object sender, EventArgs e)
        {
            // Adicionar colunas ao DataGridView
            dgvpedido.Columns.Add("Imagem", "Imagem");
            dgvpedido.Columns.Add("Titulo", "Título");
            dgvpedido.Columns.Add("Quantidade", "Quantidade");
            dgvpedido.Columns.Add("Preco", "Preço");
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
            lblTotalPedido.Text = (pedido.PrecoTotalPedido).ToString();
            lblTotalComFrete.Text = (pedido.PrecoTotalPedido + 15).ToString();
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


    }
}
