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
                            dgvVendas.Columns.Add("idCliente", "ID Cliente");
                            dgvVendas.Columns.Add("nome", "Nome");
                            dgvVendas.Columns.Add("email", "Email");
                            dgvVendas.Columns.Add("cpf", "CPF");
                            dgvVendas.Columns.Add("endereco", "Endereço");
                            dgvVendas.Columns.Add("telefone", "Telefone");
                            dgvVendas.Columns.Add("data_nascimento", "Data de Nascimento");
                            dgvVendas.Columns.Add("idItemCompra", "ID Item de Compra");
                            dgvVendas.Columns.Add("quantidade", "Quantidade");
                            dgvVendas.Columns.Add("preco_unitario", "Preço Unitário");
                            dgvVendas.Columns.Add("preco_total_itemDeCompra", "Preço Total Item");
                            dgvVendas.Columns.Add("idLivro", "ID Livro");
                            dgvVendas.Columns.Add("titulo", "Título");

                            // Preencha as linhas do DataGridView com os dados retornados
                            while (reader.Read())
                            {
                                object[] rowData = new object[reader.FieldCount];
                                reader.GetValues(rowData);
                                dgvVendas.Rows.Add(rowData);
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
            // Obtenha o valor do campo txtBuscarAno
            string txtAno = txtBuscarAno.Text.Trim();
            int ano;

            // Verifique se o campo txtBuscarAno contém um valor válido
            if (int.TryParse(txtAno, out ano))
            {
                // Obtenha o valor do campo txtBuscarMes
                string txtMes = txtBuscarMes.Text.Trim();
                int mes;

                // Verifique se o campo txtBuscarMes contém um valor válido
                if (int.TryParse(txtMes, out mes))
                {
                    // Obtenha o valor do status do pedido
                    string status = txtStatusPedido.Text.Trim();

                    // Chame a função RelatorioDeVendasGeral passando os valores de ano, mês e status
                    RelatorioDeVendasGeral(mes, ano, status);
                }
                else
                {
                    // Obtenha o valor do status do pedido
                    string status = txtStatusPedido.Text.Trim();

                    // Chame a função RelatorioDeVendasGeral passando o valor de ano e status
                    RelatorioDeVendasGeral(0, ano, status);
                }
            }
            else
            {
                // Obtenha o valor do status do pedido
                string status = txtStatusPedido.Text.Trim();

                // Chame a função RelatorioDeVendasGeral passando o valor de status
                RelatorioDeVendasGeral(0, 0, status);
            }
        }






    }
}
