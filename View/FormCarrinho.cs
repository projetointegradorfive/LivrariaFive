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

namespace LivrariaFive.View
{
    public partial class FormCarrinho : Form
    {
        private List<ItemDeCompra> itensCarrinho = new List<ItemDeCompra>();
        

        public FormCarrinho()
        {
            InitializeComponent();
           
        }

        public void AdicionarItensCarrinho(List<ItemDeCompra> itensSelecionados)
        {
            // Adicione os itens selecionados à lista de itens do carrinho
            itensCarrinho.AddRange(itensSelecionados);

            // Exiba os itens no DataGridView
            ExibirItensCarrinho();
        }

        private void ExibirItensCarrinho()
        {
            // Limpar as colunas existentes no DataGridView
            dataGridViewItensCarrinho.Columns.Clear();

            // Adicionar as colunas ao DataGridView
            dataGridViewItensCarrinho.Columns.Add("Titulo", "Título");
            dataGridViewItensCarrinho.Columns.Add("Preco", "Preço");
            dataGridViewItensCarrinho.Columns.Add("Quantidade", "Quantidade");
            dataGridViewItensCarrinho.Columns.Add("PrecoUnitario", "Preço Unitário");

            // Limpar as linhas existentes no DataGridView
            dataGridViewItensCarrinho.Rows.Clear();

            // Adicionar as linhas correspondentes aos itens do carrinho
            foreach (ItemDeCompra item in itensCarrinho)
            {
                // Crie uma nova linha com as células correspondentes
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewItensCarrinho,
                    item.Livro.Titulo,
                    item.Livro.Preco,
                    item.Quantidade,
                    item.PrecoUnitario);

                // Adicione a linha ao DataGridView
                dataGridViewItensCarrinho.Rows.Add(row);
            }
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {

        }
    }
}
