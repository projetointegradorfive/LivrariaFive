using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LivrariaFive.Model;
using LivrariaFive.Persistence;
using System.Drawing;
using System.IO;


namespace LivrariaFive.Controller
{
    public class LivroController
    {
        public Livro Insert(Livro livro)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
            
                string query = "INSERT INTO Livro (titulo, autor, editora, isbn, anoPublicacao, preco, estoque, descricao, genero, idioma, livroImagem) VALUES (@Titulo, @Autor, @Editora, @Isbn, @AnoPublicacao, @Preco, @Estoque, @Descricao, @Genero, @Idioma, @LivroImagem)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Titulo", livro.Titulo);
                command.Parameters.AddWithValue("@Autor", livro.Autor);
                command.Parameters.AddWithValue("@Editora", livro.Editora);
                command.Parameters.AddWithValue("@Isbn", livro.Isbn);
                command.Parameters.AddWithValue("@AnoPublicacao", livro.AnoPublicacao);
                command.Parameters.AddWithValue("@Preco", livro.Preco);
                command.Parameters.AddWithValue("@Estoque", livro.Estoque);
                command.Parameters.AddWithValue("@Descricao", livro.Descricao);
                command.Parameters.AddWithValue("@Genero", livro.Genero);
                command.Parameters.AddWithValue("@Idioma", livro.Idioma);
                command.Parameters.AddWithValue("@LivroImagem", livro.Imagem); // Adiciona a imagem como parâmetro

                connection.Open();
                command.ExecuteNonQuery();
            }

            return livro;
        }

        public IList<Livro> GetAllLivros()
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM tbLivro";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Livro livro = new Livro
                    {
                        Id = reader.GetInt32(0),
                        Titulo = reader.GetString(1),
                        Isbn = reader.GetString(2),
                        Preco = reader.GetDouble(4)
                    };

                    byte[] imagemBytes = reader["livroImagem"] as byte[];

                    if (imagemBytes != null && imagemBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            livro.Imagem = Image.FromStream(ms);
                        }
                    }

                    livros.Add(livro);
                }

                reader.Close();
            }

            return livros;
        }

    }
}
