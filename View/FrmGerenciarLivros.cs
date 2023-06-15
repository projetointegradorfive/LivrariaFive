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
        Autor autorSelecionado = new Autor();


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
            txtAutorGerenciarLivros.Text = "";
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
            dgvMostrarLivros.DataSource = livros.GetAllLivros();
            dgvMostrarLivros.Columns["img64"].Visible = false;
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
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Titulo = row.Cells["Titulo"].Value.ToString(),
                    Isbn = row.Cells["Isbn"].Value.ToString(),
                    AnoPublicacao = Convert.ToInt32(row.Cells["AnoPublicacao"].Value),
                    Preco = Convert.ToInt32(row.Cells["Preco"].Value),
                    Estoque = Convert.ToInt32(row.Cells["Estoque"].Value),
                    Descricao = row.Cells["Descricao"].Value.ToString(),
                    Idioma = row.Cells["Idioma"].Value.ToString(),
                    Editora = row.Cells["Editora"].Value.ToString(),
                    Genero = row.Cells["Genero"].Value.ToString(),
                    Autor = row.Cells["Autor"].Value.ToString(),
                    img64 = row.Cells["img64"].Value.ToString()

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
                txtAutorGerenciarLivros.Text = livroSelecionado.Autor;

                byte[] imagemBytes = Convert.FromBase64String(livroSelecionado.img64);

                // Cria um MemoryStream com os bytes da imagem
                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    // Cria um objeto de imagem a partir do MemoryStream
                    Image imagem = Image.FromStream(ms);

                    // Exibe a imagem na PictureBox
                    pbFotoLivroGerenciarLivros.Image = imagem;
                }
                autorSelecionado = new Autor { Nome = livroSelecionado.Autor };

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
                livroSelecionado.Autor = txtAutorGerenciarLivros.Text;

                // Atualizar a imagem do livro
                if (pbFotoLivroGerenciarLivros.Image != null)
                {
                    livroSelecionado.Imagem = pbFotoLivroGerenciarLivros.Image;
                }
                else
                {
                    livroSelecionado.Imagem = null;
                }

                AutorController autorController = new AutorController();
                Autor autorExistente = autorController.ObterAutorPorNome(txtAutorGerenciarLivros.Text);
                LivroController livroController = new LivroController();
                if (autorExistente == null)
                {
                    // O autor não existe, então altere no banco de dados
                    Autor autor = new Autor { Nome = txtAutorGerenciarLivros.Text };
                    livroController.UpdateLivro(livroSelecionado, autor);
                    autorExistente = autorController.ObterAutorPorNome(autor.Nome); // Obtém o autor recém-inserido com o ID
                    MessageBox.Show("Um novo autor foi criado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                autorSelecionado = autorExistente;
                livroController.UpdateLivro(livroSelecionado, autorSelecionado);               
                MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBoxes();               

                // Atualizar o DataGridView com os livros atualizados
                LivroController livros = new LivroController();
                dgvMostrarLivros.DataSource = livros.GetAllLivros();
                dgvMostrarLivros.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado para editar.");
            }
        }
    }
}
