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
        private List<Autor> autoresAtualizados;


        public FrmGerenciarLivros()
        {
            InitializeComponent();
            autoresAtualizados = new List<Autor>();
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
            PreencherDataGridLivros();
            dgvMostrarLivros.DataSource = livros.GetAllLivrosADMIN();
            dgvMostrarLivros.Columns["img64"].Visible = false;
            dgvMostrarLivros.Refresh();


        }

        public void PreencherDataGridLivros()
        {
            dgvMostrarLivros.AutoGenerateColumns = false; // Desabilita a geração automática das colunas

            // Adicione as colunas necessárias aqui
            dgvMostrarLivros.Columns.Add("Id", "ID");
            dgvMostrarLivros.Columns.Add("Titulo", "Título");
            dgvMostrarLivros.Columns.Add("Autores", "Autores");
            dgvMostrarLivros.Columns["Autores"].DataPropertyName = "NomesAutores";
            dgvMostrarLivros.Columns["Autores"].Width = 200;
            dgvMostrarLivros.Columns.Add("Isbn", "ISBN");
            dgvMostrarLivros.Columns.Add("AnoPublicacao", "Ano de Publicação");
            dgvMostrarLivros.Columns.Add("Preco", "Preço");
            dgvMostrarLivros.Columns.Add("Estoque", "Estoque");
            dgvMostrarLivros.Columns.Add("Descricao", "Descrição");
            dgvMostrarLivros.Columns.Add("Idioma", "Idioma");
            dgvMostrarLivros.Columns.Add("Editora", "Editora");
            dgvMostrarLivros.Columns.Add("Genero", "Gênero");
            dgvMostrarLivros.Columns.Add("img64", "Imagem");
            dgvMostrarLivros.Columns.Add("Ativo", "Livro Ativo");

            // Configure as propriedades das colunas, como largura e alinhamento, se necessário
            dgvMostrarLivros.Columns["Id"].Width = 50;
            dgvMostrarLivros.Columns["Preco"].DefaultCellStyle.Format = "C2";

            // Mapeie as colunas para as propriedades corretas do objeto Livro
            dgvMostrarLivros.Columns["Id"].DataPropertyName = "Id";
            dgvMostrarLivros.Columns["Titulo"].DataPropertyName = "Titulo";
            dgvMostrarLivros.Columns["Isbn"].DataPropertyName = "Isbn";
            dgvMostrarLivros.Columns["AnoPublicacao"].DataPropertyName = "AnoPublicacao";
            dgvMostrarLivros.Columns["Preco"].DataPropertyName = "Preco";
            dgvMostrarLivros.Columns["Estoque"].DataPropertyName = "Estoque";
            dgvMostrarLivros.Columns["Descricao"].DataPropertyName = "Descricao";
            dgvMostrarLivros.Columns["Idioma"].DataPropertyName = "Idioma";
            dgvMostrarLivros.Columns["Editora"].DataPropertyName = "Editora";
            dgvMostrarLivros.Columns["Genero"].DataPropertyName = "Genero";
            dgvMostrarLivros.Columns["img64"].DataPropertyName = "img64";
            dgvMostrarLivros.Columns["Ativo"].DataPropertyName = "Ativo";

           
            ConfigurarGrade();
        }

        private void dgvMostrarLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMostrarLivros.Rows[e.RowIndex];

                // Atribuir o livro selecionado com base na linha clicada do DataGridView
                livroSelecionado = new Livro
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Titulo = row.Cells["Titulo"].Value.ToString(),
                    Isbn = row.Cells["Isbn"].Value.ToString(),
                    AnoPublicacao = Convert.ToInt32(row.Cells["AnoPublicacao"].Value),
                    Preco = Convert.ToDouble(row.Cells["Preco"].Value),
                    Estoque = Convert.ToInt32(row.Cells["Estoque"].Value),
                    Descricao = row.Cells["Descricao"].Value.ToString(),
                    Idioma = row.Cells["Idioma"].Value.ToString(),
                    Editora = row.Cells["Editora"].Value.ToString(),
                    Autor = row.Cells["Autores"].Value.ToString(),
                    Genero = row.Cells["Genero"].Value.ToString(),
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
            }
        }


        private void btnEditarFotoGerenciarLivros_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecionar Imagem";


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

        private void btnLimparTextBox_Click(object sender, EventArgs e)
        {
            LimparTextBoxes();
        }
        public void ConfigurarGrade()
        {
            dgvMostrarLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvMostrarLivros.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvMostrarLivros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvMostrarLivros.Columns["Id"].Width = 50;
            dgvMostrarLivros.Columns["Id"].HeaderText = "ID";
            dgvMostrarLivros.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMostrarLivros.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMostrarLivros.Columns["Titulo"].Width = 300;
            dgvMostrarLivros.Columns["Titulo"].HeaderText = "Título";

            dgvMostrarLivros.Columns["Autores"].Width = 200;
            dgvMostrarLivros.Columns["Autores"].HeaderText = "Autores";
            dgvMostrarLivros.Columns["Autores"].DataPropertyName = "NomesAutores";

            dgvMostrarLivros.Columns["Isbn"].Width = 100;
            dgvMostrarLivros.Columns["Isbn"].HeaderText = "ISBN";

            dgvMostrarLivros.Columns["AnoPublicacao"].Width = 150;
            dgvMostrarLivros.Columns["AnoPublicacao"].HeaderText = "Ano de Publicação";

            dgvMostrarLivros.Columns["Preco"].Width = 100;
            dgvMostrarLivros.Columns["Preco"].HeaderText = "Preço";
            dgvMostrarLivros.Columns["Preco"].DefaultCellStyle.Format = "C2";

            dgvMostrarLivros.Columns["Estoque"].Width = 100;
            dgvMostrarLivros.Columns["Estoque"].HeaderText = "Estoque";

            dgvMostrarLivros.Columns["Descricao"].Width = 200;
            dgvMostrarLivros.Columns["Descricao"].HeaderText = "Descrição";

            dgvMostrarLivros.Columns["Idioma"].Width = 100;
            dgvMostrarLivros.Columns["Idioma"].HeaderText = "Idioma";

            dgvMostrarLivros.Columns["Editora"].Width = 150;
            dgvMostrarLivros.Columns["Editora"].HeaderText = "Editora";

            dgvMostrarLivros.Columns["Genero"].Width = 150;
            dgvMostrarLivros.Columns["Genero"].HeaderText = "Gênero";


            dgvMostrarLivros.Columns["img64"].Visible = false; // Esconder a coluna da imagem
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

                AutorController autorController = new AutorController();
                string[] autores = txtAutorGerenciarLivros.Text.Split(',');

                // Atualizar os autores do livro
                foreach (string autorNome in autores)
                {
                    string nome = autorNome.Trim();
                    Autor autorExistente = autorController.ObterAutorPorNome(nome);

                    if (autorExistente == null)
                    {
                        // O autor não existe, insere um novo autor no banco de dados
                        Autor novoAutor = new Autor { Nome = nome };
                        autorController.InserirAutor(novoAutor);
                        autorExistente = novoAutor;
                    }

                    autoresAtualizados.Add(autorExistente);
                }

                livroSelecionado.Autores = autoresAtualizados;

                    
                    


                LivroController livroController = new LivroController();
                livroController.UpdateLivro(livroSelecionado, autoresAtualizados);

                MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBoxes();

                // Atualizar o DataGridView com os livros atualizados
                LivroController livros = new LivroController();
                dgvMostrarLivros.DataSource = livros.GetAllLivrosADMIN();
                dgvMostrarLivros.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado para editar.");
            }
        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdioma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirGerenciarLivros_Click(object sender, EventArgs e)
        {
            
            LivroController metodoObter = new LivroController();

            if (livroSelecionado != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o livro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LivroController livroController = new LivroController();
                    livroController.RemoverLivro(livroSelecionado.Id);

                    LimparTextBoxes();
                    dgvMostrarLivros.DataSource = metodoObter.GetAllLivrosADMIN();
                    dgvMostrarLivros.Refresh();

                    MessageBox.Show("Livro excluído com sucesso!");
                }

            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado para excluir.");
            }



        }

        private void btnReativa_Click(object sender, EventArgs e)
        {
            LivroController metodoObter = new LivroController();

            if (livroSelecionado != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja ativar o livro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    LivroController livroController = new LivroController();
                    livroController.AtivaLivro(livroSelecionado.Id);

                    LimparTextBoxes();
                    dgvMostrarLivros.DataSource = metodoObter.GetAllLivrosADMIN();
                    dgvMostrarLivros.Refresh();

                    MessageBox.Show("Livro ativo com sucesso!");
                }

            }
            else
            {
                MessageBox.Show("Nenhum livro selecionado para ativar.");
            }


        }
    }
}
