using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaFive.Controller;
using LivrariaFive.Model;

namespace LivrariaFive.View
{
    public partial class LivroForm : Form
    {
        private LivroController livroController;

        public LivroForm()
        {
            InitializeComponent();
            livroController = new LivroController();
        }
        private void LivroForm_Load_1(object sender, EventArgs e)
        {
            PrencherDataGrid();
            ConfigurarGrade();
        }

        public void ConfigurarGrade()
        {
            dataGridViewLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridViewLivros.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridViewLivros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewLivros.Columns["Id"].Width = 50;
            dataGridViewLivros.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewLivros.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewLivros.Columns["Titulo"].Width = 300;
            dataGridViewLivros.Columns["Isbn"].Width = 100;
            dataGridViewLivros.Columns["Preco"].Width = 100;

        }

        public void PrencherDataGrid()
        {
            IList<Livro> livros = livroController.GetAllLivros();
            dataGridViewLivros.Columns.Clear();
            dataGridViewLivros.Rows.Clear();

            dataGridViewLivros.Columns.Add("Id", "ID");
            dataGridViewLivros.Columns.Add("Titulo", "Título");
            dataGridViewLivros.Columns.Add("Isbn", "ISBN");
            dataGridViewLivros.Columns.Add("Preco", "Preço");
            dataGridViewLivros.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Imagem",
                HeaderText = "Imagem",
                ImageLayout = DataGridViewImageCellLayout.Zoom, // Ajuste o layout da imagem conforme necessário
                Width = 100
            });

            foreach (Livro livro in livros)
            {
                dataGridViewLivros.Rows.Add(
                    livro.Id,
                    livro.Titulo,
                    livro.Isbn,
                    livro.Preco,
                    livro.Imagem
                );
            }

        }
       
        private void dataGridViewLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewLivros.Rows[e.RowIndex];
                string titulo = selectedRow.Cells["Titulo"].Value.ToString();
                string isbn = selectedRow.Cells["Isbn"].Value.ToString();
                string preco = selectedRow.Cells["Preco"].Value.ToString();
                Image imagem = (Image)selectedRow.Cells["Imagem"].Value;

                DetalhesLivro detalhesForm = new DetalhesLivro(titulo, isbn, preco, imagem);
                detalhesForm.ShowDialog();
            }

        }
    }
}
