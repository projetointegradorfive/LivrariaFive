using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaFive.Controller;
using LivrariaFive.Model;
using System.IO;
using System.Drawing.Text;

namespace LivrariaFive.View
{
    public partial class FormCadastrarLivro : Form
    {

        AutorController autorController = new AutorController();
        Autor autor = new Autor();
        GeneroController generoController = new GeneroController();
        Genero genero = new Genero();
        EditoraController editoraController = new EditoraController();
        Editora editora = new Editora();
        public FormCadastrarLivro()
        {
            InitializeComponent();

        }
        private void FormCadastrarLivro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            string nomeLivro = txtNomeLivro.Text;
            string nomeGenero = txtGeneroLivro.Text;
            string nomeAutor = txtAutorLivro.Text;
            string nomeEditora = txtEditora.Text;

            // Verificar se o nome do livro está vazio
            if (string.IsNullOrEmpty(nomeLivro))
            {
                MessageBox.Show("Digite o nome do livro.");
                return;
            }

            // Criar uma instância do objeto Livro e preencher suas propriedades
            Livro livro = new Livro();
            livro.Titulo = nomeLivro;
            livro.Isbn = txtISBN.Text;
            livro.AnoPublicacao = int.Parse(txtAnoPublicacao.Text);
            livro.Preco = double.Parse(txtPreco.Text);
            livro.Estoque = int.Parse(txtEstoque.Text);
            livro.Descricao = txtDescricao.Text;
            livro.Idioma = txtIdioma.Text;
            livro.Imagem = pbFoto.Image;


            // Verificar se o nome do autor está vazio
            if (!string.IsNullOrEmpty(nomeAutor))
            {
                Autor autorExistente = autorController.ObterAutorPorNome(nomeAutor);

                if (autorExistente == null)
                {
                    // O autor não existe no banco de dados, portanto, você pode criar uma nova instância
                    Autor autor = new Autor { Nome = nomeAutor };
                    livro.Autor = autor.Nome;

                    // Chame o método Insert do controlador AutorController para cadastrar o novo autor no banco de dados
                    autorController.InserirAutor(autor);
                }
                else
                {
                    // O autor já existe, você pode atribuí-lo diretamente ao livro
                    livro.Autor = autorExistente.Nome;
                    autor.IdAutor = autorExistente.IdAutor;
                }
            }
            else
            {
                MessageBox.Show("Informe o Autor");
            }


            // Verificar se o nome do gênero está vazio
            if (!string.IsNullOrEmpty(nomeGenero))
            {
                Genero generoExistente = generoController.ObterGeneroPorNome(nomeGenero);

                if (generoExistente == null)
                {
                    // O gênero não existe no banco de dados, portanto, você pode criar uma nova instância
                    Genero genero = new Genero { Nome = nomeGenero };
                    livro.Genero = genero.Nome;

                    // Chame o método Insert do controlador GeneroController para cadastrar o novo gênero no banco de dados
                    generoController.InserirGenero(genero);
                }
                else
                {
                    // O gênero já existe, você pode atribuí-lo diretamente ao livro
                    livro.Genero = generoExistente.Nome;
                    genero.IdGenero = generoExistente.IdGenero;
                }
            }
            else
            {
                MessageBox.Show("Informe o Gênero");
            }


            // Verificar se o nome da editora está vazio
            if (!string.IsNullOrEmpty(nomeEditora))
            {
                Editora editoraExistente = editoraController.ObterEditoraPorNome(nomeEditora);

                if (editoraExistente == null)
                {
                    // A editora não existe no banco de dados, portanto, você pode criar uma nova instância
                    Editora editora = new Editora { Nome = nomeEditora };
                    livro.Editora = editora.Nome;

                    // Chame o método Insert do controlador EditoraController para cadastrar a nova editora no banco de dados
                    editoraController.InserirEditora(editora);
                }
                else
                {
                    // A editora já existe, você pode atribuí-la diretamente ao livro
                    livro.Editora = editoraExistente.Nome;
                    editora.Id = editoraExistente.Id;
                }
            }
            else
            {
                MessageBox.Show("Informe a Editora");
            }



            // Chamar o método Insert do controlador LivroController para cadastrar o livro
            LivroController livroController = new LivroController();
            livroController.Insert(livro);

            // Exibir mensagem de sucesso
            MessageBox.Show("Livro cadastrado com sucesso!");
        }




        private void btnAddFoto_Click(object sender, EventArgs e)
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
                    Image imagem = Image.FromFile(caminhoImagem);

                    // Exibir a imagem selecionada na PictureBox
                    pbFoto.Image = imagem;

                    // Armazenar a imagem no livro
                    livro.Imagem = imagem;

                    MessageBox.Show("Imagem adicionada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmGerenciarLivros volta = new FrmGerenciarLivros();
            this.Hide();
            volta.Show();
        }
    }
}