using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaFive.Model
{
    public class Pedido
    {
        public List<ItemDeCompra> ItensDeCompra { get; set; }
        public int IdPedido { get; set; }
        public DateTime Data { get; set; }
        public double PrecoTotalPedido { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }
        public Cliente Cliente { get; set; }
    }
}
