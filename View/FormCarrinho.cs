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
        private CarrinhoController carrinhoController;
        private Carrinho carrinho;

        public FormCarrinho()
        {
            InitializeComponent();
            carrinhoController = new CarrinhoController(); // Inicializar o carrinhoController

            // Adicionar as colunas ao DataGridView
            dataGridViewItensCarrinho.Columns.Add("Id", "ID");
            dataGridViewItensCarrinho.Columns.Add("NomeLivro", "Nome do Livro");
            dataGridViewItensCarrinho.Columns.Add("PrecoLivro", "Preço do Livro");
            dataGridViewItensCarrinho.Columns.Add("Quantidade", "Quantidade");
            dataGridViewItensCarrinho.Columns.Add("Imagem", "Imagem");
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            // Inicializar o carrinho
            carrinho = new Carrinho();

            // Carregar os itens do carrinho no DataGridView
            List<ItemDeCompra> itens = carrinhoController.ObterCarrinho(carrinho);

            if (itens.Count > 0)
            {
                foreach (ItemDeCompra item in itens)
                {
                    dataGridViewItensCarrinho.Rows.Add(item.Livro.Id, item.NomeLivro, item.PrecoLivro, item.Quantidade, item.Livro.Imagem);
                }
            }
            else
            {
                MessageBox.Show("O carrinho está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
