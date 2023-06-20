using LivrariaFive.Model;
using LivrariaFive.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaFive.View
{
    public partial class FormMeusPedidos : Form
    {
        private Cliente cliente;
        private DataTable dtPedidos;

        public FormMeusPedidos(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

        }
        private void FormMeusPedidos_Load(object sender, EventArgs e)
        {
            PreencherDados();
            ConfigurarGrade();
        }

        private void PreencherDados()
        {
            lblNomeUsuario.Text = cliente.Nome;

            // Criar uma instância do DataTable
            dtPedidos = new DataTable();

            // Adicionar colunas ao DataTable com os nomes para visualização do usuário
            dtPedidos.Columns.Add("ID do Pedido");
            dtPedidos.Columns.Add("Data do Pedido");
            dtPedidos.Columns.Add("Preço Total do Pedido");
            dtPedidos.Columns.Add("Forma de Pagamento");
            dtPedidos.Columns.Add("Status do Pedido");
            dtPedidos.Columns.Add("Nome do Livro");

            // Chamar a stored procedure e preencher o DataTable com os resultados
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("GetPedidosCliente", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ClienteID", cliente.IdCliente);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Obter a data do pedido e converter para a parte da data apenas
                    DateTime dataPedido = (DateTime)reader["DataPedido"];
                    string dataPedidoFormatada = dataPedido.ToShortDateString();

                    // Obter o preço total do pedido e formatar em reais
                    decimal precoTotal = Convert.ToDecimal(reader["PrecoTotalPedido"]);
                    string precoTotalFormatado = precoTotal.ToString("C2");

                    // Adicionar uma nova linha ao DataTable com os valores retornados
                    dtPedidos.Rows.Add(
                        reader["idPedido"],
                        dataPedidoFormatada,
                        precoTotalFormatado,
                        reader["FormaPagamento"],
                        reader["StatusPedido"],
                        reader["NomeLivro"]
                    );
                }

                connection.Close();
            }

            // Vincular o DataTable ao DataGridView
            dgvPedidos.DataSource = dtPedidos;

            // Alterar o cabeçalho das colunas do DataGridView para os nomes desejados
            dgvPedidos.Columns[0].HeaderText = "ID do Pedido";
            dgvPedidos.Columns[1].HeaderText = "Data do Pedido";
            dgvPedidos.Columns[2].HeaderText = "Preço Total do Pedido";
            dgvPedidos.Columns[3].HeaderText = "Forma de Pagamento";
            dgvPedidos.Columns[4].HeaderText = "Status do Pedido";
            dgvPedidos.Columns[5].HeaderText = "Nome do Livro";

        }


        public void ConfigurarGrade()
        {
            dgvPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvPedidos.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPedidos.Columns[0].Visible = false;



            // Ajustar as colunas para mostrar todo o conteúdo
            dgvPedidos.AutoResizeColumns();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPerfilUsuario perfilUsuario = new FormPerfilUsuario(cliente);
            this.Close();
        }
    }
}
