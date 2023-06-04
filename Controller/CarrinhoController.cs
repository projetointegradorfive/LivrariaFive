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

        // Verificar se há itens no carrinho
        //string queryCheckCarrinho = "SELECT L.idLivro,  L.titulo,  L.preco, L.livroImagem, I.quantidade " +
        //    "FROM tbItemDeCompra I INNER JOIN tbLivro L ON" +
        //    " I.idLivro = L.idLivro WHERE idCarrinho = @CarrinhoId";

        //using (SqlCommand commandCheckCarrinho = new SqlCommand(queryCheckCarrinho, connection))
        //{
        //    commandCheckCarrinho.Parameters.AddWithValue("@CarrinhoId", 11);
        //    int carrinhoCount = (int)commandCheckCarrinho.ExecuteScalar();

        //    if (carrinhoCount == 0)
        //    {
        //        Console.WriteLine("Carrinho vazio.");
        //        return carrinho;
        //    }
        //}
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

                        // Obter os itens do carrinho
                        using (SqlConnection connectionItems = DatabaseConnection.GetConnection())
                        {
                            string queryItems = "SELECT L.idLivro, L.titulo, L.preco, L.livroImagem, I.quantidade " +
                                               "FROM tbItemDeCompra I " +
                                               "INNER JOIN tbLivro L ON I.idLivro = L.idLivro " +
                                               "WHERE idCarrinho = @CarrinhoId";

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
