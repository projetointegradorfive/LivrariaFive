using LivrariaFive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LivrariaFive.Controller;

namespace LivrariaFive
{
    public static class ValidaCadastroUser
    {
        public static bool ValidarCliente(Cliente cliente, out string mensagemErro)
        {
            mensagemErro = "";

            if (!ValidarNome(cliente.Nome, out string nomeErro))
                mensagemErro += $"- Nome: {nomeErro}\n";

            if (!ValidarEmail(cliente.Email, out string emailErro))
                mensagemErro += $"- Email: {emailErro}\n";

            if (!ValidarSenha(cliente.Senha, out string senhaErro))
                mensagemErro += $"- Senha: {senhaErro}\n";

            if (!ValidarEndereco(cliente.Endereco, out string enderecoErro))
                mensagemErro += $"- Endereço: {enderecoErro}\n";

            if (!ValidarCPF(cliente.CPF, out string cpfErro))
                mensagemErro += $"- CPF: {cpfErro}\n";

            if (!ValidarTelefone(cliente.Telefone, out string telefoneErro))
                mensagemErro += $"- Telefone: {telefoneErro}\n";

            if (mensagemErro.Length > 0)
                return false;

            // Outras validações personalizadas aqui, se necessário

            return true;
        }

        private static bool ValidarNome(string nome, out string mensagemErro)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagemErro = "O nome é obrigatório.";
                return false;
            }

            if (nome.Length < 3)
            {
                mensagemErro = "O nome deve ter no mínimo 3 caracteres.";
                return false;
            }

            // Verificar se o nome contém apenas letras e espaços
            bool nomeValido = Regex.IsMatch(nome, @"^[a-zA-Z\s]+$");

            if (!nomeValido)
            {
                mensagemErro = "O nome contém caracteres inválidos.";
                return false;
            }

            mensagemErro = "";
            return true;
        }

        private static bool ValidarEmail(string email, out string mensagemErro)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                mensagemErro = "O email é obrigatório.";
                return false;
            }

            // Verificar se o email tem um formato válido
            bool emailValido = Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");

            if (!emailValido)
            {
                mensagemErro = "O email não está em um formato válido.";
                return false;
            }

            ClienteController clienteController = new ClienteController();
            if (clienteController.VerificarEmailExistente(email))
            {
                mensagemErro = "O email informado já está cadastrado.";
                return false;
            }

            mensagemErro = "";
            return true;
        }

        private static bool ValidarSenha(string senha, out string mensagemErro)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                mensagemErro = "A senha é obrigatória.";
                return false;
            }

            // Verificar se a senha atende aos critérios de validação desejados
            // Por exemplo, verificar se tem pelo menos 8 caracteres, contém letras maiúsculas e minúsculas, e números

            if (senha.Length < 8)
            {
                mensagemErro = "A senha deve ter pelo menos 8 caracteres.";
                return false;
            }

            if (!senha.Any(char.IsUpper))
            {
                mensagemErro = "A senha deve conter pelo menos uma letra maiúscula.";
                return false;
            }

            if (!senha.Any(char.IsLower))
            {
                mensagemErro = "A senha deve conter pelo menos uma letra minúscula.";
                return false;
            }

            if (!senha.Any(char.IsDigit))
            {
                mensagemErro = "A senha deve conter pelo menos um número.";
                return false;
            }

            if (senha.Contains(" "))
            {
                mensagemErro = "A senha não pode conter espaços em branco.";
                return false;
            }
            mensagemErro = "";
            return true;
        }
        private static bool ValidarEndereco(string endereco, out string mensagemErro)
        {
            if (string.IsNullOrWhiteSpace(endereco))
            {
                mensagemErro = "O endereço é obrigatório.";
                return false;
            }

            // Verificar o comprimento mínimo do endereço
            if (endereco.Length < 10)
            {
                mensagemErro = "O endereço deve ter no mínimo 10 caracteres.";
                return false;
            }

            // Verificar se o endereço contém caracteres inválidos
            if (!Regex.IsMatch(endereco, @"^[a-zA-Z0-9\s.,-]+$"))
            {
                mensagemErro = "O endereço contém caracteres inválidos.";
                return false;
            }

            mensagemErro = "";
            return true;
        }
        private static bool ValidarCPF(string cpf, out string mensagemErro)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                mensagemErro = "O CPF é obrigatório.";
                return false;
            }

            // Remover caracteres especiais do CPF (pontuação, traços, etc.)
            cpf = Regex.Replace(cpf, @"[^0-9]", "");

            if (cpf.Length != 11)
            {
                mensagemErro = "O CPF deve ter 11 dígitos.";
                return false;
            }

            // Verificar se todos os dígitos do CPF são iguais
            if (cpf.Distinct().Count() == 1)
            {
                mensagemErro = "O CPF informado é inválido.";
                return false;
            }

            // Calcular os dígitos verificadores do CPF
            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cpfSemDigitos = cpf.Substring(0, 9);
            string cpfComDigitos = cpf.Substring(0, 9) + cpf.Substring(9, 2);

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpfSemDigitos[i].ToString()) * multiplicadores1[i];
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            cpfSemDigitos += digito1;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpfComDigitos[i].ToString()) * multiplicadores2[i];
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            cpfSemDigitos += digito2;

            // Verificar se o CPF com os dígitos verificadores é igual ao CPF informado
            if (cpfComDigitos != cpfSemDigitos)
            {
                mensagemErro = "O CPF informado é inválido.";
                return false;
            }

            mensagemErro = "";
            return true;
        }
        private static bool ValidarTelefone(string telefone, out string mensagemErro)
{
    if (string.IsNullOrWhiteSpace(telefone))
    {
        mensagemErro = "O telefone é obrigatório.";
        return false;
    }

    // Verificar se o telefone possui uma quantidade mínima de dígitos
    if (telefone.Length != 11)
    {
        mensagemErro = "O telefone deve ter 11 dígitos.";
        return false;
    }

    // Verificar se o telefone começa com o DDD válido para o Brasil
    string ddd = telefone.Substring(0, 2);
    if (!ValidarDDD(ddd))
    {
        mensagemErro = "O telefone não está em um formato válido. O DDD não é válido para o Brasil.";
        return false;
    }

    // Verificar se o telefone contém apenas dígitos
    if (!telefone.All(char.IsDigit))
    {
        mensagemErro = "O telefone não está em um formato válido. Deve conter apenas dígitos.";
        return false;
    }

    mensagemErro = "";
    return true;
}

private static bool ValidarDDD(string ddd)
{
    // Lista dos DDDs válidos para o Brasil
    string[] dddsValidos = { "11", "12", "13", "14", "15", "16", "17", "18", "19", "21", "22", "24", "27", "28", "31", "32", "33", "34", "35", "37", "38", "41", "42", "43", "44", "45", "46", "47", "48", "49", "51", "53", "54", "55", "61", "62", "63", "64", "65", "66", "67", "68", "69", "71", "73", "74", "75", "77", "79", "81", "82", "83", "84", "85", "86", "87", "88", "89", "91", "92", "93", "94", "95", "96", "97", "98", "99" };

    return dddsValidos.Contains(ddd);
}
    }
}

