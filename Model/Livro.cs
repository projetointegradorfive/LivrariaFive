using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaFive.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Isbn { get; set; }
        public int AnoPublicacao { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public string Idioma { get; set; }
        public List<Autor> Autores { get; set; }
        public string NomesAutores
        {
            get { return string.Join(", ", Autores.Select(a => a.Nome)); }
        }

        public Image Imagem { get; set; } // Propriedade para a imagem

        public string img64 { get; set; }

        public bool Ativo { get; set; } = true;

        public Livro()
        {
        }


    }
}
