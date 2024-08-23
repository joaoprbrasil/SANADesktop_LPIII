using MySqlConnector;
using System;
using System.Collections.Generic;

namespace SANA.Util
{
    public class SolicitacaoDAO
    {
        private readonly MySqlConnection _connection;

        public SolicitacaoDAO()
        {
            var conexaoBD = new ConexaoBD();
            _connection = conexaoBD.RetornaConexao();
        }

        // Adiciona uma nova solicitação ao banco de dados
        public void Adicionar(Solicitacao solicitacao)
        {
            try
            {
                string query = @"INSERT INTO Solicitacoes (Nome, Data, Status, NavioId)
                                 VALUES (@Nome, @Data, @Status, @NavioId)";

                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Nome", solicitacao.Nome);
                command.Parameters.AddWithValue("@Data", solicitacao.Data);
                command.Parameters.AddWithValue("@Status", solicitacao.Status);
                command.Parameters.AddWithValue("@NavioId", solicitacao.Navio?.Id); // Considera o ID do Navio

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar solicitação: {ex.Message}");
            }
        }

        // Obtém uma solicitação pelo ID
        public Solicitacao ObterPorId(int id)
        {
            try
            {
                string query = @"SELECT Id, Nome, Data, Status, NavioId FROM Solicitacoes WHERE Id = @Id";

                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Id", id);

                _connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Solicitacao
                    {
                        Id = reader.GetInt32("Id"),
                        Nome = reader.GetString("Nome"),
                        Data = reader.GetDateTime("Data"),
                        Status = reader.GetString("Status"),
                        Navio = ObterNavioPorId(reader.GetInt32("NavioId")) // Carrega o navio associado
                    };
                }

                _connection.Close();
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter solicitação por ID: {ex.Message}");
                return null;
            }
        }

        // Atualiza uma solicitação no banco de dados
        public void Atualizar(Solicitacao solicitacao)
        {
            try
            {
                string query = @"UPDATE Solicitacoes
                                 SET Nome = @Nome, Data = @Data, Status = @Status, NavioId = @NavioId
                                 WHERE Id = @Id";

                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Nome", solicitacao.Nome);
                command.Parameters.AddWithValue("@Data", solicitacao.Data);
                command.Parameters.AddWithValue("@Status", solicitacao.Status);
                command.Parameters.AddWithValue("@NavioId", solicitacao.Navio?.Id); // Considera o ID do Navio
                command.Parameters.AddWithValue("@Id", solicitacao.Id);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar solicitação: {ex.Message}");
            }
        }

        // Remove uma solicitação pelo ID
        public void Remover(int id)
        {
            try
            {
                string query = @"DELETE FROM Solicitacoes WHERE Id = @Id";

                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Id", id);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover solicitação: {ex.Message}");
            }
        }

        // Obtém todas as solicitações
        public List<Solicitacao> ObterTodas()
        {
            var solicitacoes = new List<Solicitacao>();

            try
            {
                string query = @"SELECT Id, Nome, Data, Status, NavioId FROM Solicitacoes";

                using var command = new MySqlCommand(query, _connection);

                _connection.Open();
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    solicitacoes.Add(new Solicitacao
                    {
                        Id = reader.GetInt32("Id"),
                        Nome = reader.GetString("Nome"),
                        Data = reader.GetDateTime("Data"),
                        Status = reader.GetString("Status"),
                        Navio = ObterNavioPorId(reader.GetInt32("NavioId")) // Carrega o navio associado
                    });
                }

                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter todas as solicitações: {ex.Message}");
            }

            return solicitacoes;
        }

        // Método auxiliar para obter um navio por ID
        private Navio ObterNavioPorId(int navioId)
        {
            var navioDAO = new NavioDAO(); // Certifique-se de ter um DAO para Navio
            return navioDAO.ObterPorId(navioId);
        }
    }
}
