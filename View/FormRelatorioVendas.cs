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
    public partial class FormRelatorioVendas : Form
    {
        public FormRelatorioVendas()
        {
            InitializeComponent();
        }
        private void FormRelatorioVendas_Load_1(object sender, EventArgs e)
        {
            RelatorioDeVendasGeral();
            ConfigurarGrade();
        }

        public void ConfigurarGrade()
        {
            dgvVendas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvVendas.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvVendas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar as colunas para mostrar todo o conteúdo
            dgvVendas.AutoResizeColumns();
        }

        public void RelatorioDeVendasGeral(int mes = 0, int ano = 0, string status = "")
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GetPedidosMirror", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adicione os parâmetros de filtro de mês, ano e status
                    command.Parameters.AddWithValue("@mes", mes);
                    command.Parameters.AddWithValue("@ano", ano);
                    command.Parameters.AddWithValue("@status", status);

                    // Execute a leitura dos dados
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifique se há linhas retornadas
                        if (reader.HasRows)
                        {
                            // Limpe as colunas existentes no DataGridView
                            dgvVendas.Columns.Clear();

                            // Adicione as colunas desejadas no DataGridView
                            dgvVendas.Columns.Add("idPedido", "ID Pedido");
                            dgvVendas.Columns.Add("data", "Data");
                            dgvVendas.Columns.Add("preco_total_pedido", "Preço Total");
                            dgvVendas.Columns.Add("forma_pagamento", "Forma de Pagamento");
                            dgvVendas.Columns.Add("status", "Status");
                            dgvVendas.Columns.Add("nome", "Cliente");
                            dgvVendas.Columns.Add("titulo", "Título");
                            dgvVendas.Columns["preco_total_pedido"].DefaultCellStyle.Format = "C2";

                            // Preencha as linhas do DataGridView com os dados retornados
                            while (reader.Read())
                            {
                                object[] rowData = new object[reader.FieldCount];
                                reader.GetValues(rowData);

                                // Obter a data do pedido e converter para a parte da data apenas
                                DateTime dataPedido = (DateTime)rowData[1];
                                string dataPedidoFormatada = dataPedido.ToShortDateString();
                                rowData[1] = dataPedidoFormatada;

                                dgvVendas.Rows.Add(rowData);
                                ConfigurarGrade();
                            }
                        }
                    }
                }
            }
        }

        private void btnItensMaisVendidos_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GetItensMaisVendidos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Execute a leitura dos dados
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifique se há linhas retornadas
                        if (reader.HasRows)
                        {
                            // Limpe as colunas existentes no DataGridView
                            dgvVendas.Columns.Clear();

                            // Adicione as colunas desejadas no DataGridView
                            dgvVendas.Columns.Add("idLivro", "ID Livro");
                            dgvVendas.Columns.Add("titulo", "Título");
                            dgvVendas.Columns.Add("total_vendas", "Total de Vendas");

                            // Preencha as linhas do DataGridView com os dados retornados
                            while (reader.Read())
                            {
                                object[] rowData = new object[reader.FieldCount];
                                reader.GetValues(rowData);
                                dgvVendas.Rows.Add(rowData);
                                ConfigurarGrade();
                            }
                        }
                    }
                }
            }
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            RelatorioDeVendasGeral();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtenha os valores dos campos de texto
            string txtAno = txtBuscarAno.Text.Trim();
            string txtMes = txtBuscarMes.Text.Trim();
            string status = txtStatusPedido.Text.Trim();

            // Inicialize as variáveis de filtro
            int ano = 0;
            int mes = 0;

            // Verifique se o campo de ano está preenchido
            if (!string.IsNullOrEmpty(txtAno))
            {
                int.TryParse(txtAno, out ano);
            }

            // Verifique se o campo de mês está preenchido
            if (!string.IsNullOrEmpty(txtMes))
            {
                int.TryParse(txtMes, out mes);
            }

            // Chame a função RelatorioDeVendasGeral passando os valores de ano, mês e status
            RelatorioDeVendasGeral(mes, ano, status);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin admin = new FrmPrincipalAdmin();
            admin.Show();
            this.Close();
        }
    }
}
