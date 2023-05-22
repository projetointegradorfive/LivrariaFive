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

        public Image Imagem { get; set; } // Propriedade para a imagem

        public Livro()
        {
        }


        public int CalcularPrecoTotal(int quantidade)
        {
            return (int)(Preco * quantidade);
        }

        public void AdicionarEstoque(int quantidade)
        {
            Estoque += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            Estoque -= quantidade;
        }

        //public override string ToString()
        //{
        //    return $"Id: {Id}, Titulo: {Titulo}, Autor: {Autor.Nome}, Editora: {Editora.Nome}, Isbn: {Isbn}, AnoPublicacao: {AnoPublicacao}, Preco: {Preco}, Estoque: {Estoque}, Descricao: {Descricao}, Genero: {Genero.Nome}, Idioma: {Idioma}";
        //}
    }
}
