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


        public void RemoverItemDoCarrinho(Carrinho carrinho, int livroId)
        {
            var item = carrinho.ItensDeCompra.Find(i => i.Livro.Id == livroId);
            if (item != null)
            {
                carrinho.ItensDeCompra.Remove(item);
            }
        }

        public void LimparCarrinho(Carrinho carrinho)
        {
            carrinho.ItensDeCompra.Clear();
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
