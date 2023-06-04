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

        public void InserirItensDeCompra(int idCarrinho, List<ItemDeCompra> itensDeCompra)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                List<object[]> parametros = new List<object[]>();

                foreach (ItemDeCompra item in itensDeCompra)
                {
                    object[] parametrosItem = new object[]
                    {
                item.Quantidade,
                item.PrecoLivro,
                item.Livro.Id,
                idCarrinho,
                item.PrecoTotal
                    };

                    parametros.Add(parametrosItem);
                }

                foreach (object[] parametrosItem in parametros)
                {
                    string query = "INSERT INTO tbItemDeCompra (quantidade, preco_unitario, idLivro, idCarrinho, preco_total) " +
                                   "VALUES (@Quantidade, @PrecoUnitario, @IdLivro, @IdCarrinho, @PrecoTotal)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Quantidade", parametrosItem[0]);
                    command.Parameters.AddWithValue("@PrecoUnitario", parametrosItem[1]);
                    command.Parameters.AddWithValue("@IdLivro", parametrosItem[2]);
                    command.Parameters.AddWithValue("@IdCarrinho", idCarrinho);
                    command.Parameters.AddWithValue("@PrecoTotal", parametrosItem[4]);

                    command.ExecuteNonQuery();
                }
            }
        }

        public int ObterIdItemDeCompra(int livroId)
        {
            int itemId = 0;

            // Consulte o banco de dados para obter o ID do item de compra com base no ID do livro
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT idItemCompra FROM tbItemDeCompra WHERE idLivro = @LivroId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LivroId", livroId);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            itemId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o ID do item de compra do banco de dados: " + ex.Message);
            }

            return itemId;
        }



        public void RemoverItemDoCarrinho(Carrinho carrinho, int livroId)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Remover o item de compra do banco de dados
                    string deleteQuery = "DELETE FROM tbItemDeCompra WHERE idLivro = @LivroId";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@LivroId", livroId);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Remover o item de compra da lista no carrinho
                    var item = carrinho.ItensDeCompra.Find(i => i.Livro.Id == livroId);
                    if (item != null)
                    {
                        carrinho.ItensDeCompra.Remove(item);
                    }
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

                    // Remover todos os itens de compra do banco de dados associados ao carrinho
                    string deleteQuery = "DELETE FROM tbItemDeCompra WHERE idCarrinho = @CarrinhoId";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Limpar a lista de itens de compra do carrinho
                    carrinho.ItensDeCompra.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao limpar carrinho: " + ex.Message);
            }
        }


        public void AtualizarQuantidadeItem(Carrinho carrinho, int livroId, int quantidade)
        {
            var item = carrinho.ItensDeCompra.Find(i => i.Livro.Id == livroId);
            if (item != null)
            {
                item.Quantidade = quantidade;
            }
        }

        public void AtualizarItemDeCompra(ItemDeCompra item)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "UPDATE tbItemDeCompra SET quantidade = @Quantidade, preco_unitario = @PrecoUnitario, preco_total = @PrecoTotal WHERE idLivro = @LivroId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                        command.Parameters.AddWithValue("@PrecoUnitario", item.PrecoLivro);
                        command.Parameters.AddWithValue("@PrecoTotal", item.PrecoTotal);
                        command.Parameters.AddWithValue("@LivroId", item.Livro.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar o item de compra: " + ex.Message);
            }
        }
    }
}
