using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LivrariaFive.Persistence;

namespace LivrariaFive.View
{
    public partial class FormRelatorioFaturamento : Form
    {
        public FormRelatorioFaturamento()
        {
            InitializeComponent();
            ConfigurarGrade();
            PreencherGridFaturamento();
        }

        private void ConfigurarGrade()
        {
            dgvFaturamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFaturamento.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvFaturamento.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvFaturamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ajustar as colunas para mostrar todo o conteúdo
            dgvFaturamento.AutoResizeColumns();
        }

        private void PreencherGridFaturamento(DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("RelatorioFaturamentoEntreDatas", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (dataInicial.HasValue)
                            command.Parameters.AddWithValue("@dataInicial", dataInicial.Value);
                        else
                            command.Parameters.AddWithValue("@dataInicial", DBNull.Value);

                        if (dataFinal.HasValue)
                            command.Parameters.AddWithValue("@dataFinal", dataFinal.Value);
                        else
                            command.Parameters.AddWithValue("@dataFinal", DBNull.Value);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);


                            // Verificar se a tabela possui registros
                            // Verificar se a tabela possui registros
                            if (dataTable.Rows.Count > 0)
                            {
                                // Obter o valor do faturamento total da primeira linha
                                decimal faturamentoTotal = Convert.ToDecimal(dataTable.Rows[0]["FaturamentoTotal"]);

                                // Remover a coluna "FaturamentoTotal" de todas as linhas, exceto da última
                                for (int i = 0; i < dataTable.Rows.Count; i++)
                                {
                                    dataTable.Rows[i].SetField("FaturamentoTotal", DBNull.Value);
                                }
                                DataRow totalRow = dataTable.NewRow();
                                totalRow["FaturamentoTotal"] = faturamentoTotal;
                                dataTable.Rows.Add(totalRow);

                                // Atualizar o valor do faturamento total apenas na última linha
                                dataTable.Rows[dataTable.Rows.Count - 1]["FaturamentoTotal"] = faturamentoTotal;
                            }



                            dgvFaturamento.DataSource = dataTable;
                            DefinicaoDeColunas();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefinicaoDeColunas()
        {
            dgvFaturamento.Columns["FaturamentoTotal"].HeaderText = "Faturamento Total (R$)";
            dgvFaturamento.Columns["FaturamentoTotal"].DefaultCellStyle.Format = "C2";
            dgvFaturamento.Columns["FaturamentoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFaturamento.Columns["TotalPedido"].HeaderText = "Total do Pedido (R$)";
            dgvFaturamento.Columns["TotalPedido"].DefaultCellStyle.Format = "C2";
            dgvFaturamento.Columns["TotalPedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFaturamento.Columns["FormaPagamento"].HeaderText = "Forma de Pagamento";
            dgvFaturamento.Columns["FormaPagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFaturamento.Columns["DataPedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFaturamento.Columns["DataPedido"].HeaderText = "Data do Pedido";

            dgvFaturamento.Columns["Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFaturamento.Columns["Cliente"].HeaderText = "Nome do Cliente";
        }

        private void FormRelatorioFaturamento_Load(object sender, EventArgs e)
        {
            // Neste momento, você pode chamar o método PreencherGridFaturamento sem passar nenhum parâmetro para exibir todos os registros
            PreencherGridFaturamento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime? dataInicial = dtpDataInicial.Value;
            DateTime? dataFinal = dtpDataFinal.Value;

            if (dataInicial != null && dataFinal != null)
            {
                PreencherGridFaturamento(dataInicial, dataFinal);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data inicial e uma data final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
