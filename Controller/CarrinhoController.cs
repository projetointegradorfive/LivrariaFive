using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LivrariaFive.Model;
using System.Windows.Forms;
using LivrariaFive.Persistence;
using System.Drawing;
using System.IO;
namespace LivrariaFive.Controller

{
    public class CarrinhoController
    {

        public Carrinho ObterCarrinho(int idCliente)
        {
            Carrinho carrinho = null;
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    // Obter o carrinho com base no ID do cliente
                    string query = "SELECT idCarrinho, preco_total_carrinho FROM tbCarrinho WHERE idCliente = @IdCliente";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdCliente", idCliente);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        carrinho = new Carrinho();
                        carrinho.Id = reader.GetInt32(0);
                        carrinho.Total = reader.GetDouble(1);

                        // Obter os itens do carrinho usando subconsulta
                        using (SqlConnection connectionItems = DatabaseConnection.GetConnection())
                        {
                            string queryItems = "SELECT L.idLivro, L.titulo, L.preco, L.livroImagem, I.quantidade " +
                                                "FROM tbLivro L " +
                                                "INNER JOIN tbItemDeCompra I ON L.idLivro = I.idLivro " +
                                                "WHERE I.idCarrinho = @CarrinhoId AND I.idPedido IS NULL";

                            SqlCommand commandItems = new SqlCommand(queryItems, connectionItems);
                            commandItems.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);

                            connectionItems.Open();
                            SqlDataReader readerItems = commandItems.ExecuteReader();

                            while (readerItems.Read())
                            {
                                Livro livro = new Livro();
                                livro.Id = readerItems.GetInt32(0);
                                livro.Titulo = readerItems.GetString(1);
                                livro.Preco = readerItems.GetDouble(2);

                                byte[] imagemBytes = (byte[])readerItems.GetValue(3);
                                using (MemoryStream ms = new MemoryStream(imagemBytes))
                                {
                                    livro.Imagem = Image.FromStream(ms);
                                }

                                int quantidade = readerItems.GetInt32(4);

                                ItemDeCompra item = new ItemDeCompra
                                {
                                    Livro = livro,
                                    PrecoLivro = livro.Preco,
                                    NomeLivro = livro.Titulo,
                                    Quantidade = quantidade
                                };

                                carrinho.ItensDeCompra.Add(item);
                            }

                            readerItems.Close();
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o carrinho: " + ex.Message);
            }

            return carrinho;
        }





        public Carrinho CriarCarrinho(Cliente clienteAtual)
        {
            //CRIA UM CARRINHO PRO CLIENTE QUE ACABOU DE SE CADASTRAR
            Carrinho carrinho = new Carrinho();

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Inserir o carrinho no banco de dados com o ID do cliente atual
                    string query = "INSERT INTO tbCarrinho (idCliente, preco_total_carrinho) VALUES (@IdCliente, 0); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCliente", clienteAtual.IdCliente);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            carrinho.Id = Convert.ToInt32(result);
                            carrinho.Cliente = clienteAtual;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar o carrinho: " + ex.Message);
            }

            return carrinho;
        }

        public void AtualizarPrecoTotalCarrinho(int idCarrinho)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Calcular o preço total do carrinho
                    string calculateTotalQuery = "SELECT SUM(preco_total_ItemDeCompra) FROM tbItemDeCompra I WHERE idCarrinho = @IdCarrinho AND I.idPedido is NULL";
                    using (SqlCommand calculateTotalCommand = new SqlCommand(calculateTotalQuery, connection))
                    {
                        calculateTotalCommand.Parameters.AddWithValue("@IdCarrinho", idCarrinho);

                        object result = calculateTotalCommand.ExecuteScalar();
                        decimal precoTotal = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                        // Atualizar o preço total do carrinho na tabela tbCarrinho
                        string updateTotalQuery = "UPDATE tbCarrinho SET preco_total_carrinho = @PrecoTotal WHERE idCarrinho = @IdCarrinho";
                        using (SqlCommand updateTotalCommand = new SqlCommand(updateTotalQuery, connection))
                        {
                            updateTotalCommand.Parameters.AddWithValue("@PrecoTotal", precoTotal);
                            updateTotalCommand.Parameters.AddWithValue("@IdCarrinho", idCarrinho);

                            updateTotalCommand.ExecuteNonQuery();
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar o preço total do carrinho no banco de dados: " + ex.Message);
            }
        }
       
    }
}
