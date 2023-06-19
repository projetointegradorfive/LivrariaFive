using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaFive.View
{
    public partial class FrmPrincipalAdmin : Form
    { 
        private FormRelatorioVendas formRelatorioVendas;
        public FrmPrincipalAdmin()
        {
            InitializeComponent();
            formRelatorioVendas = new FormRelatorioVendas();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmTelaLoginAdmin login = new FrmTelaLoginAdmin();
            this.Hide();
            login.Show();
        }

        private void btnGerenciarUsuarios_Click(object sender, EventArgs e)
        {
            FrmGerenciarUsuarios login = new FrmGerenciarUsuarios();          
            login.Show();
            this.Hide();
        }

        private void btnGerenciarLivros_Click(object sender, EventArgs e)
        {
            FrmGerenciarLivros login = new FrmGerenciarLivros();
            this.Hide();
            login.Show();
        }

        private void btnRelatórios_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRelatorioVendas.Show();

        }

        private void btnRelatorioClientes_Click(object sender, EventArgs e)
        {
            FormRelatorioClientes formRelatorioClientes = new FormRelatorioClientes();
            formRelatorioClientes.Show();
            this.Hide();
        }

        private void btnRelatorioEstoque_Click(object sender, EventArgs e)
        {
            FormRelatorioFaturamento formRelatorioFaturamento = new FormRelatorioFaturamento();
            formRelatorioFaturamento.Show();
            this.Hide();

        }

        private void btnRelatorioProdutos_Click(object sender, EventArgs e)
        {
            FormRelatorioProdutos formRelatorioProdutos = new FormRelatorioProdutos();
            formRelatorioProdutos.Show();
            this.Hide();

        }
    }
}
