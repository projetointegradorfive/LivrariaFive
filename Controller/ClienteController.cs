using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LivrariaFive.Model;
using LivrariaFive.Persistence;
using LivrariaFive.Controller;




namespace LivrariaFive.Controller
{
    public class ClienteController
    {
        public Cliente InserirCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO tbCliente (nome, email, senha, cpf, endereco, telefone, data_nascimento) " +
                                   "VALUES (@Nome, @Email, @Senha, @CPF, @Endereco, @Telefone, @DataNascimento); " +
                                   "SELECT SCOPE_IDENTITY();";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", cliente.Nome);
                    command.Parameters.AddWithValue("@Email", cliente.Email);
                    command.Parameters.AddWithValue("@Senha", cliente.Senha);
                    command.Parameters.AddWithValue("@CPF", cliente.CPF);
                    command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                    command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);

                    int idCliente = Convert.ToInt32(command.ExecuteScalar());
                    cliente.IdCliente = idCliente;

                    // Chamar o método CriarCarrinho passando o cliente atualizado
                    Carrinho carrinho = new CarrinhoController().CriarCarrinho(cliente);

                    return cliente;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }




        public Cliente VerificarCredenciais(string email, string senha)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idCliente, nome, cpf, endereco, telefone, data_nascimento FROM tbCliente WHERE email = @Email AND senha = @Senha";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idCliente = Convert.ToInt32(reader["idCliente"]);
                    string nome = reader["nome"].ToString();
                    string cpf = reader["cpf"].ToString();
                    string endereco = reader["endereco"].ToString();
                    string telefone = reader["telefone"].ToString();
                    DateTime dataNascimento = Convert.ToDateTime(reader["data_nascimento"]);

                    Cliente cliente = new Cliente
                    {
                        IdCliente = idCliente,
                        Nome = nome,
                        Email = email,
                        Senha = senha,
                        CPF = cpf,
                        Endereco = endereco,
                        Telefone = telefone,
                        DataNascimento = dataNascimento
                    };

                    return cliente;
                }
            }

            return null; // Retorna null caso as credenciais não sejam válidas ou ocorra algum erro na consulta
        }



        public Cliente ObterClientePorId(int idCliente)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT nome, email, senha, cpf, endereco, telefone, data_nascimento FROM tbCliente WHERE idCliente = @IdCliente";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", idCliente);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nome = reader["nome"].ToString();
                    string email = reader["email"].ToString();
                    string senha = reader["senha"].ToString();
                    string cpf = reader["cpf"].ToString();
                    string endereco = reader["endereco"].ToString();
                    string telefone = reader["telefone"].ToString();
                    DateTime dataNascimento = Convert.ToDateTime(reader["data_nascimento"]);

                    Cliente cliente = new Cliente
                    {
                        IdCliente = idCliente,
                        Nome = nome,
                        Email = email,
                        Senha = senha,
                        CPF = cpf,
                        Endereco = endereco,
                        Telefone = telefone,
                        DataNascimento = dataNascimento
                    };

                    return cliente;
                }
            }

            return null;
        }

        public Cliente AtualizarCliente(Cliente cliente)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbCliente SET nome = @Nome, email = @Email, senha = @Senha, cpf = @CPF, endereco = @Endereco, telefone = @Telefone, data_nascimento = @DataNascimento WHERE idCliente = @IdCliente";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.Parameters.AddWithValue("@Senha", cliente.Senha);
                command.Parameters.AddWithValue("@CPF", cliente.CPF);
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);

                connection.Open();
                command.ExecuteNonQuery();
            }

            return cliente;
        }

        public void RemoverCliente(int idCliente)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM tbCliente WHERE idCliente = @IdCliente";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", idCliente);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
