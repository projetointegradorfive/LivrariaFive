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
using System.Data;

namespace LivrariaFive.Controller
{
    public class LivroController
    {
        private AutorController autorController;

        public LivroController()
        {
            autorController = new AutorController();
        }
        public Livro Insert(Livro livro)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())


            {
                //Convertendo imagem para guardar no banco
                byte[] imagemBytes = ObterBytesImagem(livro.Imagem);

                // Inserir o autor
                AutorController autorController = new AutorController();
                Autor autor = autorController.ObterAutorPorNome(livro.Autor);
                autorController.InserirAutor(autor);

                // Inserir o gênero
                GeneroController generoController = new GeneroController();
                Genero genero = generoController.ObterGeneroPorNome(livro.Genero);
                generoController.InserirGenero(genero);

                // Inserir a editora
                EditoraController editoraController = new EditoraController();
                Editora editora = editoraController.ObterEditoraPorNome(livro.Editora);
                editoraController.InserirEditora(editora);

                // Obter o ID do autor inserido
                int autorId = autor.IdAutor;

                // Obter o ID do gênero inserido
                int generoId = genero.IdGenero;

                // Obter o ID da editora inserida
                int editoraId = editora.Id;

                string query = @"INSERT INTO tbLivro (titulo, isbn, anoPublicacao, preco, estoque, descricao, idioma, idEditora, idGenero, livroImagem) 
                         VALUES (@Titulo, @Isbn, @AnoPublicacao, @Preco, @Estoque, @Descricao, @Idioma, @IdEditora, @IdGenero, @Imagem);
                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Titulo", livro.Titulo);
                command.Parameters.AddWithValue("@Isbn", livro.Isbn);
                command.Parameters.AddWithValue("@AnoPublicacao", livro.AnoPublicacao);
                command.Parameters.AddWithValue("@Preco", livro.Preco);
                command.Parameters.AddWithValue("@Estoque", livro.Estoque);
                command.Parameters.AddWithValue("@Descricao", livro.Descricao);
                command.Parameters.AddWithValue("@Idioma", livro.Idioma);
                command.Parameters.AddWithValue("@IdEditora", editoraId);
                command.Parameters.AddWithValue("@IdGenero", generoId);
                command.Parameters.Add("@Imagem", SqlDbType.VarBinary).Value = (object)imagemBytes ?? DBNull.Value;





                connection.Open();

                // Executar o comando e obter o ID do livro inserido
                int livroId = Convert.ToInt32(command.ExecuteScalar());

                // Inserir na tabela LivroAutor
                InserirLivroAutor(livroId, autorId);
            }

            return livro;
        }

        public byte[] ObterBytesImagem(Image imagem)
        {
            byte[] imagemBytes = null;

            if (imagem != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagem.Save(ms, imagem.RawFormat);
                    imagemBytes = ms.ToArray();
                }
            }

            return imagemBytes;
        }








        public void InserirLivroAutor(int livroId, int autorId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO tbLivroAutor (idLivro, idAutor) VALUES (@LivroId, @AutorId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LivroId", livroId);
                command.Parameters.AddWithValue("@AutorId", autorId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public IList<Livro> GetAllLivros()
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT l.idLivro, l.Titulo, l.Isbn, l.AnoPublicacao, l.Preco, l.Estoque, l.Descricao, l.Idioma, " +
                               "g.Nome AS Genero, e.Nome AS Editora, " +
                               "a.Nome AS Autor, l.livroImagem " +
                               "FROM tbLivro l " +
                               "LEFT JOIN tbGenero g ON l.idGenero = g.IdGenero " +
                               "LEFT JOIN tbEditora e ON l.idEditora = e.IdEditora " +
                               "LEFT JOIN tbLivroAutor la ON l.idLivro = la.idLivro " +
                               "LEFT JOIN tbAutor a ON la.idAutor = a.IdAutor";

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
                        AnoPublicacao = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                        Preco = reader.IsDBNull(4) ? 0.0 : reader.GetDouble(4),
                        Estoque = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        Descricao = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Idioma = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Genero = reader.GetString(8),
                        Editora = reader.GetString(9),
                       
                    };

                    if (reader.IsDBNull(10))
                    {
                        livro.Autor = string.Empty;
                        Console.WriteLine("Nome do autor é nulo.");
                    }
                    else
                    {
                        livro.Autor = reader.GetString(10);
                        Console.WriteLine("Nome do autor: " + livro.Autor);
                    }

                    if (!reader.IsDBNull(11))
                    {
                        byte[] imagemBytes = (byte[])reader.GetValue(11);
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
        public string GetAutorName(string nomeAutor)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT Nome FROM tbAutor WHERE Nome = @Nome";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nomeAutor);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }

                return string.Empty;
            }
        }








        public void RemoverLivro(Livro livro)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM tbLivro WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", livro.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateLivro(Livro livro)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbLivro SET titulo = @Titulo, autor = @Autor, editora = @Editora, isbn = @Isbn, " +
                    "anoPublicacao = @AnoPublicacao, preco = @Preco, estoque = @Estoque, descricao = @Descricao, " +
                    "genero = @Genero, idioma = @Idioma, livroImagem = @LivroImagem WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", livro.Id);
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
        }


    }
}
