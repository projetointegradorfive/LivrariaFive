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
        public Pedido InserirPedido(Pedido pedido)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO tbPedido (data, preco_total_pedido, itens_compra, forma_pagamento, status, idCliente) VALUES (@Data, @PrecoTotalPedido, @ItensCompra, @FormaPagamento, @Status, @ClienteId); SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Data", pedido.Data);
                command.Parameters.AddWithValue("@PrecoTotalPedido", pedido.PrecoTotalPedido);
                command.Parameters.AddWithValue("@ItensCompra", pedido.ItensCompra);
                command.Parameters.AddWithValue("@FormaPagamento", pedido.FormaPagamento);
                command.Parameters.AddWithValue("@Status", pedido.Status);
                command.Parameters.AddWithValue("@ClienteId", pedido.ClienteId);

                connection.Open();
                int idPedido = Convert.ToInt32(command.ExecuteScalar());
                pedido.IdPedido = idPedido;
            }

            return pedido;
        }

        public Pedido ObterPedidoPorId(int idPedido)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT data, preco_total_pedido, itens_compra, forma_pagamento, status, idCliente FROM tbPedido WHERE idPedido = @IdPedido";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdPedido", idPedido);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime data = Convert.ToDateTime(reader["data"]);
                    double precoTotalPedido = Convert.ToDouble(reader["preco_total_pedido"]);
                    int itensCompra = Convert.ToInt32(reader["itens_compra"]);
                    string formaPagamento = reader["forma_pagamento"].ToString();
                    string status = reader["status"].ToString();
                    int clienteId = Convert.ToInt32(reader["idCliente"]);

                    Pedido pedido = new Pedido
                    {
                        IdPedido = idPedido,
                        Data = data,
                        PrecoTotalPedido = precoTotalPedido,
                        ItensCompra = itensCompra,
                        FormaPagamento = formaPagamento,
                        Status = status,
                        ClienteId = clienteId
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
                string query = "UPDATE tbPedido SET data = @Data, preco_total_pedido = @PrecoTotalPedido, itens_compra = @ItensCompra, forma_pagamento = @FormaPagamento, status = @Status, idCliente = @ClienteId WHERE idPedido = @IdPedido";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Data", pedido.Data);
                command.Parameters.AddWithValue("@PrecoTotalPedido", pedido.PrecoTotalPedido);
                command.Parameters.AddWithValue("@ItensCompra", pedido.ItensCompra);
                command.Parameters.AddWithValue("@FormaPagamento", pedido.FormaPagamento);
                command.Parameters.AddWithValue("@Status", pedido.Status);
                command.Parameters.AddWithValue("@ClienteId", pedido.ClienteId);
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
