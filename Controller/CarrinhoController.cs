using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LivrariaFive.Model;
using System.Windows.Forms;
using LivrariaFive.Persistence;

namespace LivrariaFive.Controller
{
    public class CarrinhoController
    {
        public List<ItemDeCompra> ObterCarrinho(Carrinho carrinho)
        {
            List<ItemDeCompra> itens = new List<ItemDeCompra>();

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Verificar se há itens no carrinho
                    string queryCheckCarrinho = "SELECT COUNT(*) FROM tbCarrinho WHERE idCarrinho = @CarrinhoId";
                    using (SqlCommand commandCheckCarrinho = new SqlCommand(queryCheckCarrinho, connection))
                    {
                        commandCheckCarrinho.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);
                        int carrinhoCount = (int)commandCheckCarrinho.ExecuteScalar();

                        if (carrinhoCount == 0)
                        {
                            Console.WriteLine("Carrinho vazio.");
                            return itens;
                        }
                    }

                    // Obter os itens do carrinho
                    string query = "SELECT L.idLivro, L.titulo, L.preco, I.quantidade FROM tbItemDeCompra I INNER JOIN tbLivro L ON I.idLivro = L.idLivro WHERE I.idCarrinho = @CarrinhoId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Livro livro = new Livro();
                                livro.Id = reader.GetInt32(0);
                                livro.Titulo = reader.GetString(1);
                                livro.Preco = reader.GetDouble(2);
                                int quantidade = reader.GetInt32(3);

                                ItemDeCompra item = new ItemDeCompra
                                {
                                    Livro = livro,
                                    Quantidade = quantidade

                                };

                                itens.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o carrinho: " + ex.Message);
            }

            return itens;
        }


        public Carrinho CriarCarrinho()
        {
            Carrinho carrinho = new Carrinho();

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Inserir o carrinho no banco de dados com o ID do cliente
                    string query = "INSERT INTO tbCarrinho (idCliente, preco_total_carrinho, itens_compra) VALUES (1, 0, 0); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            carrinho.Id = Convert.ToInt32(result);
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




        public void AdicionarItemNoCarrinho(Carrinho carrinho, ItemDeCompra item)
        {
            carrinho.ItensDeCompra.Add(item);

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Verificar se o livro existe antes de adicionar o item
                    string queryVerificarLivro = "SELECT COUNT(*) FROM tbLivro WHERE idLivro = @LivroId";
                    using (SqlCommand commandVerificarLivro = new SqlCommand(queryVerificarLivro, connection))
                    {
                        commandVerificarLivro.Parameters.AddWithValue("@LivroId", item.Livro.Id);
                        int livroExistente = (int)commandVerificarLivro.ExecuteScalar();

                        if (livroExistente > 0)
                        {
                            // Obter as informações do livro a partir do banco de dados
                            string queryObterLivro = "SELECT titulo, preco FROM tbLivro WHERE idLivro = @LivroId";
                            using (SqlCommand commandObterLivro = new SqlCommand(queryObterLivro, connection))
                            {
                                commandObterLivro.Parameters.AddWithValue("@LivroId", item.Livro.Id);

                                using (SqlDataReader reader = commandObterLivro.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string titulo = reader.GetString(0);
                                        double preco = reader.GetDouble(1);

                                        // Criar uma instância do objeto Livro e atribuir as informações obtidas
                                        Livro livro = new Livro
                                        {
                                            Id = item.Livro.Id,
                                            Titulo = titulo,
                                            Preco = preco
                                        };

                                        // Atualizar a propriedade Livro do objeto itemDeCompra
                                        item.Livro = livro;

                                        // Inserir o item no banco de dados
                                        string query = "INSERT INTO tbItemDeCompra (quantidade, preco_unitario, preco_total, idLivro, idCarrinho) VALUES (@Quantidade, @PrecoUnitario, @PrecoTotal, @LivroId, @CarrinhoId)";
                                        using (SqlCommand command = new SqlCommand(query, connection))
                                        {
                                            command.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                            command.Parameters.AddWithValue("@PrecoUnitario", item.PrecoLivro);
                                            command.Parameters.AddWithValue("@PrecoTotal", item.PrecoTotal);
                                            command.Parameters.AddWithValue("@LivroId", item.Livro.Id);
                                            command.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);

                                            command.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Livro não existe, exibir mensagem de erro ou executar ação apropriada
                            Console.WriteLine("O livro selecionado não existe!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar o item no carrinho: " + ex.Message);
            }
        }



        public void LimparCarrinho(DataGridView dataGridViewCarrinho)
        {
            dataGridViewCarrinho.Rows.Clear();
        }

        public void AtualizarQuantidadeItem(DataGridView dataGridViewCarrinho, int livroId, int quantidade)
        {
            foreach (DataGridViewRow row in dataGridViewCarrinho.Rows)
            {
                if (Convert.ToInt32(row.Cells["LivroId"].Value) == livroId)
                {
                    row.Cells["Quantidade"].Value = quantidade;
                    break;
                }
            }
        }

        public void AtualizarCarrinho(Carrinho carrinho)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Atualizar o carrinho no banco de dados
                    string query = "UPDATE tbCarrinho SET preco_total_carrinho = @PrecoTotal WHERE idCarrinho = @CarrinhoId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PrecoTotal", carrinho.Total);
                        command.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);
                        command.ExecuteNonQuery();
                    }

                    // Remover todos os itens do carrinho existentes no banco de dados
                    query = "DELETE FROM tbItemDeCompra WHERE idCarrinho = @CarrinhoId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);
                        command.ExecuteNonQuery();
                    }

                    // Inserir os novos itens do carrinho no banco de dados
                    foreach (ItemDeCompra item in carrinho.ItensDeCompra)
                    {
                        query = "INSERT INTO tbItemDeCompra (quantidade, preco_unitario, preco_total, idLivro, idCarrinho) VALUES (@Quantidade, @PrecoUnitario, @PrecoTotal, @LivroId, @CarrinhoId)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                            command.Parameters.AddWithValue("@PrecoUnitario", item.PrecoLivro);
                            command.Parameters.AddWithValue("@PrecoTotal", item.PrecoTotal);
                            command.Parameters.AddWithValue("@LivroId", item.Livro.Id);
                            command.Parameters.AddWithValue("@CarrinhoId", carrinho.Id);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar o carrinho: " + ex.Message);
            }
        }
    }
}
