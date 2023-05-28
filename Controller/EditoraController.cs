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
    public class EditoraController
    {
        // Método para inserir uma editora no banco de dados
        public Editora InserirEditora(Editora editora)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO tbEditora (nome) VALUES (@Nome)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", editora.Nome);

                connection.Open();
                command.ExecuteNonQuery();
            }

            return editora;
        }

        public bool VerificarEditoraExistente(string nome)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM tbEditora WHERE nome = @Nome";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        



        public Editora ObterEditoraPorNome(string nome)
        {
            Editora editora = null;

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idEditora, nome FROM tbEditora WHERE nome = @Nome";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nome);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idEditora = Convert.ToInt32(reader["idEditora"]);
                    string nomeEditora = reader["nome"].ToString();

                    editora = new Editora { Id = idEditora, Nome = nomeEditora };
                }

                reader.Close();
            }

            return editora;
        }




        // Método para atualizar uma editora
        public void AtualizarEditora(Editora editora)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbEditora SET nome = @Nome WHERE idEditora = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", editora.Nome);
                command.Parameters.AddWithValue("@Id", editora.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }



        // Método para excluir uma editora
        public void ExcluirEditora(Editora editora)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM tbEditora WHERE idEditora = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", editora.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Editora> MostrarTodasEditoras()
        {
            List<Editora> editoras = new List<Editora>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM tbEditora";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Editora editora = new Editora
                    {
                        Id = Convert.ToInt32(reader["idEditora"]),
                        Nome = Convert.ToString(reader["nome"])
                    };

                    editoras.Add(editora);
                }
            }

            return editoras;
        }
    }
  }

