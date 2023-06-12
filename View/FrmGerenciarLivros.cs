using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LivrariaFive.Controller;
using LivrariaFive.Model;
using System.IO;

namespace LivrariaFive.View
{
    public partial class FrmGerenciarLivros : Form
    {
        Livro livroSelecionado = new Livro();


        public FrmGerenciarLivros()
        {
            InitializeComponent();
        }
        

        private void btnCadastrarLivroGerenciarLivros_Click(object sender, EventArgs e)
        {
            FormCadastrarLivro cadastrarLivro = new FormCadastrarLivro();
            this.Hide();
            cadastrarLivro.Show();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin volta = new FrmPrincipalAdmin();
            this.Hide();
            volta.Show();
        }

        private void FrmGerenciarLivros_Load(object sender, EventArgs e)
        {
            LivroController livros = new LivroController();
            DataTable dt = livros.ObtertodosLivrosGerenciarLivros();
            dgvMostrarLivros.DataSource = dt;
            dgvMostrarLivros.Refresh();
        }

        private void dgvMostrarLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMostrarLivros.Rows[e.RowIndex];

                // Atribuir o cliente selecionado com base na linha clicada do DataGridView
                livroSelecionado = new Livro
                {
                    Id = Convert.ToInt32(row.Cells["idLivro"].Value),
                    Titulo = row.Cells["titulo"].Value.ToString(),
                    Isbn = row.Cells["isbn"].Value.ToString(),
                    AnoPublicacao = Convert.ToInt32(row.Cells["anoPublicacao"].Value),
                    Preco = Convert.ToInt32(row.Cells["preco"].Value),
                    Estoque = Convert.ToInt32(row.Cells["estoque"].Value),
                    Descricao = row.Cells["descricao"].Value.ToString(),
                    Idioma = row.Cells["idioma"].Value.ToString(),
                    Editora = row.Cells["idEditora"].Value.ToString(),
                    Genero = row.Cells["idGenero"].Value.ToString()

                };

                // Preencher as TextBox com as informações do livro selecionado
                txtId.Text = livroSelecionado.Id.ToString();
                txtTitulo.Text = livroSelecionado.Titulo;
                txtIsbn.Text = livroSelecionado.Isbn;
                txtPreco.Text = livroSelecionado.Preco.ToString();
                txtAnoPublicacao.Text = livroSelecionado.AnoPublicacao.ToString();
                txtIdioma.Text = livroSelecionado.Idioma;
                txtEstoque.Text = livroSelecionado.Estoque.ToString();
                txtGenero.Text = livroSelecionado.Genero;
                txtEditora.Text = livroSelecionado.Editora;
                txtDescricao.Text = livroSelecionado.Descricao;

                byte[] imagemBytes = (byte[])row.Cells["livroImagem"].Value;
                Image imagem = null;
                if (imagemBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imagemBytes))
                    {
                        imagem = Image.FromStream(ms);
                    }
                }
                pbFotoLivroGerenciarLivros.Image = imagem;
        

            }   
        }
    }
}
