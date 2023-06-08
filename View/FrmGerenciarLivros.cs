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
using LivrariaFive.Controller;
using LivrariaFive.Model;

namespace LivrariaFive.View
{
    public partial class FrmGerenciarLivros : Form
    {
        public FrmGerenciarLivros()
        {
            InitializeComponent();
        }
        

        private void btnCadastrarLivroGerenciarLivros_Click(object sender, EventArgs e)
        {
            FormCadastrarLivro cadastrarLivro = new FormCadastrarLivro();
            this.Hide();
            cadastrarLivro.Show();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin volta = new FrmPrincipalAdmin();
            this.Hide();
            volta.Show();
        }

        private void FrmGerenciarLivros_Load(object sender, EventArgs e)
        {
            LivroController livros = new LivroController();
            DataTable dt = livros.ObtertodosLivrosGerenciarLivros();
            dgvMostrarLivros.DataSource = dt;
            dgvMostrarLivros.Refresh();
        }
    }
}
