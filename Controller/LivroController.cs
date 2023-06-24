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
using System.Data;

namespace LivrariaFive.Controller
{
    public class LivroController
    {

        public LivroController()
        {
        }
        public Livro Insert(Livro livro, List<Autor> autores)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())

            {
                //Convertendo imagem para guardar no banco
                byte[] imagemBytes = Convert.FromBase64String(livro.img64);          
                // Inserir o gênero
                GeneroController generoController = new GeneroController();
                Genero genero = generoController.ObterGeneroPorNome(livro.Genero);
                if (!generoController.VerificarGeneroExistente(livro.Genero))
                {
                    genero = new Genero { Nome = livro.Genero };
                    generoController.InserirGenero(genero);

                }

                // Inserir a editora
                EditoraController editoraController = new EditoraController();
                Editora editora = editoraController.ObterEditoraPorNome(livro.Editora);
                if (!editoraController.VerificarEditoraExistente(livro.Editora))
                {
                    editora = new Editora { Nome = livro.Editora };
                    editoraController.InserirEditora(editora);

                }

                // Obter o ID do gênero inserido
                int generoId = genero.IdGenero;

                // Obter o ID da editora inserida
                int editoraId = editora.Id;

                string query = @"INSERT INTO tbLivro (titulo, isbn, anoPublicacao, preco, estoque, descricao, idioma, idEditora, idGenero, livroImagem) 
                         VALUES (@Titulo, @Isbn, @AnoPublicacao, @Preco, @Estoque, @Descricao, @Idioma, @IdEditora, @IdGenero, @Imagem);
                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Titulo", livro.Titulo);
                command.Parameters.AddWithValue("@Isbn", livro.Isbn);
                command.Parameters.AddWithValue("@AnoPublicacao", livro.AnoPublicacao);
                command.Parameters.AddWithValue("@Preco", livro.Preco);
                command.Parameters.AddWithValue("@Estoque", livro.Estoque);
                command.Parameters.AddWithValue("@Descricao", livro.Descricao);
                command.Parameters.AddWithValue("@Idioma", livro.Idioma);
                command.Parameters.AddWithValue("@IdEditora", editoraId);
                command.Parameters.AddWithValue("@IdGenero", generoId);
                command.Parameters.Add("@Imagem", SqlDbType.VarBinary).Value = imagemBytes != null ? (object)imagemBytes : DBNull.Value;



                connection.Open();

                // Executar o comando e obter o ID do livro inserido
                int livroId = Convert.ToInt32(command.ExecuteScalar());
                AutorController autorController = new AutorController();
                foreach (var autor in autores)
                {
                    Autor autorExistente = autorController.ObterAutorPorNome(autor.Nome);

                    Autor autor2;
                    int autorId;

                    if (autorExistente == null)
                    {
                        // O autor não existe, então insira-o no banco de dados e obtenha o ID
                        autor2 = autorController.InserirAutor(autor);
                        autorId = autor2.IdAutor;
                    }
                    else
                    {
                        // O autor já existe, obtenha o ID diretamente
                        autorId = autorExistente.IdAutor;
                    }

                    // Inserir na tabela LivroAutor
                    InserirLivroAutor(livroId, autorId);
                }

                return livro;


            }
        }
 
            public byte[] ObterBytesImagem(string imagemBase64)
        {
            byte[] imagemBytes = null;

            if (!string.IsNullOrEmpty(imagemBase64))
            {
                byte[] bytes = Convert.FromBase64String(imagemBase64);

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    using (Image imagem = Image.FromStream(ms))
                    {
                        using (MemoryStream msOutput = new MemoryStream())
                        {
                            imagem.Save(msOutput, imagem.RawFormat);
                            imagemBytes = msOutput.ToArray();
                        }
                    }
                }
            }

            return imagemBytes;
        }




        public void InserirLivroAutor(int livroId, int autorId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO tbLivroAutor (idLivro, idAutor) VALUES (@LivroId, @AutorId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LivroId", livroId);
                command.Parameters.AddWithValue("@AutorId", autorId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public IList<Livro> GetAllLivros()
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT l.idLivro, l.Titulo, l.Isbn, l.AnoPublicacao, l.Preco, l.Estoque, l.Descricao, l.Idioma, 
                g.Nome AS Genero, e.Nome AS Editora, a.Nome AS Autor, l.livroImagem, l.ativoLivro
                FROM tbLivro l 
                LEFT JOIN tbGenero g ON l.idGenero = g.IdGenero 
                LEFT JOIN tbEditora e ON l.idEditora = e.IdEditora
                LEFT JOIN tbLivroAutor la ON l.idLivro = la.idLivro
                LEFT JOIN tbAutor a ON la.idAutor = a.IdAutor
                WHERE l.ativoLivro = 1";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int livroId = reader.GetInt32(0);

                    Livro livro = livros.FirstOrDefault(l => l.Id == livroId);

                    if (livro == null)
                    {
                        livro = new Livro
                        {
                            Id = livroId,
                            Titulo = reader.GetString(1),
                            Isbn = reader.GetString(2),
                            AnoPublicacao = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            Preco = reader.IsDBNull(4) ? 0.0 : reader.GetDouble(4),
                            Estoque = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            Descricao = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                            Idioma = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                            Genero = reader.GetString(8),
                            Editora = reader.GetString(9),
                            Autores = new List<Autor>(), // Inicializa a lista de autores
                            Ativo = reader.GetBoolean(12)
                            
                        };

                        if (!reader.IsDBNull(10))
                        {
                            Autor autor = new Autor { Nome = reader.GetString(10) };
                            livro.Autores.Add(autor); // Adiciona o autor atual à lista de autores
                        }

                        if (!reader.IsDBNull(11))
                        {
                            byte[] imagemBytes = (byte[])reader.GetValue(11);
                            using (MemoryStream ms = new MemoryStream(imagemBytes))
                            {
                                livro.Imagem = Image.FromStream(ms);
                                livro.img64 = Convert.ToBase64String(ms.ToArray());
                            }
                        }
                        if (!reader.IsDBNull(12)) // Índice da coluna "ativoLivro"
                        {
                            livro.Ativo = reader.GetBoolean(12); // Índice da coluna "ativoLivro"
                        }
                        else
                        {
                            livro.Ativo = false; // ou qualquer outro valor padrão que você desejar
                        }

                        livros.Add(livro);
                    }
                    else
                    {
                        if (!reader.IsDBNull(10))
                        {
                            Autor autor = new Autor { Nome = reader.GetString(10) };
                            livro.Autores.Add(autor); // Adiciona o autor atual à lista de autores do livro existente
                        }
                    }
                }

                reader.Close();
            }

            return livros;
        }




        public IList<Livro> GetAllLivrosADMIN()
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT l.idLivro, l.Titulo, l.Isbn, l.AnoPublicacao, l.Preco, l.Estoque, l.Descricao, l.Idioma, 
                g.Nome AS Genero, e.Nome AS Editora, a.Nome AS Autor, l.livroImagem, l.ativoLivro
                FROM tbLivro l 
                LEFT JOIN tbGenero g ON l.idGenero = g.IdGenero 
                LEFT JOIN tbEditora e ON l.idEditora = e.IdEditora
                LEFT JOIN tbLivroAutor la ON l.idLivro = la.idLivro
                LEFT JOIN tbAutor a ON la.idAutor = a.IdAutor";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int livroId = reader.GetInt32(0);

                    Livro livro = livros.FirstOrDefault(l => l.Id == livroId);

                    if (livro == null)
                    {
                        livro = new Livro
                        {
                            Id = livroId,
                            Titulo = reader.GetString(1),
                            Isbn = reader.GetString(2),
                            AnoPublicacao = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            Preco = reader.IsDBNull(4) ? 0.0 : reader.GetDouble(4),
                            Estoque = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            Descricao = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                            Idioma = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                            Genero = reader.GetString(8),
                            Editora = reader.GetString(9),
                            Autores = new List<Autor>(), // Inicializa a lista de autores
                            Ativo = reader.GetBoolean(12)

                        };

                        if (!reader.IsDBNull(10))
                        {
                            Autor autor = new Autor { Nome = reader.GetString(10) };
                            livro.Autores.Add(autor); // Adiciona o autor atual à lista de autores
                        }

                        if (!reader.IsDBNull(11))
                        {
                            byte[] imagemBytes = (byte[])reader.GetValue(11);
                            using (MemoryStream ms = new MemoryStream(imagemBytes))
                            {
                                livro.Imagem = Image.FromStream(ms);
                                livro.img64 = Convert.ToBase64String(ms.ToArray());
                            }
                        }
                        if (!reader.IsDBNull(12)) // Índice da coluna "ativoLivro"
                        {
                            livro.Ativo = reader.GetBoolean(12); // Índice da coluna "ativoLivro"
                        }
                        else
                        {
                            livro.Ativo = false; // ou qualquer outro valor padrão que você desejar
                        }

                        livros.Add(livro);
                    }
                    else
                    {
                        if (!reader.IsDBNull(10))
                        {
                            Autor autor = new Autor { Nome = reader.GetString(10) };
                            livro.Autores.Add(autor); // Adiciona o autor atual à lista de autores do livro existente
                        }
                    }
                }

                reader.Close();
            }

            return livros;
        }

        public string GetAutorName(string nomeAutor)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT Nome FROM tbAutor WHERE Nome = @Nome";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nomeAutor);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }

                return string.Empty;
            }
        }

        public bool RemoverLivro(int idLivro)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbLivro SET ativoLivro = @Ativo WHERE idlivro = @IdLivro";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ativo", false); // Define o valor da coluna ativo como false
                command.Parameters.AddWithValue("@IdLivro", idLivro);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0; // Retorna true se pelo menos uma linha for afetada (cliente atualizado com sucesso)
            }
        }
        
        public bool AtivaLivro(int idLivro)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE tbLivro SET ativoLivro = @Ativo WHERE idlivro = @IdLivro";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ativo", true); // Define o valor da coluna ativo como false
                command.Parameters.AddWithValue("@IdLivro", idLivro);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0; // Retorna true se pelo menos uma linha for afetada (cliente atualizado com sucesso)
            }
        }

        public Livro UpdateLivro(Livro livro, List<Autor> autores)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                byte[] imagemBytes = null;
                if (livro.Imagem != null)
                {
                    imagemBytes = ObterBytesImagem(livro.img64);
                }
                AutorController autorController = new AutorController();
                List<int> autorIds = new List<int>();

                foreach (Autor autor in autores)
                {
                    int autorId = ObterIdAutorPorNome(autor.Nome);

                    if (autorId == -1)
                    {
                        // O autor não existe, insere um novo autor no banco de dados
                        Autor novoAutor = autorController.InserirAutor(autor);
                        livro.Autores.Add(novoAutor);
                        autorIds.Add(novoAutor.IdAutor);
                    }
                    else
                    {
                        autorIds.Add(autorId);
                    }
                }

                string queryLivro = "UPDATE tbLivro SET titulo = @Titulo, idEditora = @EditoraId, isbn = @Isbn, " +
                                    "anoPublicacao = @AnoPublicacao, preco = @Preco, estoque = @Estoque, descricao = @Descricao, " +
                                    "idGenero = @GeneroId, idioma = @Idioma, livroImagem = @Imagem WHERE idLivro = @Id;";

                int idEditora = ObterIdEditoraPorNome(livro.Editora);
                int idGenero = ObterIdGeneroPorNome(livro.Genero);

                using (SqlCommand commandLivro = new SqlCommand(queryLivro, connection))
                {
                    commandLivro.Parameters.AddWithValue("@Id", livro.Id);
                    commandLivro.Parameters.AddWithValue("@Titulo", livro.Titulo);
                    commandLivro.Parameters.AddWithValue("@EditoraId", idEditora);
                    commandLivro.Parameters.AddWithValue("@Isbn", livro.Isbn);
                    commandLivro.Parameters.AddWithValue("@AnoPublicacao", livro.AnoPublicacao);
                    commandLivro.Parameters.AddWithValue("@Preco", livro.Preco);
                    commandLivro.Parameters.AddWithValue("@Estoque", livro.Estoque);
                    commandLivro.Parameters.AddWithValue("@Descricao", livro.Descricao);
                    commandLivro.Parameters.AddWithValue("@GeneroId", idGenero);
                    commandLivro.Parameters.AddWithValue("@Idioma", livro.Idioma);
                    commandLivro.Parameters.Add("@Imagem", SqlDbType.VarBinary).Value = (object)imagemBytes ?? DBNull.Value;


                    connection.Open();
                    commandLivro.ExecuteNonQuery();
                    connection.Close();
                }

                // Atualizar os autores do livro na tabela de associação tbLivroAutor
                string queryDeleteLivroAutor = "DELETE FROM tbLivroAutor WHERE idLivro = @LivroId;";
                string queryInsertLivroAutor = "INSERT INTO tbLivroAutor (idLivro, idAutor) VALUES (@LivroId, @AutorId);";

                using (SqlCommand commandDeleteLivroAutor = new SqlCommand(queryDeleteLivroAutor, connection))
                {
                    commandDeleteLivroAutor.Parameters.AddWithValue("@LivroId", livro.Id);
                    connection.Open();
                    commandDeleteLivroAutor.ExecuteNonQuery();
                    connection.Close();
                }

                using (SqlCommand commandInsertLivroAutor = new SqlCommand(queryInsertLivroAutor, connection))
                {
                    commandInsertLivroAutor.Parameters.AddWithValue("@LivroId", livro.Id);
                    foreach (int autorId in autorIds)
                    {
                        commandInsertLivroAutor.Parameters.Clear();
                        commandInsertLivroAutor.Parameters.AddWithValue("@LivroId", livro.Id);
                        commandInsertLivroAutor.Parameters.AddWithValue("@AutorId", autorId);

                        connection.Open();
                        commandInsertLivroAutor.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                // Atualizar a lista de autores no objeto livro
                livro.Autores.Clear();
                livro.Autores.AddRange(autores);

                return livro;
            }
        }





        public int ObterIdEditoraPorNome(string nomeEditora)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idEditora FROM tbEditora WHERE nome = @Nome";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nomeEditora);

                connection.Open(); // Abre a conexão com o banco de dados

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // O nome não foi encontrado, então vamos inserir a editora no banco de dados
                    query = "INSERT INTO tbEditora (nome) VALUES (@Nome); SELECT SCOPE_IDENTITY();";

                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", nomeEditora);

                    object insertedId = command.ExecuteScalar();

                    if (insertedId != null && insertedId != DBNull.Value)
                    {
                        return Convert.ToInt32(insertedId);
                    }
                }

                return -1;
            }
        }

        public int ObterIdGeneroPorNome(string nomeGenero)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idGenero FROM tbGenero WHERE nome = @Nome";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nomeGenero);

                connection.Open(); // Abre a conexão com o banco de dados

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // O nome não foi encontrado, então vamos inserir o gênero no banco de dados
                    query = "INSERT INTO tbGenero (nome) VALUES (@Nome); SELECT SCOPE_IDENTITY();";

                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", nomeGenero);

                    object insertedId = command.ExecuteScalar();

                    if (insertedId != null && insertedId != DBNull.Value)
                    {
                        return Convert.ToInt32(insertedId);
                    }
                }

                return -1;
            }
        }
        public int ObterIdAutorPorNome(string nomeAutor)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT idAutor FROM tbAutor WHERE nome = @NomeAutor;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NomeAutor", nomeAutor);

                connection.Open();

                var result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Retorna um valor indicando que o autor não foi encontrado
                }
            }
        }








    }
}
