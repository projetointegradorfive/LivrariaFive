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
using LivrariaFive.Model;
using LivrariaFive.Persistence;
using LivrariaFive.Controller;

namespace LivrariaFive.View
{
    public partial class FormRelatorioProdutos : Form
    {
        public FormRelatorioProdutos()
        {
            InitializeComponent();

        }
        private void FormRelatorioProdutos_Load(object sender, EventArgs e)
        {
            RelatorioDeProdutos();
            ConfigurarGrade();

        }

        public void ConfigurarGrade()
        {
            dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvProdutos.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvProdutos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar as colunas para mostrar todo o conteúdo
            dgvProdutos.AutoResizeColumns();
        }

        public void RelatorioDeProdutos(string nomeLivro = null, decimal? precoMin = null, decimal? precoMax = null)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GetRelatorioProdutos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adicione os parâmetros de filtro de nome do livro e faixa de preço
                    command.Parameters.AddWithValue("@nomeLivro", nomeLivro);
                    command.Parameters.AddWithValue("@precoMin", precoMin);
                    command.Parameters.AddWithValue("@precoMax", precoMax);

                    // Execute a leitura dos dados
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifique se há linhas retornadas
                        if (reader.HasRows)
                        {
                            // Limpe as colunas existentes no DataGridView
                            dgvProdutos.Columns.Clear();

                            // Adicione as colunas desejadas no DataGridView
                            dgvProdutos.Columns.Add("titulo", "Título");
                            dgvProdutos.Columns.Add("isbn", "ISBN");
                            dgvProdutos.Columns.Add("preco", "Preço");
                            dgvProdutos.Columns.Add("estoque", "Estoque");
                            dgvProdutos.Columns.Add("genero", "Gênero");
                            dgvProdutos.Columns.Add("editora", "Editora");
                            dgvProdutos.Columns["preco"].DefaultCellStyle.Format = "C2";

                            // Preencha as linhas do DataGridView com os dados retornados
                            while (reader.Read())
                            {
                                object[] rowData = new object[reader.FieldCount];
                                reader.GetValues(rowData);

                                dgvProdutos.Rows.Add(rowData);

                            }
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtenha os valores dos campos de texto
            string nomeLivro = txtNomeLivro.Text.Trim();
            decimal? precoMin = null;
            decimal? precoMax = null;

            // Verifique se os campos de preço estão preenchidos
            if (!string.IsNullOrEmpty(txtPrecoMin.Text))
            {
                precoMin = decimal.Parse(txtPrecoMin.Text);
            }

            if (!string.IsNullOrEmpty(txtPrecoMax.Text))
            {
                precoMax = decimal.Parse(txtPrecoMax.Text);
            }

            // Chame a função RelatorioDeProdutos passando os valores de nome do livro e faixa de preço
            RelatorioDeProdutos(nomeLivro, precoMin, precoMax);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
            admin.Show();
            this.Close();
        }


    }
}
