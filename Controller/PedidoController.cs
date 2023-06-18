using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LivrariaFive.Model;
using LivrariaFive.Persistence;

namespace LivrariaFive.Controller
{
    public class PedidoController
    {

        private Carrinho carrinho;
        public PedidoController(Carrinho carrinho)
        {
            this.carrinho = carrinho;

        }
        public Pedido InserirPedido(Pedido pedido)
        {
            pedido.Data = DateTime.Now;
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO tbPedido (data, preco_total_pedido, forma_pagamento, status, idCliente) VALUES (@Data, @PrecoTotalPedido, @FormaPagamento, @Status, @ClienteId); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Data", pedido.Data);
                command.Parameters.AddWithValue("@PrecoTotalPedido", pedido.PrecoTotalPedido);
                command.Parameters.AddWithValue("@FormaPagamento", pedido.FormaPagamento);
                command.Parameters.AddWithValue("@Status", pedido.Status);
                command.Parameters.AddWithValue("@ClienteId", pedido.Cliente.IdCliente);

                connection.Open();
                int idPedido = Convert.ToInt32(command.ExecuteScalar());
                pedido.IdPedido = idPedido;
                foreach (var item in pedido.ItensDeCompra)
                {
                    Console.WriteLine("ID do Item: " + item.Id);
                    Console.WriteLine("ID do Livro: " + item.Livro.Id);
                    Console.WriteLine("Quantidade: " + item.Quantidade);
                    Console.WriteLine("Preço Unitário: " + item.PrecoLivro);
                    Console.WriteLine("Preço Total: " + item.PrecoTotal);
                    Console.WriteLine();
                }

                ItemDeCompraController itemDeCompraController = new ItemDeCompraController();
                itemDeCompraController.AtualizarItensDeCompra(idPedido, pedido.ItensDeCompra);
                


            }

            return pedido;
        }

        public Pedido ObterPedidoPorId(int idPedido)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT data, preco_total_pedido, forma_pagamento, status, idCliente FROM tbPedido WHERE idPedido = @IdPedido";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdPedido", idPedido);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime data = Convert.ToDateTime(reader["data"]);
                    double precoTotalPedido = Convert.ToDouble(reader["preco_total_pedido"]);
                    string formaPagamento = reader["forma_pagamento"].ToString();
                    string status = reader["status"].ToString();
                    int clienteId = Convert.ToInt32(reader["idCliente"]);

                    // Obter o objeto Cliente associado ao pedido
                    ClienteController clienteController = new ClienteController();
                    Cliente cliente = clienteController.ObterClientePorId(clienteId);

                    Pedido pedido = new Pedido
                    {
                        IdPedido = idPedido,
                        Data = data,
                        PrecoTotalPedido = precoTotalPedido,
                        FormaPagamento = formaPagamento,
                        Status = status,
                        Cliente = cliente // Define o objeto Cliente obtido do banco de dados
                    };

                    return pedido;
                }
            }

            return null;
        }

        public Pedido AtualizarPedido(Pedido pedido)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbPedido SET data = @Data, preco_total_pedido = @PrecoTotalPedido, forma_pagamento = @FormaPagamento, status = @Status, idCliente = @ClienteId WHERE idPedido = @IdPedido";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Data", pedido.Data);
                command.Parameters.AddWithValue("@PrecoTotalPedido", pedido.PrecoTotalPedido);
                command.Parameters.AddWithValue("@FormaPagamento", pedido.FormaPagamento);
                command.Parameters.AddWithValue("@Status", pedido.Status);
                command.Parameters.AddWithValue("@ClienteId", pedido.Cliente.IdCliente);
                command.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);

                connection.Open();
                command.ExecuteNonQuery();
            }

            return pedido;
        }

        public void RemoverPedido(int idPedido)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM tbPedido WHERE idPedido = @IdPedido";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdPedido", idPedido);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
