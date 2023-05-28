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
    public class GeneroController
    {
        public Genero InserirGenero(Genero genero)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO tbGenero (nome) VALUES (@Nome)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", genero.Nome);

                connection.Open();
                command.ExecuteNonQuery();
            }

            return genero;
        }

        public bool VerificarGeneroExistente(string nomeGenero)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM tbGenero WHERE nome = @Nome";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nomeGenero);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }



        public List<Genero> ObterTodosGeneros()
        {
            List<Genero> generos = new List<Genero>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT nome FROM tbGenero";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //int idGenero = Convert.ToInt32(reader["idGenero"]);
                    string nome = reader["nome"].ToString();

                    Genero genero = new Genero {Nome = nome };
                    generos.Add(genero);
                }

                reader.Close();
            }

            return generos;
        }

        //usar para search
        public Genero ObterGeneroPorNome(string nome)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idGenero, nome FROM tbGenero WHERE nome = @Nome";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idGenero = Convert.ToInt32(reader["idGenero"]);
                    string nomeGenero = reader["nome"].ToString();

                    Genero genero = new Genero();
                    genero.IdGenero = idGenero;
                    genero.Nome = nomeGenero;

                    return genero;
                }
            }

            return null; // Retornar null caso o gênero não seja encontrado
        }

        public Genero ObterGeneroPorId(int idGenero)
        {
            Genero genero = null;

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idGenero, nome FROM tbGenero WHERE idGenero = @IdGenero";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGenero", idGenero);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nome = reader["nome"].ToString();

                    genero = new Genero { IdGenero = idGenero, Nome = nome };
                }

                reader.Close();
            }

            return genero;
        }

        

        public Genero AtualizarGenero(Genero genero)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbGenero SET nome = @Nome WHERE idGenero = @IdGenero";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", genero.Nome);
                command.Parameters.AddWithValue("@IdGenero", genero.IdGenero);

                connection.Open();
                command.ExecuteNonQuery();
            }

            return genero;
        }

        public void RemoverGenero(int idGenero)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM tbGenero WHERE idGenero = @IdGenero";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdGenero", idGenero);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

}
