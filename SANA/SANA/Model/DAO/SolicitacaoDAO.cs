using MySqlConnector;
using SANA.Model.DTO;
using System;
using System.Collections.Generic;

namespace SANA.Model.DAO
{
    public class SolicitacaoDAO
    {
        private MySqlConnection _connection;

        public SolicitacaoDAO(MySqlConnection connection)
        {
            _connection = connection;
        }

        // Método para adicionar uma nova solicitação
        public void salvar(Solicitacao solicitacao)
        {
            try
            {
                string query = @"INSERT INTO Solicitacoes (Id, Data, Status, NavioId)
                                 VALUES (@Nome, @Data, @Status, @NavioId)";
                using var command = new MySqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Id", solicitacao.Id);
                command.Parameters.AddWithValue("@Nome", solicitacao.Nome);
                command.Parameters.AddWithValue("@Data", solicitacao.Data);
                command.Parameters.AddWithValue("@Status", solicitacao.Status);
                command.Parameters.AddWithValue("@NavioId", solicitacao.Navio?.id ?? (object)DBNull.Value);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar solicitação: {ex.Message}");
            }
        }

        // Método para obter uma solicitação por ID
        public Solicitacao ObterPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Solicitacoes WHERE Id = @Id";
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
                        Navio = new Navio { id = reader.GetInt32("NavioId") } // Simplificação
                    };
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter solicitação: {ex.Message}");
            }
            return null;
        }

        // Método para atualizar uma solicitação existente
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
                command.Parameters.AddWithValue("@NavioId", solicitacao.Navio?.id ?? (object)DBNull.Value);
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

        // Método para excluir uma solicitação
        public void Excluir(int id)
        {
            try
            {
                string query = "DELETE FROM Solicitacoes WHERE Id = @Id";
                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Id", id);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir solicitação: {ex.Message}");
            }
        }

        // Método para listar todas as solicitações, do mais recente para o mais antigo
        public List<Solicitacao> ListarTodos()
        {
            var solicitacoes = new List<Solicitacao>();
            try
            {
                string query = "SELECT * FROM Solicitacoes ORDER BY Data DESC";
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
                        Navio = new Navio { id = reader.GetInt32("NavioId") } // Simplificação
                    });
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar solicitações: {ex.Message}");
            }
            return solicitacoes;
        }
    }
}
