using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LivrariaFive.Model;
using LivrariaFive.Persistence;

namespace LivrariaFive.Controller
{
    public class ItemDeCompraController
    {
        private CarrinhoController carrinhoController;

       
        public ItemDeCompraController()
        {
            carrinhoController = new CarrinhoController();

        }

       

        public void InserirOuAtualizarItensDeCompra(int idCarrinho, List<ItemDeCompra> itensDeCompra)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                foreach (ItemDeCompra item in itensDeCompra)
                {
                    // Verifica se o item de compra já existe no carrinho
                    bool itemExistente = VerificarItemExistente(idCarrinho, item.Livro.Id);

                    if (itemExistente)
                    {
                        // Obtém a quantidade atual do item de compra no carrinho
                        int quantidadeAtual = ObterQuantidadeItem(idCarrinho, item.Livro.Id);

                        // Calcula a nova quantidade somando a quantidade atual com a quantidade do item adicionado
                        int novaQuantidade = quantidadeAtual + item.Quantidade;

                        // Atualiza a quantidade do item de compra no carrinho
                        AtualizarQuantidadeItem(idCarrinho, item.Livro.Id, novaQuantidade);
                    }
                    else
                    {
                        // Insere um novo item de compra no carrinho
                        InserirItensDeCompra(idCarrinho, item);
                        
                    }

                    // Atualizar o preço total do carrinho
                    carrinhoController.AtualizarPrecoTotalCarrinho(idCarrinho);
                }
            }
        }

        public void AtualizarItensDeCompra(int idPedido, List<ItemDeCompra> itensDeCompra)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbItemDeCompra SET idPedido = @IdPedido WHERE idItemCompra = @IdItemDeCompra AND idPedido is NULL";

                connection.Open();

                foreach (ItemDeCompra item in itensDeCompra)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdPedido", idPedido);
                    command.Parameters.AddWithValue("@IdItemDeCompra", item.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InserirItensDeCompra(int idCarrinho, ItemDeCompra item)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO tbItemDeCompra (quantidade, preco_unitario, idLivro, idCarrinho, preco_total_ItemDeCompra) " +
                                   "VALUES (@Quantidade, @PrecoUnitario, @IdLivro, @IdCarrinho, @PrecoTotal)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                        command.Parameters.AddWithValue("@PrecoUnitario", item.PrecoLivro);
                        command.Parameters.AddWithValue("@IdLivro", item.Livro.Id);
                        command.Parameters.AddWithValue("@IdCarrinho", idCarrinho);
                        command.Parameters.AddWithValue("@PrecoTotal", item.PrecoTotal);

                        command.ExecuteNonQuery();
                    }                 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir o item de compra no banco de dados: " + ex.Message);
            }
        }


        public int ObterQuantidadeItem(int idCarrinho, int idLivro)
        {
            int quantidade = 0;

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT quantidade FROM tbItemDeCompra WHERE idCarrinho = @IdCarrinho AND idLivro = @IdLivro AND idPedido is Null";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCarrinho", idCarrinho);
                        command.Parameters.AddWithValue("@IdLivro", idLivro);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            quantidade = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter a quantidade do item de compra do banco de dados: " + ex.Message);
            }

            return quantidade;
        }

        private bool VerificarItemExistente(int idCarrinho, int idLivro)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM tbItemDeCompra WHERE idCarrinho = @IdCarrinho AND idLivro = @IdLivro AND idPedido is NULL";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCarrinho", idCarrinho);
                        command.Parameters.AddWithValue("@IdLivro", idLivro);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar se o item de compra existe no banco de dados: " + ex.Message);
                return false;
            }
        }

        public void AtualizarQuantidadeItem(int idCarrinho, int idLivro, int quantidade)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Atualizar a quantidade do item de compra no banco de dados
                    string updateQuery = "UPDATE tbItemDeCompra SET quantidade = @Quantidade WHERE idCarrinho = @IdCarrinho AND idLivro = @IdLivro AND idPedido is NULL";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        command.Parameters.AddWithValue("@IdCarrinho", idCarrinho);
                        command.Parameters.AddWithValue("@IdLivro", idLivro);

                        command.ExecuteNonQuery();
                    }

                    // Calcular e atualizar o preço total do item de compra no banco de dados
                    string updatePriceQuery = "UPDATE tbItemDeCompra SET preco_total_ItemDeCompra = (quantidade * preco_unitario) WHERE idCarrinho = @IdCarrinho AND idLivro = @IdLivro AND idPedido is null";
                    using (SqlCommand updatePriceCommand = new SqlCommand(updatePriceQuery, connection))
                    {
                        updatePriceCommand.Parameters.AddWithValue("@IdCarrinho", idCarrinho);
                        updatePriceCommand.Parameters.AddWithValue("@IdLivro", idLivro);

                        updatePriceCommand.ExecuteNonQuery();
                    }
                }
               
                // Atualizar o preço total do carrinho
                carrinhoController.AtualizarPrecoTotalCarrinho(idCarrinho);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar a quantidade do item de compra no banco de dados: " + ex.Message);
            }
        }


        //obtendo o id do tem de compra corretamente
        public int ObterIdItemDeCompra(int livroId, int carrinhoId)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT idItemCompra FROM tbItemDeCompra WHERE idLivro = @LivroId AND idCarrinho = @CarrinhoId AND idPedido is NULL";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LivroId", livroId);
                        command.Parameters.AddWithValue("@CarrinhoId", carrinhoId);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o ID do item de compra do banco de dados: " + ex.Message);
            }

            return -1; // Retorna -1 para indicar que o ID não foi encontrado
        }


        public void RemoverItemDoCarrinho(Carrinho carrinho, int livroId)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Remover o item de compra do banco de dados
                    string deleteQuery = "DELETE FROM tbItemDeCompra WHERE idCarrinho = @CarrinhoId AND idLivro = @LivroId AND idPedido is NULL ";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);
                        deleteCommand.Parameters.AddWithValue("@LivroId", livroId);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Remover o item de compra da lista no carrinho
                    var item = carrinho.ItensDeCompra.Find(i => i.Livro.Id == livroId);
                    if (item != null)
                    {
                        carrinho.ItensDeCompra.Remove(item);
                    }
               
                    // Atualizar o preço total do carrinho
                    carrinhoController.AtualizarPrecoTotalCarrinho(carrinho.Id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover item de compra: " + ex.Message);
            }
        }
        public void LimparCarrinho(Carrinho carrinho)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Remover todos os itens de compra do banco de dados associados ao carrinho e que não estão associados em um pedido
                    string deleteQuery = "DELETE FROM tbItemDeCompra WHERE idCarrinho = @CarrinhoId AND idPedido is NULL";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Limpar a lista de itens de compra do carrinho
                    carrinho.ItensDeCompra.Clear();

                    // Atualizar o preço total do carrinho
                    carrinhoController.AtualizarPrecoTotalCarrinho(carrinho.Id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao limpar carrinho: " + ex.Message);
            }
        }
    }
}
