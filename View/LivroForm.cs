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
using LivrariaFive.View;

namespace LivrariaFive.View
{
    public partial class LivroForm : Form
    {
        private Cliente cliente;


        //private ItemDeCompraController itemDeCompraController;
        private Cliente clienteAtual;
        private LivroController livroController;
        private ItemDeCompraController itemDeCompraController;



        public LivroForm(Cliente cliente)
        {
            InitializeComponent();
            clienteAtual = cliente;
            this.cliente = cliente;
            livroController = new LivroController();
            itemDeCompraController = new ItemDeCompraController();


        }
        private void LivroForm_Load_1(object sender, EventArgs e)
        {
            PreencherDataGrid();
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
            dataGridViewLivros.Columns["Preco"].DefaultCellStyle.Format = "C2";

            dataGridViewLivros.Columns["Descricao"].Width = 200;
            dataGridViewLivros.Columns["Genero"].Width = 150;
            dataGridViewLivros.Columns["Editora"].Width = 150;
            dataGridViewLivros.Columns["Autor"].Width = 150;
        }


        public void PreencherDataGrid()
        {
            IList<Livro> livros = livroController.GetAllLivros();
            dataGridViewLivros.Columns.Clear();
            dataGridViewLivros.Rows.Clear();
            dataGridViewLivros.Columns.Add("Id", "ID");
            dataGridViewLivros.Columns.Add("Titulo", "Título");
            dataGridViewLivros.Columns.Add("Isbn", "ISBN");
            dataGridViewLivros.Columns.Add("Preco", "Preço");
            dataGridViewLivros.Columns.Add("Estoque", "Estoque");
            dataGridViewLivros.Columns.Add("Descricao", "Descrição");
            dataGridViewLivros.Columns.Add("Genero", "Gênero");
            dataGridViewLivros.Columns.Add("Editora", "Editora");
            dataGridViewLivros.Columns.Add("Autor", "Autor");
            dataGridViewLivros.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Imagem",
                HeaderText = "Imagem",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100
            });

            dataGridViewLivros.Columns["Estoque"].Visible = false;
            dataGridViewLivros.Columns["Id"].Visible = false;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Selecionado";
            checkBoxColumn.Name = "checkBoxColumn";
            checkBoxColumn.Width = 110;
            checkBoxColumn.ReadOnly = true; // Definindo a coluna como somente leitura
            dataGridViewLivros.Columns.Add(checkBoxColumn);

            DataGridViewTextBoxColumn quantidadeColumn = new DataGridViewTextBoxColumn();
            quantidadeColumn.HeaderText = "Quantidade";
            quantidadeColumn.Name = "quantidadeColumn";

            // Definir valor padrão de 1 para a coluna de quantidade nas linhas adicionadas
            dataGridViewLivros.RowsAdded += (sender, e) =>
            {
                foreach (DataGridViewRow row in dataGridViewLivros.Rows)
                {
                    row.Cells["quantidadeColumn"].Value = 1;
                }
            };


            dataGridViewLivros.Columns.Add(quantidadeColumn);

            foreach (Livro livro in livros)
            {
                string autores = string.Join(", ", livro.Autores.Select(autor => autor.Nome));
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewLivros,
                    livro.Id,
                    livro.Titulo,
                    livro.Isbn,
                    livro.Preco,
                    livro.Estoque,
                    livro.Descricao,
                    livro.Genero,
                    livro.Editora,
                    autores,
                    livro.Imagem
                );
                row.Cells[dataGridViewLivros.Columns["checkBoxColumn"].Index].Value = false;
                dataGridViewLivros.Rows.Add(row);
            }

            // Definindo as outras colunas como somente leitura
            foreach (DataGridViewColumn column in dataGridViewLivros.Columns)
            {
                if (column.Name != "quantidadeColumn" && column.Name != "checkBoxColumn")
                {
                    column.ReadOnly = true;
                }
            }
        }




        private void dataGridViewLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewLivros.Rows[e.RowIndex];
                string titulo = selectedRow.Cells["Titulo"].Value.ToString();
                string isbn = selectedRow.Cells["Isbn"].Value.ToString();
                string preco = selectedRow.Cells["Preco"].Value.ToString();
                string estoque = selectedRow.Cells["Estoque"].Value.ToString();
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

                DetalhesLivro detalhesForm = new DetalhesLivro(titulo, isbn, preco, estoque, descricao, genero, editora, autor, imagem);
                detalhesForm.ShowDialog();
            }

        }

        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            string filtroGenero = txtBuscarGenero.Text.ToLower(); // Valor digitado no campo de texto para o gênero, convertido para minúsculas
            FiltrarLivrosPorGenero(filtroGenero);
            txtBuscarGenero.Clear();
        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            string filtroNome = txtBuscarNome.Text.ToLower(); // Valor digitado no campo de texto para o nome, convertido para minúsculas
            FiltrarLivrosPorNome(filtroNome);
            txtBuscarNome.Clear();
        }


        private void FiltrarLivrosPorNome(string filtroNome)
        {
            // Percorrer as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewLivros.Rows)
            {
                string titulo = row.Cells["Titulo"].Value?.ToString()?.ToLower(); // Obtém o título convertido para minúsculas

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
                string genero = row.Cells["Genero"].Value?.ToString()?.ToLower(); // Obtém o gênero convertido para minúsculas

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
            this.Hide();
            formLoginUser.Show();


        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            // Obtem os itens selecionados no dataGridView
            List<ItemDeCompra> itensSelecionados = ObterItensDeCompraSelecionados();

            CarrinhoController carrinhoController = new CarrinhoController();
            Carrinho carrinho = carrinhoController.ObterCarrinho(clienteAtual.IdCliente);

            if (carrinho != null)
            {
                // O carrinho existe, pode prosseguir com a inserção dos itens de compra
                ItemDeCompraController itemDeCompraController = new ItemDeCompraController();
                itemDeCompraController.InserirOuAtualizarItensDeCompra(carrinho.Id, itensSelecionados);
                // Atualizar o dataGridViewLivros
                PreencherDataGrid();
                ConfigurarGrade();

                MessageBox.Show("Itens adicionados ao carrinho com sucesso.");
               
            }
            else
            {
                MessageBox.Show("Carrinho não encontrado.");
            }

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
            CarrinhoController carrinhoController = new CarrinhoController();
            Carrinho carrinho = carrinhoController.ObterCarrinho(clienteAtual.IdCliente);

            List<ItemDeCompra> itensSelecionados = new List<ItemDeCompra>();

            // Obtém todos os livros da base de dados usando o método GetAllLivros do LivroController
            LivroController livroController = new LivroController();
            IList<Livro> livros = livroController.GetAllLivros();

            foreach (DataGridViewRow row in dataGridViewLivros.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && checkBoxCell.Value != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    // Pega o id do livro selecionado
                    int livroId = Convert.ToInt32(row.Cells["Id"].Value);
                    int quantidade = Convert.ToInt32(row.Cells["quantidadeColumn"].Value);

                    // Encontra o livro correspondente na lista de livros pelo id
                    Livro livro = livros.FirstOrDefault(l => l.Id == livroId);

                    if (livro != null)
                    {
                        // Crie o objeto ItemDeCompra e atribua o ID do item de compra vindo do banco
                        ItemDeCompra item = new ItemDeCompra()
                        {
                            Livro = livro,
                            PrecoLivro = livro.Preco,
                            Quantidade = quantidade,
                        };

                        itensSelecionados.Add(item);
                    }
                }
                

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
            CarrinhoController carrinhoController = new CarrinhoController();
            Carrinho carrinho = carrinhoController.ObterCarrinho(cliente.IdCliente);

            if (carrinho != null)
            {
                FormCarrinho formCarrinho = new FormCarrinho(carrinho, cliente);
                formCarrinho.ShowDialog();
            }
            else
            {
                MessageBox.Show("O carrinho está vazio.");
            }

        }

        private void LivroForm_Activated(object sender, EventArgs e)
        {
            dataGridViewLivros.Refresh();
        }


        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            FormPerfilUsuario formPerfil = new FormPerfilUsuario(clienteAtual);
            formPerfil.ShowDialog();
        }

        private void btnAtualizarPágina_Click(object sender, EventArgs e)
        {
            PreencherDataGrid();
            ConfigurarGrade();
        }
    }
}




