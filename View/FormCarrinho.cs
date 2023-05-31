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

namespace LivrariaFive.View
{
    public partial class FormCarrinho : Form
    {
        private const string carrinhoFilePath = "carrinho.json"; //caminho e nome do arquivo de dados

        private List<ItemDeCompra> itensCarrinho = new List<ItemDeCompra>();


        public FormCarrinho()
        {
            InitializeComponent();
            // Crie as colunas no evento Load do formulário
            dataGridViewItensCarrinho.Columns.Add("Titulo", "Título");
            dataGridViewItensCarrinho.Columns.Add("Preco", "Preço");
            dataGridViewItensCarrinho.Columns.Add("Quantidade", "Quantidade");
            dataGridViewItensCarrinho.Columns.Add("PrecoUnitario", "Preço Unitário");
            dataGridViewItensCarrinho.Columns.Add("Imagem", "Imagem");

        }

        public void AdicionarItensCarrinho(List<ItemDeCompra> itensSelecionados)
        {
            foreach (ItemDeCompra itemSelecionado in itensSelecionados)
            {
                bool itemExistente = itensCarrinho.Any(i => i.Livro.Titulo == itemSelecionado.Livro.Titulo);
                if (!itemExistente)
                {
                    itensCarrinho.Add(itemSelecionado);
                }
            }

            // Salve os itens do carrinho em um arquivo
            SaveCarrinhoData();

            // Exiba os itens no DataGridView
            ExibirItensCarrinho();
        }



        private void ExibirItensCarrinho()
        {// Limpar as linhas existentes no DataGridView
           

            // Adicionar as linhas correspondentes aos itens do carrinho
            foreach (ItemDeCompra item in itensCarrinho)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewItensCarrinho,
                    item.Livro.Titulo,
                    item.Livro.Preco,
                    item.Quantidade,
                    item.PrecoUnitario,
                    null); // Célula de imagem vazia

                dataGridViewItensCarrinho.Rows.Add(row);
            }


        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
           
            // Carregue os itens do carrinho do arquivo

            LoadCarrinhoData();

            ExibirItensCarrinho();

        }

        private void SaveCarrinhoData()
        {
            CarrinhoData carrinhoData = new CarrinhoData()
            {
                Itens = new List<ItemDeCompra>()
            };

            // Crie uma cópia dos itens do carrinho com a imagem removida
            foreach (var item in itensCarrinho)
            {
                carrinhoData.Itens.Add(new ItemDeCompra
                {
                    Livro = new Livro
                    {
                        Titulo = item.Livro.Titulo,
                        Preco = item.Livro.Preco
                    },
                    Quantidade = item.Quantidade,
                    PrecoUnitario = item.PrecoUnitario
                });
            }

            string json = JsonConvert.SerializeObject(carrinhoData);
            File.WriteAllText(carrinhoFilePath, json);
        }

        private void LoadCarrinhoData()
        {
            if (File.Exists(carrinhoFilePath))
            {
                string json = File.ReadAllText(carrinhoFilePath);
                CarrinhoData carrinhoData = JsonConvert.DeserializeObject<CarrinhoData>(json);

                if (carrinhoData != null && carrinhoData.Itens != null)
                {
                    itensCarrinho.AddRange(carrinhoData.Itens);
                }
            }
        }

      
    }
}
