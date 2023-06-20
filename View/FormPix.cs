using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaFive.Model;
using LivrariaFive.Controller;

namespace LivrariaFive.View
{

    public partial class FormPix : Form
    {
        private Pedido pedido;
        private Carrinho carrinho;
        private CarrinhoController carrinhoController;

        public FormPix(Pedido pedido, Carrinho carrinho)
        {
            InitializeComponent();
            this.pedido = pedido;
            this.carrinho = carrinho;
            carrinhoController = new CarrinhoController();
        }

        private void btnPagamentoRealizado_Click(object sender, EventArgs e)
        {
            PedidoController pedidoController = new PedidoController(carrinho);
            pedido.FormaPagamento = "Pix";
            pedido.Status = "Concluído";
            pedidoController.InserirPedido(pedido);
            carrinhoController.AtualizarPrecoTotalCarrinho(carrinho.Id);
            MessageBox.Show("O pagamento será verificado e logo seu pedido será enviado!");         
            this.Close();
           
        }

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
