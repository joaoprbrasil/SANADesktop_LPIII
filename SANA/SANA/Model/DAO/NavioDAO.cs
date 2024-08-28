using System;
using MySqlConnector;

using SANA.Util;
using SANA.Model.Entities;

namespace SANA.Model.DAO
{
    public class NavioDAO
    {
        private MySqlConnection con;
        private string? comandosql;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;

        public NavioDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            this.con = conexaobd.RetornaConexao();
        }

        public int Salvar(Navio navio)
        {
            // Abre a conexão com o banco de dados
            con.Open();

            // Comando SQL para inserir um novo registro na tabela Navio
            comandosql = @"
                INSERT INTO Navio (NomeNavio, CaladoAereo, DWT, Loa, CaladoSaida, CaladoEntrada, Boca, Pontal, Lanca, AnoConstrucao, Tipo)
                VALUES (@NomeNavio, @CaladoAereo, @DWT, @Loa, @CaladoSaida, @CaladoEntrada, @Boca, @Pontal, @Lanca, @AnoConstrucao, @Tipo)";

            // Cria um novo comando SQL
            envelope = new MySqlCommand();
            envelope.Connection = con; // Associa a conexão ao comando
            envelope.CommandText = comandosql; // Define o texto do comando SQL

            // Adiciona os parâmetros e seus valores ao comando
            envelope.Parameters.AddWithValue("@NomeNavio", navio.NomeNavio);
            envelope.Parameters.AddWithValue("@CaladoAereo", navio.CaladoAereo);
            envelope.Parameters.AddWithValue("@DWT", navio.DWT);
            envelope.Parameters.AddWithValue("@Loa", navio.Loa);
            envelope.Parameters.AddWithValue("@CaladoSaida", navio.CaladoSaida);
            envelope.Parameters.AddWithValue("@CaladoEntrada", navio.CaladoEntrada);
            envelope.Parameters.AddWithValue("@Boca", navio.Boca);
            envelope.Parameters.AddWithValue("@Pontal", navio.Pontal);
            envelope.Parameters.AddWithValue("@Lanca", navio.Lanca);
            envelope.Parameters.AddWithValue("@AnoConstrucao", navio.AnoConstrucao);
            envelope.Parameters.AddWithValue("@Tipo", navio.Tipo);

            // Prepara o comando para execução
            envelope.Prepare();

            // Executa o comando SQL e retorna o número de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();

            // Fecha a conexão com o banco de dados
            con.Close();

            // Retorna o número de linhas afetadas pela execução do comando
            return retorno;
        }

        public List<Navio> ListarTodos()
        {
            // Criação da lista que irá guardar os objetos do tipo Navio
            List<Navio> lista_navios = new List<Navio>();

            try
            {
                // Abre a conexão com o banco de dados
                con.Open();

                // Comando SQL para selecionar todos os registros da tabela Navio
                comandosql = "SELECT * FROM Navio";

                // Cria um novo comando SQL
                envelope = new MySqlCommand();
                envelope.CommandText = comandosql;
                envelope.Connection = con;

                // Executa a leitura dos registros
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {
                    // Cria um objeto Navio para cada registro retornado
                    Navio navio = new Navio(
                        cursor.GetInt32("Id"), // Obtém o Id como int
                        cursor.GetString("NomeNavio"),
                        cursor.GetDouble("CaladoAereo"),
                        cursor.GetDouble("DWT"),
                        cursor.GetDouble("Loa"),
                        cursor.GetDouble("CaladoSaida"),
                        cursor.GetDouble("CaladoEntrada"),
                        cursor.GetDouble("Boca"),
                        cursor.GetDouble("Pontal"),
                        cursor.GetDouble("Lanca"),
                        cursor.GetInt32("AnoConstrucao"),
                        cursor.GetString("Tipo"),
                        cursor.GetString("Solicitacao")
                    );

                    // Adiciona o objeto Navio à lista
                    lista_navios.Add(navio);
                }
            }
            catch (Exception ex)
            {
                // Trata qualquer exceção que possa ocorrer
                Console.WriteLine("Erro ao listar navios: " + ex.Message);
            }
            finally
            {
                // Fecha o leitor e a conexão com o banco de dados
                if (cursor != null && !cursor.IsClosed)
                    cursor.Close();
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            // Retorna a lista de navios
            return lista_navios;
        }

        public int Excluir(Navio navio)
        {
            int retorno;

                con.Open();

                comandosql = @"
                    DELETE FROM Navio
                    WHERE Id = @Id";

                using (envelope = new MySqlCommand(comandosql, con))
                {
                    envelope.Parameters.AddWithValue("@Id", navio.id);
                    retorno = envelope.ExecuteNonQuery();
                }

            return retorno;
        }

        public int Alterar(Navio navio)
        {
            // Abre a conexão com o banco de dados
            con.Open();

            // Comando SQL para atualizar um registro existente na tabela Navio
            comandosql = @"
                UPDATE Navio
                SET NomeNavio = @NomeNavio, 
                    CaladoAereo = @CaladoAereo, 
                    DWT = @DWT, 
                    Loa = @Loa, 
                    CaladoSaida = @CaladoSaida, 
                    CaladoEntrada = @CaladoEntrada, 
                    Boca = @Boca, 
                    Pontal = @Pontal, 
                    Lanca = @Lanca, 
                    AnoConstrucao = @AnoConstrucao, 
                    Tipo = @Tipo,
                    Solicitacao = @Solicitacao
                WHERE Id = @Id";

            // Cria um novo comando SQL
            envelope = new MySqlCommand();
            envelope.Connection = con; // Associa a conexão ao comando
            envelope.CommandText = comandosql; // Define o texto do comando SQL

            // Adiciona os parâmetros e seus valores ao comando
            envelope.Parameters.AddWithValue("@NomeNavio", navio.NomeNavio);
            envelope.Parameters.AddWithValue("@CaladoAereo", navio.CaladoAereo);
            envelope.Parameters.AddWithValue("@DWT", navio.DWT);
            envelope.Parameters.AddWithValue("@Loa", navio.Loa);
            envelope.Parameters.AddWithValue("@CaladoSaida", navio.CaladoSaida);
            envelope.Parameters.AddWithValue("@CaladoEntrada", navio.CaladoEntrada);
            envelope.Parameters.AddWithValue("@Boca", navio.Boca);
            envelope.Parameters.AddWithValue("@Pontal", navio.Pontal);
            envelope.Parameters.AddWithValue("@Lanca", navio.Lanca);
            envelope.Parameters.AddWithValue("@AnoConstrucao", navio.AnoConstrucao);
            envelope.Parameters.AddWithValue("@Tipo", navio.Tipo);
            envelope.Parameters.AddWithValue("@Solicitacao", navio.Solicitacao);
            envelope.Parameters.AddWithValue("@Id", navio.id); // Adiciona o parâmetro para identificar qual registro atualizar

            // Prepara o comando para execução
            envelope.Prepare();

            // Executa o comando SQL e retorna o número de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();

            // Fecha a conexão com o banco de dados
            con.Close();

            // Retorna o número de linhas afetadas pela execução do comando
            return retorno;
        }

    }

}
