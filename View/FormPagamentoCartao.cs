using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaFive.Controller;
using LivrariaFive.Model;

namespace LivrariaFive.View
{
    public partial class FormPagamentoCartao : Form
    {
        private Pedido pedido;

        public FormPagamentoCartao(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
        }

        private void btnFazerPagamento_Click(object sender, EventArgs e)
        {
            PedidoController pedidoController = new PedidoController();
            pedidoController.InserirPedido(pedido);
            MessageBox.Show("Pedido Feito com Sucesso, logo será enviado!");
            this.Close();
        }
    }
}
