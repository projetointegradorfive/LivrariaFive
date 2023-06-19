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
    public partial class FormRelatorioClientes : Form
    {
        public FormRelatorioClientes()
        {
            InitializeComponent();
           
        }
        private void FormRelatorioClientes_Load(object sender, EventArgs e)
        {
            PreencherGridClientes();
            ConfigurarGrade();
        }
        public void ConfigurarGrade()
        {
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvClientes.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar as colunas para mostrar todo o conteúdo
            dgvClientes.AutoResizeColumns();
        }

        private void PreencherGridClientes(string filtroNome = null, int? filtroAnoNascimento = null)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_RelatorioClientes", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adicionar os parâmetros para os filtros
                    SqlParameter parametroNome = new SqlParameter("@filtroNome", filtroNome);
                    SqlParameter parametroAnoNascimento = new SqlParameter("@filtroAnoNascimento", filtroAnoNascimento);

                    // Verificar se os valores dos parâmetros são nulos e atribuir DBNull.Value se necessário
                    if (parametroNome.Value == null)
                        parametroNome.Value = DBNull.Value;
                    if (parametroAnoNascimento.Value == null)
                        parametroAnoNascimento.Value = DBNull.Value;

                    command.Parameters.Add(parametroNome);
                    command.Parameters.Add(parametroAnoNascimento);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvClientes.DataSource = dataTable;
                        dgvClientes.Columns["TotalCompras"].HeaderText = "Total Compras (R$)";
                        dgvClientes.Columns["TotalCompras"].DefaultCellStyle.Format = "C2";
                        dgvClientes.Columns["TotalCompras"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtroNome = txtNomeCliente.Text.ToLower(); // Valor digitado no campo de texto para o nome, convertido para minúsculas
            string filtroAnoNascimentoTexto = txtAnoNascimentoCliente.Text;
            int filtroAnoNascimento;

            // Verificar se o filtro de nome está preenchido
            if (!string.IsNullOrEmpty(filtroNome))
            {
                PreencherGridClientes(filtroNome, null); // Filtrar por nome
            }
            // Verificar se o filtro de ano de nascimento está preenchido e é um valor numérico válido
            else if (int.TryParse(filtroAnoNascimentoTexto, out filtroAnoNascimento))
            {
                PreencherGridClientes(null, filtroAnoNascimento); // Filtrar por ano de nascimento
            }
            else
            {
                // Caso nenhum filtro seja especificado, preencher a tabela sem filtro
                PreencherGridClientes(null, null);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
            admin.Show();
            this.Close();
        }

       
    }
}
