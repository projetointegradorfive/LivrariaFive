using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LivrariaFive.Controller;
using LivrariaFive.Model;
using ZXing;
using ZXing.Common;








namespace LivrariaFive.View
{
    public partial class FormBoleto : Form
    {
        private Pedido pedido;
        private CarrinhoController carrinhoController;
        private ClienteController clienteController;
        private Carrinho carrinho;
        private Cliente cliente;
        

        public FormBoleto(Pedido pedido, Carrinho carrinho, Cliente cliente)
        {
            InitializeComponent();
            clienteController = new ClienteController();
            this.pedido = pedido;
            this.carrinho = carrinho;
            this.cliente = cliente;          
           carrinhoController = new CarrinhoController();


        }

        private void btnGerarBoleto_Click(object sender, EventArgs e)
        {
            try
            {
                // Crie um novo documento PDF
                Document doc = new Document();

                // Defina o caminho onde o boleto será salvo
                string caminhoBoleto = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "boleto.pdf");

                // Crie um escritor PDF para gravar o conteúdo do documento no arquivo
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminhoBoleto, FileMode.Create));

                // Abra o documento
                doc.Open();
              

               // obter o cliente por nome e CPF
               
                    // Exemplo: Adicione as informações do cliente ao boleto
                    Paragraph nomeClienteParagraph = new Paragraph("Nome do Cliente: " + cliente.Nome);
                    doc.Add(nomeClienteParagraph);

                    Paragraph cpfClienteParagraph = new Paragraph("CPF do Cliente: " + cliente.CPF);
                    doc.Add(cpfClienteParagraph);

                    Paragraph enderecoClienteParagraph = new Paragraph("Endereço do Cliente: " + cliente.Endereco);
                    doc.Add(enderecoClienteParagraph);

                    // Exemplo: Adicione o valor do boleto
                    double valorBoleto = pedido.PrecoTotalPedido;
                    Paragraph valorBoletoParagraph = new Paragraph("Valor do boleto: " + valorBoleto.ToString("C"));
                    doc.Add(valorBoletoParagraph);

                // Gere o código de barras usando o valor do boleto
               
                BarcodeInter25 code25 = new BarcodeInter25();
                code25.Code = valorBoleto.ToString("F2").Replace(",", "").PadLeft(14, '0');
                code25.ChecksumText = true;
                iTextSharp.text.Image image = code25.CreateImageWithBarcode(writer.DirectContent, null, null);
                doc.Add(image);

                // Feche o documento
                doc.Close();

                // Exiba uma mensagem de sucesso para o usuário
                MessageBox.Show("Boleto gerado com sucesso!");
                PedidoController pedidoController = new PedidoController(carrinho);
                pedido.FormaPagamento = "Boleto";
                pedido.Status = "Pendente de Análise";
                pedidoController.InserirPedido(pedido);
                carrinhoController.AtualizarPrecoTotalCarrinho(carrinho.Id);
                MessageBox.Show("O pagamento será verificado e logo seu pedido será enviado!");

                // Abra o arquivo PDF para download
                System.Diagnostics.Process.Start(caminhoBoleto);
                
                this.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o boleto: " + ex.Message);
            }
        }

        private void FormBoleto_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Close();
        }
    }
}
