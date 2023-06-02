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
        //SqlConnection conexao = new SqlConnection("Data Source = LABINFO - 9DC9A7\\SQLEXPRESS; Initial Catalog = Livraria; Integrated Security = True");
        SqlConnection conexao = new SqlConnection(@"Data Source=IAN;Initial Catalog=Livraria;User ID=sa;Password=ianvictor123");

        public FrmTelaLoginAdmin()
        {
            InitializeComponent();
            maskTxtCpfAdmin.Select();
        }

        public void verificar()
        {
            if (maskTxtCpfAdmin.Text == "" && txtSenhaAdmin.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskTxtCpfAdmin.Select();

            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            conexao.Open();
            verificar();
            string query = "SELECT * FROM tbAdministrador WHERE cpf = '"
                + maskTxtCpfAdmin.Text 
                + "' AND senha = '" + txtSenhaAdmin.Text + "'";
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
                maskTxtCpfAdmin.Text = "";
                txtSenhaAdmin.Text = "";
                maskTxtCpfAdmin.Select();
            }
            conexao.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLoginUser login = new FormLoginUser();
            this.Hide();
            login.Show();

        }
    }
}
