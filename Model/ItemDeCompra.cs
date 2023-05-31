using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaFive.Model
{
    public class ItemDeCompra
    {
        public int IdItemCompra { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public int CarrinhoId { get; set; }
        public double PrecoTotal { get; set; }
        public Livro Livro { get; set; }
        public int PedidoId { get; set; }
        


    }
}
