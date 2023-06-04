﻿using System;
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
            dgvCarrinho.Columns.Add("Id", "ID");
            dgvCarrinho.Columns.Add("NomeLivro", "Nome do Livro");
            dgvCarrinho.Columns.Add("PrecoLivro", "Preço do Livro");
            dgvCarrinho.Columns.Add("Quantidade", "Quantidade");
            dgvCarrinho.Columns.Add("Imagem", "Imagem");
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            // Inicializar o carrinho
            carrinho = new Carrinho();

            ConfigurarGrade();
            // Carregar os itens do carrinho
            CarregarItensCarrinho();
        }
        private void ConfigurarGrade()
        {
            dgvCarrinho.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvCarrinho.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvCarrinho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
