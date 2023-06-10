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
        private CarrinhoController carrinhoController;
        private Carrinho carrinho;

        public FormPagamentoCartao(Pedido pedido, Carrinho carrinho)
        {
            InitializeComponent();
            this.carrinho = carrinho;
            this.pedido = pedido;
            carrinhoController = new CarrinhoController();
        }

        private void btnFazerPagamento_Click(object sender, EventArgs e)
        {
            PedidoController pedidoController = new PedidoController(carrinho);
            pedido.Status = "Concluído";
            pedidoController.InserirPedido(pedido);
            carrinhoController.AtualizarPrecoTotalCarrinho(carrinho.Id);
            MessageBox.Show("Pedido Feito com Sucesso, logo será enviado!");
            this.Close();
        }
    }
}
