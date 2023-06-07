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

namespace LivrariaFive.View
{
    public partial class FrmGerenciarUsuarios : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=EMY;Initial Catalog=Livraria;Integrated Security=True");
        public FrmGerenciarUsuarios()
        {
            InitializeComponent();
        }
        public DataTable ObtertodosUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                conexao.Open();
                string query = "SELECT * FROM tbCliente order by tbCliente.nome ASC";
                SqlDataAdapter dp = new SqlDataAdapter(query, conexao);           
                dp.Fill(dt);                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao obter os usuários.");
            }
            finally
            {
                conexao.Close();
            }
            return dt;



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin login = new FrmPrincipalAdmin();
            this.Hide();
            login.Show();
        }

        private void FrmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = ObtertodosUsuarios();
            dgvUsuariosGerenciarUsuarios.DataSource = dt;
            dgvUsuariosGerenciarUsuarios.Refresh();
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
                
                txtDataNascimentoGerenciarUsuarios.Text = selectedRow.Cells["data_nascimento"].Value.ToString();
                
                maskTxtCpfGerenciarUsuarios.Text = selectedRow.Cells["cpf"].Value.ToString();
                
                txtNomeGerenciarUsuarios.Text = selectedRow.Cells["nome"].Value.ToString();
                
                txtEmailGerenciarUsuarios.Text = selectedRow.Cells["email"].Value.ToString();
            }
        }
    }
}
