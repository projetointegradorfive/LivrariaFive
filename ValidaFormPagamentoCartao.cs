using LivrariaFive.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaFive
{
    public class ValidaFormPagamentoCartao
    {
        public static bool ValidarFormulario(Cliente cliente, string dataValidade, out string mensagemErro)
        {
            mensagemErro = "";

            if (!ValidarNomeTitular(cliente.NomeTitular, out string nomeTitularErro))
                mensagemErro += $"- Nome do Titular: {nomeTitularErro}\n";

            if (!ValidarNumeroCartao(cliente.NumeroCartao, out string numeroCartaoErro))
                mensagemErro += $"- Número do Cartão: {numeroCartaoErro}\n";

            if (!ValidarDataValidade(dataValidade, out string dataValidadeErro))
                mensagemErro += $"- Data de Validade: {dataValidadeErro}\n";

            if (!ValidarCodigoSeguranca(cliente.CodigoSeguranca, out string codigoSegurancaErro))
                mensagemErro += $"- CVV: {codigoSegurancaErro}\n";
         

            if (mensagemErro.Length > 0)
                return false;

            // Outras validações personalizadas aqui, se necessário

            return true;
        }


        public static bool ValidarNomeTitular(string nomeTitular, out string mensagemErro)
        {
            // Verificar se o campo está em branco
            if (string.IsNullOrWhiteSpace(nomeTitular))
            {
                mensagemErro = "Não pode estar em branco.";
                return false;
            }

            // Verificar o número mínimo de dígitos
            int minimoDigitos = 6; // Definir o número mínimo de dígitos desejado

            if (nomeTitular.Length < minimoDigitos)
            {
                mensagemErro = $"Deve ter pelo menos {minimoDigitos} caracteres.";
                return false;
            }

            // O campo passou na validação
            mensagemErro = string.Empty;
            return true;
        }

        public static bool ValidarNumeroCartao(string numeroCartao, out string mensagemErro)
        {
            // Verificar se o campo está em branco
            if (string.IsNullOrWhiteSpace(numeroCartao))
            {
                mensagemErro = "Não pode estar em branco.";
                return false;
            }

            // Verificar o número mínimo de dígitos
            int minimoDigitos = 16; // Definir o número mínimo de dígitos desejado

            if (numeroCartao.Length < minimoDigitos)
            {
                mensagemErro = $"Deve ter pelo menos {minimoDigitos} dígitos.";
                return false;
            }

            // O campo passou na validação
            mensagemErro = string.Empty;
            return true;
        }

        public static bool ValidarDataValidade(string dataValidade, out string mensagemErro)
        {

            if (string.IsNullOrWhiteSpace(dataValidade))
            {
                mensagemErro = "Não pode estar em branco.";
                return false;
            }

            // Remover os caracteres não numéricos
            string dataNumerica = new string(dataValidade.Where(char.IsDigit).ToArray());

            // Verificar se tem pelo menos 4 dígitos
            if (dataNumerica.Length < 4)
            {
                mensagemErro = "Deve ter pelo menos 4 dígitos.";
                return false;
            }

            // Verificar os dois últimos dígitos
            string anoString = dataNumerica.Substring(dataNumerica.Length - 2);
            if (int.TryParse(anoString, out int ano) && ano < 23)
            {
                mensagemErro = "Cartão vencido.";
                return false;
            }

            // O campo passou na validação
            mensagemErro = string.Empty;
            return true;
        }
        public static bool ValidarCodigoSeguranca(string codigoSeguranca, out string mensagemErro)
        {
            if (string.IsNullOrWhiteSpace(codigoSeguranca))
            {
                mensagemErro = "Não pode estar em branco.";
                return false;
            }

            if (codigoSeguranca.Length < 3)
            {
                mensagemErro = $"Deve ter pelo menos {3} dígitos.";
                return false;
            }

            // Aqui você pode adicionar outras validações específicas para o código de segurança, se necessário

            mensagemErro = string.Empty;
            return true;
        }


    }
}