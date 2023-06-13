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
using LivrariaFive.Persistence;

namespace LivrariaFive.View
{
    public partial class FrmGerenciarLivros : Form
    {
        Livro livroSelecionado = new Livro();


        public FrmGerenciarLivros()
        {
            InitializeComponent();
        }

        private void LimparTextBoxes()
        {
            txtId.Text = "";
            txtTitulo.Text = "";
            txtPreco.Text = "";
            txtIsbn.Text = "";
            txtIdioma.Text = "";
            txtGenero.Text = "";
            txtEstoque.Text = "";
            txtEditora.Text = "";
            txtDescricao.Text = "";
            txtAnoPublicacao.Text = "";
            pbFotoLivroGerenciarLivros.Image = null;
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

        private void btnEditarFotoGerenciarLivros_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecionar Imagem";

            Livro livro = new Livro();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminhoImagem = openFileDialog.FileName;
                    Image novaImagem = Image.FromFile(caminhoImagem);

                    // Remover a imagem existente, se houver
                    if (pbFotoLivroGerenciarLivros.Image != null)
                    {
                        pbFotoLivroGerenciarLivros.Image.Dispose();
                    }

                    // Exibir a nova imagem na PictureBox
                    pbFotoLivroGerenciarLivros.Image = novaImagem;

                    // Armazenar a nova imagem no livro
                    livro.Imagem = novaImagem;

                    MessageBox.Show("Imagem editada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message);
                }
            }
        }

        private void btnLimparTextBox_Click(object sender, EventArgs e)
        {
            LimparTextBoxes();
        }

        private void btnSalvarAlteracoesGerenciarLivros_Click(object sender, EventArgs e)
        {
            if (livroSelecionado != null)
            {
                // Atualizar as informações do livro com base nas TextBox
                livroSelecionado.Titulo = txtTitulo.Text;
                livroSelecionado.Isbn = txtIsbn.Text;
                livroSelecionado.Preco = Convert.ToDouble(txtPreco.Text);
                livroSelecionado.AnoPublicacao = Convert.ToInt32(txtAnoPublicacao.Text);
                livroSelecionado.Idioma = txtIdioma.Text;
                livroSelecionado.Estoque = Convert.ToInt32(txtEstoque.Text);
                livroSelecionado.Genero = txtGenero.Text;
                livroSelecionado.Editora = txtEditora.Text;
                livroSelecionado.Descricao = txtDescricao.Text;

                // Atualizar a imagem do livro
                if (pbFotoLivroGerenciarLivros.Image != null)
                {
                    livroSelecionado.Imagem = pbFotoLivroGerenciarLivros.Image;
                }
                else
                {
                    livroSelecionado.Imagem = null;
                }

                // Chamar o método para atualizar o livro no banco de dados
                LivroController livroController = new LivroController();
                livroController.UpdateLivro(livroSelecionado);

                MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBoxes();
                pbFotoLivroGerenciarLivros.Image = null;

                // Atualizar o DataGridView com os livros atualizados
                LivroController livros = new LivroController();
                DataTable dt = livros.ObtertodosLivrosGerenciarLivros();
                dgvMostrarLivros.DataSource = dt;
                dgvMostrarLivros.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado para editar.");
            }
        }
    }
}
