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

namespace LivrariaFive.View
{
    public partial class FormCadastrarLivro : Form
    {
        public FormCadastrarLivro()
        {
            InitializeComponent();
        }
        private void FormCadastrarLivro_Load(object sender, EventArgs e)
        {
            PreencherComboBox();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            string nomeLivro = txtNomeLivro.Text;
            string nomeGenero = txtGeneroLivro.Text;
            string nomeAutor = txtAutorLivro.Text;

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

            // Verificar se o nome do autor está vazio
            if (!string.IsNullOrEmpty(nomeAutor))
            {
                AutorController autorController = new AutorController();
                Autor autor = new Autor { Nome = nomeAutor };
                autorController.InserirAutor(autor);

                livro.Autor = autor.Nome;
            }

            // Verificar se o nome do gênero está vazio
            if (!string.IsNullOrEmpty(nomeGenero))
            {
                GeneroController generoController = new GeneroController();
                Genero genero = new Genero { Nome = nomeGenero };
                generoController.InserirGenero(genero);

                livro.Genero = genero.Nome;
            }

            // Verificar se o nome da editora está vazio
            if (!string.IsNullOrEmpty(txtEditora.Text))
            {
                EditoraController editoraController = new EditoraController();
                Editora editora = new Editora { Nome = txtEditora.Text };
                editoraController.InserirEditora(editora);

                livro.Editora= editora.Nome;
            }

            // Chamar o método Insert do controlador LivroController para cadastrar o livro
            LivroController livroController = new LivroController();
            livroController.Insert(livro);

            // Exibir mensagem de sucesso
            MessageBox.Show("Livro cadastrado com sucesso!");
        }


        private void PreencherComboBox()
        {
            // Obter os gêneros do banco de dados
            GeneroController generoController = new GeneroController();
            List<Genero> generos = generoController.ObterTodosGeneros();

            // Definir os dados do ComboBox de Gênero
            comboBoxGenero.DataSource = generos;
            comboBoxGenero.DisplayMember = "Nome";
            comboBoxGenero.SelectedIndex = -1; // Nenhum item selecionado

            // Obter os autores do banco de dados
            AutorController autorController = new AutorController();
            List<Autor> autores = autorController.ObterTodosAutores();

            // Definir os dados do ComboBox de Autor
            comboBoxAutor.DataSource = autores;
            comboBoxAutor.DisplayMember = "Nome";
            comboBoxAutor.SelectedIndex = -1; // Nenhum item selecionado

        }
    }
}
