using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaFive.Model
{
    public class ItemDeCompra
    {
        public Livro Livro { get; set; }
        public string NomeLivro { get; set; }
        public double PrecoLivro { get; set; }
        public int Quantidade { get; set; }
        public double PrecoTotal { get; set; }



    }
}
