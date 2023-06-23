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
        private List<Autor> autores;
        public FormCadastrarLivro()
        {
            InitializeComponent();
            autores = new List<Autor>(); ;

        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeLivro.Text) ||
                string.IsNullOrWhiteSpace(txtGeneroLivro.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtAnoPublicacao.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtEstoque.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtIdioma.Text) ||
                pbFoto.Image == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nomeLivro = txtNomeLivro.Text;
            string nomeGenero = txtGeneroLivro.Text;
            //string nomeAutor = txtAutorLivro.Text;
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

            
            byte[] byteArray;
            using (MemoryStream ms = new MemoryStream())
            {
                livro.Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byteArray = ms.ToArray();
            }
            livro.img64 = Convert.ToBase64String(byteArray);

            // Adicionar os autores selecionados ao livro
            // Adicionar os autores selecionados ao livro
            livro.Autores = new List<Autor>();
            foreach (var item in lstAutores.Items)
            {
                string nomeAutor = item.ToString();
                Autor autorExistente = autorController.ObterAutorPorNome(nomeAutor);

                if (autorExistente == null)
                {
                    // O autor não existe no banco de dados, portanto, você pode criar uma nova instância
                    Autor autor = new Autor { Nome = nomeAutor };
                    livro.Autores.Add(autor);

                    // Chame o método Insert do controlador AutorController para cadastrar o novo autor no banco de dados
                    autorController.InserirAutor(autor);
                }
                else
                {
                    // O autor já existe, você pode atribuí-lo diretamente ao livro
                    livro.Autores.Add(autorExistente);
                }
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
            livroController.Insert(livro, livro.Autores);

            // Exibir mensagem de sucesso
            MessageBox.Show("Livro cadastrado com sucesso!");
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecionar Imagem";
            Livro livroSelecionado = new Livro();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminhoImagem = openFileDialog.FileName;
                    Image novaImagem = Image.FromFile(caminhoImagem);

                    // Remover a imagem existente, se houver
                    if (pbFoto.Image != null)
                    {
                        pbFoto.Image.Dispose();
                    }

                    // Exibir a nova imagem na PictureBox
                    pbFoto.Image = novaImagem;

                    // Armazenar a nova imagem no livro
                    livroSelecionado.Imagem = novaImagem;
                    byte[] byteArray;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        novaImagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byteArray = ms.ToArray();
                    }
                    livroSelecionado.img64 = Convert.ToBase64String(byteArray);
                    MessageBox.Show("Imagem editada com sucesso!");
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

        private void btnSalvarAutores_Click(object sender, EventArgs e)
        {
            string autorTxt = txtAutorLivro.Text;
            if (!string.IsNullOrWhiteSpace(autorTxt))
            {
                lstAutores.Items.Add(autorTxt);
                txtAutorLivro.Clear();
            }
            else
            {
                MessageBox.Show("Informe pelo menos um autor");
            }

            // Percorrer os itens selecionados no ListBox e adicionar os autores à lista
            foreach (var item in lstAutores.Items)
            {
                string nomeAutor = item.ToString();
                Autor autorExistente = autores.FirstOrDefault(a => a.Nome == nomeAutor);

                if (autorExistente == null)
                {
                    // O autor não existe na lista, então podemos adicionar
                    Autor autor = new Autor { Nome = nomeAutor };
                    autores.Add(autor);
                }
            }

        }
    }
}