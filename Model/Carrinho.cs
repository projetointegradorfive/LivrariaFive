using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaFive.Model
{
    public class Carrinho
    {
        public int Id { get; set; }
        public List<ItemDeCompra> ItensDeCompra { get; set; }
        public double Total { get; set; }
        public Cliente Cliente { get; set; }
        public Carrinho()
        {
            ItensDeCompra = new List<ItemDeCompra>();
            
        }
    }
}
