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
    public partial class FormLoginUser : Form
    {
        public Cliente ClienteAtual { get; private set; }

        public FormLoginUser()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNomeCadastro.Text = string.Empty;
            txtEmailCadastro.Text = string.Empty;
            txtSenhaCadastro.Text = string.Empty;
            txtEnderecoCadastro.Text = string.Empty;
            maskTxtCpfCadastro.Text = string.Empty;
            maskTxtTelefoneCadastro.Text = string.Empty;
            // Limpar outros campos que você tenha no formulário
        }

        private void btnCadastrarUser_Click(object sender, EventArgs e)
        {
            // Obter os dados do formulário
            string nome = txtNomeCadastro.Text;
            string email = txtEmailCadastro.Text;
            string senha = txtSenhaCadastro.Text;
            string endereco = txtEnderecoCadastro.Text;
            string cpf = maskTxtCpfCadastro.Text;
            string telefone = maskTxtTelefoneCadastro.Text;
            DateTime dataNascimento = dtpDataNascimentoCadastro.Value;
            bool ativo = true;

            // Criar uma instância do ClienteController
            ClienteController clienteController = new ClienteController();

            // Criar uma instância do Cliente com os dados informados
            Cliente cliente = new Cliente
            {
                Nome = nome,
                Email = email,
                Senha = senha,
                Endereco = endereco,
                CPF = cpf,
                Telefone = telefone,
                DataNascimento = dataNascimento,
                Ativo = ativo
            };

            if (ValidaCadastroUser.ValidarCliente(cliente, out string mensagemErro))
            {
                // Todos os campos estão preenchidos corretamente
                // Prossiga com o cadastro do cliente

                try
                {
                    // Inserir o cliente no banco de dados
                    Cliente clienteInserido = clienteController.InserirCliente(cliente);

                    // Verifique se o cliente foi inserido com sucesso no banco de dados
                    if (clienteInserido != null)
                    {
                        // Cliente cadastrado com sucesso
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        // Ocorreu um erro ao cadastrar o cliente no banco de dados
                        MessageBox.Show("Erro ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro ao usuário
                    MessageBox.Show("Erro ao cadastrar o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exiba a mensagem de erro com os campos inválidos
                MessageBox.Show($"Os seguintes campos estão inválidos ou não foram preenchidos corretamente:\n\n{mensagemErro}", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogarUser_Click(object sender, EventArgs e)
        {
            // Obter os dados do formulário
            string email = txtEmail.Text;
            string senha = txtSenhaLogin.Text;

            // Verificar se o email e a senha estão em branco
            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, digite seu email e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se o email está em branco
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, digite seu email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se a senha está em branco
            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, digite sua senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClienteController clienteController = new ClienteController();
            Cliente cliente = clienteController.VerificarCredenciais(email, senha);
            CarrinhoController carrinhoController = new CarrinhoController();

            if (cliente != null)
            {
                // Verifica se a conta está ativa
                if (cliente.Ativo)
                {
                    // Definir o cliente atual
                    ClienteAtual = cliente;

                    // Exibir o formulário LivroForm e passar o cliente atual como argumento
                    LivroForm livroForm = new LivroForm(ClienteAtual);
                    livroForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Essa conta não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpar os campos do formulário
                txtEmail.Clear();
                txtSenhaLogin.Clear();
            }
        }


        private void btnLoginAdminRestrito_Click(object sender, EventArgs e)
        {
            FrmTelaLoginAdmin login = new FrmTelaLoginAdmin();
            this.Hide();
            login.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void verSenha_Click(object sender, EventArgs e)
        {
            if (txtSenhaLogin.UseSystemPasswordChar == true)
            {
                txtSenhaLogin.UseSystemPasswordChar = false;

            }
            else
            {
                txtSenhaLogin.UseSystemPasswordChar = true;
            }

        }
    }
}
