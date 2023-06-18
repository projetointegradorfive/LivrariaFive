using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaFive.Model
{
    public class Cliente
    {
        internal string ValidadeCartao;

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeTitular { get; internal set; }
        public string NumeroCartao { get; internal set; }
        public string CodigoSeguranca { get; internal set; }
        public bool Ativo { get; set; } = true;

    }
}
