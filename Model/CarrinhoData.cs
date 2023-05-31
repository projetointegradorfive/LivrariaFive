using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaFive.Model
{
    public class CarrinhoData
    {
        public List<ItemDeCompra> Itens { get; set; }

        public CarrinhoData()
        {
            Itens = new List<ItemDeCompra>();
        }
    }
}
