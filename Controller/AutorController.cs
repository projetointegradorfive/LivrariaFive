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
    public class AutorController
    {
        public Autor InserirAutor(Autor autor)
        {
            if (VerificarAutorExistente(autor.Nome))
            {
                // Autor já existe, não é necessário inserir novamente
                return ObterAutorPorNome(autor.Nome);
            }

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO tbAutor (nome) VALUES (@Nome); SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", autor.Nome);

                connection.Open();

                // Executar o comando e obter o ID do autor inserido
                int autorId = Convert.ToInt32(command.ExecuteScalar());

                // Atribuir o ID ao objeto Autor
                autor.IdAutor = autorId;

                return autor;
            }
        }



        public void RemoverAutor(Autor autor)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM tbAutor WHERE idAutor = @IdAutor";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdAutor", autor.IdAutor);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarAutor(Autor autor)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbAutor SET nome = @Nome WHERE idAutor = @IdAutor";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", autor.Nome);
                command.Parameters.AddWithValue("@IdAutor", autor.IdAutor);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Autor> ObterTodosAutores()
        {
            List<Autor> autores = new List<Autor>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM tbAutor";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idAutor = reader.GetInt32(0);
                    string nome = reader.GetString(1);

                    Autor autor = new Autor
                    {
                        IdAutor = idAutor,
                        Nome = nome
                    };

                    autores.Add(autor);
                }

                reader.Close();
            }

            return autores;
        }

        public bool VerificarAutorExistente(string nome)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM tbAutor WHERE nome = @Nome";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        public Autor ObterAutorPorNome(string nome)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idAutor, nome FROM tbAutor WHERE nome = @Nome";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Autor autor = new Autor();
                    autor.IdAutor = Convert.ToInt32(reader["idAutor"]);
                    autor.Nome = reader["nome"].ToString();
                    return autor;
                }

                return null;
            }
        }
        public List<Autor> GetAutoresPorLivro(int livroId)
        {
            List<Autor> autores = new List<Autor>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
            SELECT A.idAutor, A.nome
            FROM tbAutor A
            INNER JOIN tbLivroAutor LA ON A.idAutor = LA.idAutor
            WHERE LA.idLivro = @LivroId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LivroId", livroId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idAutor = reader.GetInt32(0);
                    string nome = reader.GetString(1);

                    Autor autor = new Autor
                    {
                        IdAutor = idAutor,
                        Nome = nome
                    };

                    autores.Add(autor);
                }

                reader.Close();
            }

            return autores;
        }

        public int ObterIdAutorPorNome(string nomeAutor)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idAutor FROM tbAutor WHERE nome = @NomeAutor;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NomeAutor", nomeAutor);

                connection.Open();

                var result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Retorna um valor indicando que o autor não foi encontrado
                }
            }
        }

    }
}
