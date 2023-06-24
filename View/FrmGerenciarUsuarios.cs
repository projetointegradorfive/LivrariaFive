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
using LivrariaFive.Persistence;
using LivrariaFive.Controller;
using LivrariaFive.Model;

namespace LivrariaFive.View
{
    public partial class FrmGerenciarUsuarios : Form
    {
        Cliente clienteSelecionado = new Cliente();

        //SqlConnection connection = new SqlConnection(@"Data Source=IAN;Initial Catalog=Livraria;Integrated Security=True");
        SqlConnection connection = DatabaseConnection.GetConnection();

        public FrmGerenciarUsuarios()
        {
            InitializeComponent();
        }

        private void LimparTextBoxes()
        {
            txtIdGerenciarUsuarios.Text = "";
            txtNomeGerenciarUsuarios.Text = "";
            txtEmailGerenciarUsuarios.Text = "";
            txtSenhaGerenciarUsuarios.Text = "";
            maskTxtCpfGerenciarUsuarios.Text = "";
            txtEnderecoGerenciarUsuarios.Text = "";
            maskTxtTelefoneGerenciarUsuarios.Text = "";
            maskTxtDataNascimentoGerenciarUsuarios.Text = "";
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin login = new FrmPrincipalAdmin();
            this.Hide();
            login.Show();
        }

        private void FrmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            ClienteController metodoObter = new ClienteController();
            DataTable dt = metodoObter.ObtertodosUsuarios();
            dgvUsuariosGerenciarUsuarios.DataSource = dt;
            dgvUsuariosGerenciarUsuarios.Refresh();
            ConfigurarGrade();
        }

        private void dgvUsuariosGerenciarUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuariosGerenciarUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUsuariosGerenciarUsuarios.SelectedRows[0];

                txtIdGerenciarUsuarios.Text = selectedRow.Cells["idCliente"].Value.ToString();
                
                txtEnderecoGerenciarUsuarios.Text = selectedRow.Cells["endereco"].Value.ToString();
                
                txtSenhaGerenciarUsuarios.Text = selectedRow.Cells["senha"].Value.ToString();
                
                maskTxtTelefoneGerenciarUsuarios.Text = selectedRow.Cells["telefone"].Value.ToString();
                
                maskTxtDataNascimentoGerenciarUsuarios.Text = selectedRow.Cells["data_nascimento"].Value.ToString().Substring(0,10);
                
                maskTxtCpfGerenciarUsuarios.Text = selectedRow.Cells["cpf"].Value.ToString();
                
                txtNomeGerenciarUsuarios.Text = selectedRow.Cells["nome"].Value.ToString();
                
                txtEmailGerenciarUsuarios.Text = selectedRow.Cells["email"].Value.ToString();
            }
        }

        private void btnNovoUsuarioGerenciarUsuarios_Click(object sender, EventArgs e)
        {
            ClienteController metodoObter = new ClienteController();

            Cliente novoCliente = new Cliente();
            
            novoCliente.Nome = txtNomeGerenciarUsuarios.Text;
            novoCliente.Email = txtEmailGerenciarUsuarios.Text;
            novoCliente.Senha = txtSenhaGerenciarUsuarios.Text;
            novoCliente.CPF = maskTxtCpfGerenciarUsuarios.Text;
            novoCliente.Endereco = txtEnderecoGerenciarUsuarios.Text;
            novoCliente.Telefone = maskTxtTelefoneGerenciarUsuarios.Text;

            DateTime dataNascimento;
            if (DateTime.TryParse(maskTxtDataNascimentoGerenciarUsuarios.Text, out dataNascimento))
            {
                novoCliente.DataNascimento = dataNascimento;

                ClienteController clienteController = new ClienteController();
                Cliente clienteInserido = clienteController.InserirCliente(novoCliente);

                if (clienteInserido != null)
                {
                    MessageBox.Show("Novo Usuário Inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTextBoxes();
                    dgvUsuariosGerenciarUsuarios.DataSource =  metodoObter.ObtertodosUsuarios();
                }
                else
                {
                    MessageBox.Show("Erro ao Inserir o Usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarAlteracoesGerenciarUsuarios_Click(object sender, EventArgs e)
        {
            ClienteController metodoObter = new ClienteController();
            
            if (clienteSelecionado != null)
                {
                    // Atualizar as informações do cliente com base nas TextBox
                    clienteSelecionado.Nome = txtNomeGerenciarUsuarios.Text;
                    clienteSelecionado.Email = txtEmailGerenciarUsuarios.Text;
                    clienteSelecionado.Senha = txtSenhaGerenciarUsuarios.Text;
                    clienteSelecionado.CPF = maskTxtCpfGerenciarUsuarios.Text;
                    clienteSelecionado.Endereco = txtEnderecoGerenciarUsuarios.Text;
                    clienteSelecionado.Telefone = maskTxtTelefoneGerenciarUsuarios.Text;
                    clienteSelecionado.DataNascimento = DateTime.Parse(maskTxtDataNascimentoGerenciarUsuarios.Text);

                    ClienteController clienteController1 = new ClienteController();
                    Cliente clienteAtualizado = clienteController1.AtualizarCliente(clienteSelecionado);

                    if (clienteAtualizado != null)
                    {
                    MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuariosGerenciarUsuarios.DataSource = metodoObter.ObtertodosUsuarios();
                    LimparTextBoxes();
                    }
                    else
                    {
                    MessageBox.Show("Erro ao salvar as alterações do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
                else
                {
                    MessageBox.Show("Nenhum cliente selecionado para editar.");
                }
        }

        private void btnExcluirUsuarioGerenciarUsuarios_Click(object sender, EventArgs e)
        {
            ClienteController metodoObter = new ClienteController();

            if (clienteSelecionado != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ClienteController clienteController = new ClienteController();
                    clienteController.RemoverCliente(clienteSelecionado.IdCliente);

                    LimparTextBoxes();
                    dgvUsuariosGerenciarUsuarios.DataSource = metodoObter.ObtertodosUsuarios();

                    MessageBox.Show("Cliente excluído com sucesso!");
                }

            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado para excluir.");
            }
            
        }
        private void ConfigurarGrade()
        {
            dgvUsuariosGerenciarUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvUsuariosGerenciarUsuarios.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvUsuariosGerenciarUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvUsuariosGerenciarUsuarios.Columns["idCliente"].Visible = false; // Ocultar a coluna "idCliente"

            dgvUsuariosGerenciarUsuarios.Columns["Nome"].Width = 200;
            dgvUsuariosGerenciarUsuarios.Columns["Email"].Width = 200;
            dgvUsuariosGerenciarUsuarios.Columns["Senha"].Visible = false; // Ocultar a coluna "Senha"
            dgvUsuariosGerenciarUsuarios.Columns["CPF"].Width = 150;
            dgvUsuariosGerenciarUsuarios.Columns["Endereco"].Width = 200;
            dgvUsuariosGerenciarUsuarios.Columns["Telefone"].Width = 150;
            dgvUsuariosGerenciarUsuarios.Columns["data_nascimento"].HeaderText = "Data de Nascimento";
            dgvUsuariosGerenciarUsuarios.Columns["data_nascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvUsuariosGerenciarUsuarios.Columns["data_nascimento"].Width = 150;

            // Ajustar o preenchimento das células para alinhar ao centro
            foreach (DataGridViewColumn column in dgvUsuariosGerenciarUsuarios.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        private void dgvUsuariosGerenciarUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuariosGerenciarUsuarios.Rows[e.RowIndex];

                // Atribuir o cliente selecionado com base na linha clicada do DataGridView
                clienteSelecionado = new Cliente
                {
                    IdCliente = Convert.ToInt32(row.Cells["IdCliente"].Value),
                    Nome = row.Cells["Nome"].Value.ToString(),
                    Email = row.Cells["Email"].Value.ToString(),
                    Senha = row.Cells["Senha"].Value.ToString(),
                    CPF = row.Cells["CPF"].Value.ToString(),
                    Endereco = row.Cells["Endereco"].Value.ToString(),
                    Telefone = row.Cells["Telefone"].Value.ToString(),
                    DataNascimento = Convert.ToDateTime(row.Cells["data_nascimento"].Value)
                };

                // Preencher as TextBox com as informações do cliente selecionado
                txtNomeGerenciarUsuarios.Text = clienteSelecionado.Nome;
                txtEmailGerenciarUsuarios.Text = clienteSelecionado.Email;
                txtSenhaGerenciarUsuarios.Text = clienteSelecionado.Senha;
                maskTxtCpfGerenciarUsuarios.Text = clienteSelecionado.CPF;
                txtEnderecoGerenciarUsuarios.Text = clienteSelecionado.Endereco;
                maskTxtTelefoneGerenciarUsuarios.Text = clienteSelecionado.Telefone;
                maskTxtDataNascimentoGerenciarUsuarios.Text = clienteSelecionado.DataNascimento.ToString().Substring(0,10);
            }
            

        }

        private void btnLimparTextBox_Click(object sender, EventArgs e)
        {
            LimparTextBoxes();
        }

        private void txtPesquisaUsuarios_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisaUsuarios.Text.Trim();

            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbCliente WHERE nome LIKE @pesquisa OR cpf LIKE @pesquisa ORDER BY nome ASC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                SqlDataAdapter dp = new SqlDataAdapter(command);
                dp.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao obter os usuários." + ex);
            }
            finally
            {
                connection.Close();
            }

            dgvUsuariosGerenciarUsuarios.DataSource = dt;
            dgvUsuariosGerenciarUsuarios.Refresh();

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtivarConta_Click(object sender, EventArgs e)
        {
            ClienteController ativa = new ClienteController();
            
            if (clienteSelecionado != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja ativar o cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ClienteController clienteController = new ClienteController();

                    ativa.AtivarContaDoCliente(clienteSelecionado.IdCliente);

                    LimparTextBoxes();
                    dgvUsuariosGerenciarUsuarios.DataSource = ativa.ObtertodosUsuarios();

                    MessageBox.Show("Cliente ativado com sucesso!");
                }

            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado para ativar.");
            }
        }
    }
}
