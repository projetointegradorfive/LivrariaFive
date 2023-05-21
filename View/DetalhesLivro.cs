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
        public DetalhesLivro(string titulo, string isbn, string preco, Image imagem)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            lblPreco.Text = preco;
            pictureBoxLivro.Image = imagem;


        }
    }
}
