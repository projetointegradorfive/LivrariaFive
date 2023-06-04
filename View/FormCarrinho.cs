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


        public FormCarrinho(Carrinho carrinho, Cliente cliente)
        {
            InitializeComponent();
            this.carrinho = carrinho;
            this.cliente = cliente;
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            // Adicionar colunas ao DataGridView
            dgvCarrinho.Columns.Add("Imagem", "Imagem");
            dgvCarrinho.Columns.Add("Titulo", "Título");
            dgvCarrinho.Columns.Add("Quantidade", "Quantidade");
            dgvCarrinho.Columns.Add("Preco", "Preço");
            // Carregar os itens do carrinho
            CarregarItensCarrinho();
        }

        private void CarregarItensCarrinho()
        {
            dgvCarrinho.Rows.Clear();

            foreach (ItemDeCompra item in carrinho.ItensDeCompra)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCell.Value = item.Livro.Imagem;
                row.Cells.Add(imageCell);

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Livro.Titulo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Quantidade });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecoLivro });

                dgvCarrinho.Rows.Add(row);
            }
        }

    }
}
