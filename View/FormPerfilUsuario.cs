using LivrariaFive.Controller;
using LivrariaFive.Model;
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
    public partial class FormPerfilUsuario : Form
    {
        private Cliente cliente;
        public FormPerfilUsuario(Cliente cliente)
        {

            InitializeComponent();
            this.cliente = cliente;
            
        }
        private void FormPerfilUsuario_Load(object sender, EventArgs e)
        {
            DadosDoUsuario();
        }

        public void DadosDoUsuario()
        {
            lblNomeUsuario.Text = cliente.Nome;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            txtEndereco.Text = cliente.Endereco;
            txtSenha.Text = cliente.Senha;
            maskTxtCpf.Text = cliente.CPF;
            maskTxtDataNascimento.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
            maskTxtTelefone.Text = cliente.Telefone;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Atualizar os dados do cliente com base nos valores dos campos de texto
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Senha = txtSenha.Text;
                cliente.CPF = maskTxtCpf.Text;
                cliente.DataNascimento = DateTime.ParseExact(maskTxtDataNascimento.Text, "dd/MM/yyyy", null);
                cliente.Telefone = maskTxtTelefone.Text;

                // Chamar o método AtualizarCliente no ClienteController
                ClienteController clienteController = new ClienteController();
                clienteController.AtualizarCliente(cliente);

                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados: " + ex.Message);
            }
        }

        private void btnMeusPedidos_Click(object sender, EventArgs e)
        {
            FormMeusPedidos formMeusPedidos = new FormMeusPedidos(cliente);
            formMeusPedidos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
