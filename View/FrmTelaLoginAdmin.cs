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
using System.IO;

namespace LivrariaFive.View
{
    public partial class FrmTelaLoginAdmin : Form
    {
        // Referência da conexão
        SqlConnection conexao = new SqlConnection(@"Data Source=IAN;Initial Catalog=Livraria;User ID=sa;Password=ianvictor123");

        public FrmTelaLoginAdmin()
        {
            InitializeComponent();
            txtCpfAdmin.Select();
        }

        public void verificar()
        {
            if (txtCpfAdmin.Text == "" && txtSenhaAdmin.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpfAdmin.Select();

            }
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            verificar();
            string query = "SELECT * FROM tbAdministrador WHERE cpf = '" + txtCpfAdmin.Text + "' AND senha = '" + txtSenhaAdmin.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            try
            {

                if (dt.Rows.Count == 1)
                {
                    FrmPrincipalAdmin principal = new FrmPrincipalAdmin();
                    this.Hide();
                    principal.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Usuário ou senha inválidos" + erro);
                txtCpfAdmin.Text = "";
                txtSenhaAdmin.Text = "";
                txtCpfAdmin.Select();
            }
            conexao.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
