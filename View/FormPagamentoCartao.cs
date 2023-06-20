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
        private readonly Pedido pedido;
        private readonly CarrinhoController carrinhoController;
        private readonly Carrinho carrinho;
       
        public FormPagamentoCartao()
        {
            InitializeComponent();
            carrinhoController = new CarrinhoController();
        }

        public FormPagamentoCartao(Pedido pedido, Carrinho carrinho)
        {
            InitializeComponent();
            this.carrinho = carrinho;
            this.pedido = pedido;          
            carrinhoController = new CarrinhoController();
        }

        private void BtnFazerPagamento_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                NomeTitular = TxtNomeTitular.Text,
                NumeroCartao = MskNumCartao.Text,
                CodigoSeguranca = MskCvv.Text
            };

            bool formularioValido = ValidaFormPagamentoCartao.ValidarFormulario(cliente, MskValidade.Text, out string mensagemErro);

            if (formularioValido)
            {
                PedidoController pedidoController = new PedidoController(carrinho);
                pedido.Status = "Concluído";
                pedidoController.InserirPedido(pedido);
                carrinhoController.AtualizarPrecoTotalCarrinho(carrinho.Id);
                MessageBox.Show("Pedido Feito com Sucesso, logo será enviado!");
                this.Close();
            }
            else
            {
                MessageBox.Show(mensagemErro, "Erros de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtNomeTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
          
            this.Close();

        }
    }
}
