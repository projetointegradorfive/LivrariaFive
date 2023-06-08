using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaFive.Model;

using System.IO;

namespace LivrariaFive.View
{
    public partial class DetalhesLivro : Form
    {
        public DetalhesLivro(string titulo, string isbn, string preco, string estoque, string descricao, string genero, string editora, string autor, Image imagem)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            lblIsbn.Text = isbn;
            lblPreco.Text = decimal.Parse(preco).ToString("C");
            lblEstoqueLivro.Text = estoque;
            lblDescricao.Text = descricao;
            lblGenero.Text = genero;
            lblEditora.Text = editora;
            lblAutor.Text = autor;
            pictureBoxLivro.Image = imagem;

            
        }

        private void DetalhesLivro_Load(object sender, EventArgs e)
        {

        }
    }
}
