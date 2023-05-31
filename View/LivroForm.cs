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
    public partial class LivroForm : Form
    {
        private Cliente clienteAtual;
        private LivroController livroController;
        private FormCarrinho formCarrinho;
        public FormCarrinho FormCarrinho { get; set; }


        public LivroForm(Cliente cliente, FormCarrinho carrinhoForm)
        {
            InitializeComponent();
            clienteAtual = cliente;
            livroController = new LivroController();
            FormCarrinho = carrinhoForm;



        }
        private void LivroForm_Load_1(object sender, EventArgs e)
        {


            PrencherDataGrid();
            ConfigurarGrade();
        }

        public void ConfigurarGrade()
        {
            dataGridViewLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridViewLivros.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridViewLivros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewLivros.Columns["Id"].Width = 50;
            dataGridViewLivros.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLivros.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewLivros.Columns["Titulo"].Width = 300;
            dataGridViewLivros.Columns["Isbn"].Width = 100;
            dataGridViewLivros.Columns["Preco"].Width = 100;
            dataGridViewLivros.Columns["Descricao"].Width = 200;
            dataGridViewLivros.Columns["Genero"].Width = 150;
            dataGridViewLivros.Columns["Editora"].Width = 150;
            dataGridViewLivros.Columns["Autor"].Width = 150;


        }


        public void PrencherDataGrid()
        {
            IList<Livro> livros = livroController.GetAllLivros();
            dataGridViewLivros.Columns.Clear();
            dataGridViewLivros.Rows.Clear();
            dataGridViewLivros.Columns.Add("Id", "ID");
            dataGridViewLivros.Columns.Add("Titulo", "Título");
            dataGridViewLivros.Columns.Add("Isbn", "ISBN");
            dataGridViewLivros.Columns.Add("Preco", "Preço");
            dataGridViewLivros.Columns.Add("Descricao", "Descrição");
            dataGridViewLivros.Columns.Add("Genero", "Gênero");
            dataGridViewLivros.Columns.Add("Editora", "Editora");
            dataGridViewLivros.Columns.Add("Autor", "Autor");
            dataGridViewLivros.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Imagem",
                HeaderText = "Imagem",
                ImageLayout = DataGridViewImageCellLayout.Zoom, // Ajuste o layout da imagem conforme necessário
                Width = 100
            });



            foreach (Livro livro in livros)
            {
                string autor = livroController.GetAutorName(livro.Autor); //pegando o nome do autor
                dataGridViewLivros.Rows.Add(
                    livro.Id,
                    livro.Titulo,
                    livro.Isbn,
                    livro.Preco,
                    livro.Descricao,
                    livro.Genero,
                    livro.Editora,
                    autor,  // Nome do autor
                    livro.Imagem
                );
            }

            // Crie uma nova instância de DataGridViewCheckBoxColumn
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Selecionado";
            checkBoxColumn.Name = "checkBoxColumn";

            // Adicione a coluna ao DataGridView
            dataGridViewLivros.Columns.Add(checkBoxColumn);


        }


        private void dataGridViewLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewLivros.Rows[e.RowIndex];
                string titulo = selectedRow.Cells["Titulo"].Value.ToString();
                string isbn = selectedRow.Cells["Isbn"].Value.ToString();
                string preco = selectedRow.Cells["Preco"].Value.ToString();
                string descricao = selectedRow.Cells["Descricao"].Value != null
                    ? selectedRow.Cells["Descricao"].Value.ToString()
                    : string.Empty;
                string genero = selectedRow.Cells["Genero"].Value != null
                    ? selectedRow.Cells["Genero"].Value.ToString()
                    : string.Empty;

                string editora = selectedRow.Cells["Editora"].Value != null
                    ? selectedRow.Cells["Editora"].Value.ToString()
                    : string.Empty;

                string autor = selectedRow.Cells["Autor"].Value != null
                    ? selectedRow.Cells["Autor"].Value.ToString()
                    : string.Empty;

                Image imagem = (Image)selectedRow.Cells["Imagem"].Value;

                DetalhesLivro detalhesForm = new DetalhesLivro(titulo, isbn, preco, descricao, genero, editora, autor, imagem);
                detalhesForm.ShowDialog();
            }

        }

        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            string filtroGenero = txtBuscarGenero.Text; // Valor digitado no campo de texto para o gênero
            FiltrarLivrosPorGenero(filtroGenero);

        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            string filtroNome = txtBuscarNome.Text; // Valor digitado no campo de texto para o nome

            FiltrarLivrosPorNome(filtroNome);

        }

        private void FiltrarLivrosPorNome(string filtroNome)
        {
            // Percorrer as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewLivros.Rows)
            {
                string titulo = row.Cells["Titulo"].Value?.ToString();

                // Verificar se o título corresponde ao filtro de nome
                if ((!string.IsNullOrEmpty(titulo) && titulo.Contains(filtroNome)))
                {
                    row.Visible = true; // Exibir a linha se corresponder ao filtro de nome
                }
                else
                {
                    row.Visible = false; // Ocultar a linha se não corresponder ao filtro de nome
                }
            }
        }

        private void FiltrarLivrosPorGenero(string filtroGenero)
        {
            // Percorrer as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewLivros.Rows)
            {
                string genero = row.Cells["Genero"].Value?.ToString();

                // Verificar se o gênero corresponde ao filtro de gênero
                if ((!string.IsNullOrEmpty(genero) && genero.Contains(filtroGenero)))
                {
                    row.Visible = true; // Exibir a linha se corresponder ao filtro de gênero
                }
                else
                {
                    row.Visible = false; // Ocultar a linha se não corresponder ao filtro de gênero
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            // Limpar informações do cliente atual ou executar qualquer ação necessária para o logout
            clienteAtual = null;

            // Exibir o formulário de login
            FormLoginUser formLoginUser = new FormLoginUser();
            formLoginUser.Show();

            // Fechar o formulário atual (LivroForm)
            this.Close();

        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            List<ItemDeCompra> itensSelecionados = ObterItensDeCompraSelecionados();

            if (formCarrinho == null || formCarrinho.IsDisposed) // Verifique se o formulário não está aberto ou foi descartado
            {
                formCarrinho = new FormCarrinho(); // Crie uma nova instância do FormCarrinho
            }

            // Atualize os itens do carrinho no FormCarrinho
            formCarrinho.AdicionarItensCarrinho(itensSelecionados);

            // Exiba o FormCarrinho
            formCarrinho.Show();

            // Limpar a seleção no DataGridView
            LimparSelecaoDataGridView();



        }


        private void LimparSelecaoDataGridView()
        {
            foreach (DataGridViewRow row in dataGridViewLivros.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumn"];
                checkBoxCell.Value = false;
            }

            dataGridViewLivros.EndEdit(); // Finaliza a edição das células
        }
        private List<ItemDeCompra> ObterItensDeCompraSelecionados()
        {
            List<ItemDeCompra> itensSelecionados = new List<ItemDeCompra>();

            foreach (DataGridViewRow row in dataGridViewLivros.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && checkBoxCell.Value != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    // Obter os valores das células correspondentes às colunas desejadas
                    string titulo = row.Cells["Titulo"].Value?.ToString();
                    string isbn = row.Cells["Isbn"].Value?.ToString();
                    string preco = row.Cells["Preco"].Value?.ToString();
                    string descricao = row.Cells["Descricao"].Value?.ToString();
                    string genero = row.Cells["Genero"].Value?.ToString();
                    string editora = row.Cells["Editora"].Value?.ToString();
                    string autor = row.Cells["Autor"].Value?.ToString();
                    Image imagem = (Image)row.Cells["Imagem"].Value;

                    // Criar o objeto Livro com base nos valores obtidos
                    Livro livro = new Livro()
                    {
                        Titulo = titulo,
                        Isbn = isbn,
                        Preco = double.Parse(preco),
                        Descricao = descricao,
                        Genero = genero,
                        Editora = editora,
                        Autor = autor,
                        Imagem = imagem
                    };

                    // Criar o ItemDeCompra com base no livro selecionado
                    ItemDeCompra item = new ItemDeCompra()
                    {
                        Livro = livro,
                        Quantidade = 1,  // Defina a quantidade desejada aqui
                        PrecoUnitario = livro.Preco  // Defina o preço unitário do livro aqui
                    };

                    itensSelecionados.Add(item);
                }
            }

            if (itensSelecionados.Count > 0)
            {
                // Exibir mensagem de sucesso se houver itens selecionados
                MessageBox.Show("Livro(s) adicionado(s) ao carrinho com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                // Exibir mensagem de erro se nenhum item for selecionado
                MessageBox.Show("Nenhum livro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return itensSelecionados;
        }




        private void dataGridViewLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewLivros.Columns["checkBoxColumn"].Index)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridViewLivros.Rows[e.RowIndex].Cells["checkBoxColumn"];
                checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                dataGridViewLivros.EndEdit(); // Finaliza a edição da célula
            }
        }

        private void btnAbrirCarrinho_Click(object sender, EventArgs e)
        {

            FormCarrinho formCarrinho = new FormCarrinho();
            formCarrinho.ShowDialog();
        }
    }
}




