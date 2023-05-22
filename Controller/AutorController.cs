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
                string query = "INSERT INTO tbAutor (nome) VALUES (@Nome)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", autor.Nome);

                connection.Open();
                command.ExecuteNonQuery();
            }

            return autor;
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
                string query = "SELECT * FROM tbAutor WHERE nome = @Nome";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Autor autor = new Autor
                    {
                        IdAutor = reader.GetInt32(reader.GetOrdinal("idAutor")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };

                    reader.Close();
                    return autor;
                }

                reader.Close();
                return null;
            }
        }
    }
}
