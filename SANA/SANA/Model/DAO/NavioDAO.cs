using MySqlConnector;
using SANA.Model.DTO;
using System;
using System.Collections.Generic;

namespace SANA.Model.DAO
{
    public class NavioDAO
    {
        private readonly MySqlConnection _connection;

        public NavioDAO(MySqlConnection connection)
        {
            _connection = connection;
        }

        // Método para adicionar um novo navio
        public void Adicionar(Navio navio)
        {
            try
            {
                string query = @"INSERT INTO Navios (NomeNavio, CaladoAereo, DWT, Loa, CaladoSaida, CaladoEntrada, Boca, Pontal, Lanca, AnoConstrucao, Tipo)
                                 VALUES (@NomeNavio, @CaladoAereo, @DWT, @Loa, @CaladoSaida, @CaladoEntrada, @Boca, @Pontal, @Lanca, @AnoConstrucao, @Tipo)";
                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@NomeNavio", navio.NomeNavio);
                command.Parameters.AddWithValue("@CaladoAereo", navio.CaladoAereo);
                command.Parameters.AddWithValue("@DWT", navio.DWT);
                command.Parameters.AddWithValue("@Loa", navio.Loa);
                command.Parameters.AddWithValue("@CaladoSaida", navio.CaladoSaida);
                command.Parameters.AddWithValue("@CaladoEntrada", navio.CaladoEntrada);
                command.Parameters.AddWithValue("@Boca", navio.Boca);
                command.Parameters.AddWithValue("@Pontal", navio.Pontal);
                command.Parameters.AddWithValue("@Lanca", navio.Lanca);
                command.Parameters.AddWithValue("@AnoConstrucao", navio.AnoConstrucao);
                command.Parameters.AddWithValue("@Tipo", navio.Tipo);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar navio: {ex.Message}");
            }
        }

        // Método para obter um navio por ID
        public Navio ObterPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Navios WHERE id = @Id";
                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Id", id);

                _connection.Open();
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Navio
                    {
                        id = reader.GetInt32("id"),
                        NomeNavio = reader.GetString("NomeNavio"),
                        CaladoAereo = reader.GetDouble("CaladoAereo"),
                        DWT = reader.GetDouble("DWT"),
                        Loa = reader.GetDouble("Loa"),
                        CaladoSaida = reader.GetDouble("CaladoSaida"),
                        CaladoEntrada = reader.GetDouble("CaladoEntrada"),
                        Boca = reader.GetDouble("Boca"),
                        Pontal = reader.GetDouble("Pontal"),
                        Lanca = reader.GetDouble("Lanca"),
                        AnoConstrucao = reader.GetDouble("AnoConstrucao"),
                        Tipo = reader.GetString("Tipo")
                    };
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter navio: {ex.Message}");
            }
            return null;
        }

        // Método para atualizar um navio existente
        public void Atualizar(Navio navio)
        {
            try
            {
                string query = @"UPDATE Navios
                                 SET NomeNavio = @NomeNavio, CaladoAereo = @CaladoAereo, DWT = @DWT, Loa = @Loa, CaladoSaida = @CaladoSaida,
                                     CaladoEntrada = @CaladoEntrada, Boca = @Boca, Pontal = @Pontal, Lanca = @Lanca, AnoConstrucao = @AnoConstrucao, Tipo = @Tipo
                                 WHERE id = @Id";
                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@NomeNavio", navio.NomeNavio);
                command.Parameters.AddWithValue("@CaladoAereo", navio.CaladoAereo);
                command.Parameters.AddWithValue("@DWT", navio.DWT);
                command.Parameters.AddWithValue("@Loa", navio.Loa);
                command.Parameters.AddWithValue("@CaladoSaida", navio.CaladoSaida);
                command.Parameters.AddWithValue("@CaladoEntrada", navio.CaladoEntrada);
                command.Parameters.AddWithValue("@Boca", navio.Boca);
                command.Parameters.AddWithValue("@Pontal", navio.Pontal);
                command.Parameters.AddWithValue("@Lanca", navio.Lanca);
                command.Parameters.AddWithValue("@AnoConstrucao", navio.AnoConstrucao);
                command.Parameters.AddWithValue("@Tipo", navio.Tipo);
                command.Parameters.AddWithValue("@Id", navio.id);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar navio: {ex.Message}");
            }
        }

        // Método para excluir um navio
        public void Excluir(int id)
        {
            try
            {
                string query = "DELETE FROM Navios WHERE id = @Id";
                using var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Id", id);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir navio: {ex.Message}");
            }
        }

        // Método para listar todos os navios
        public List<Navio> ListarTodos()
        {
            var navios = new List<Navio>();
            try
            {
                string query = "SELECT * FROM Navios";
                using var command = new MySqlCommand(query, _connection);

                _connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    navios.Add(new Navio
                    {
                        id = reader.GetInt32("id"),
                        NomeNavio = reader.GetString("NomeNavio"),
                        CaladoAereo = reader.GetDouble("CaladoAereo"),
                        DWT = reader.GetDouble("DWT"),
                        Loa = reader.GetDouble("Loa"),
                        CaladoSaida = reader.GetDouble("CaladoSaida"),
                        CaladoEntrada = reader.GetDouble("CaladoEntrada"),
                        Boca = reader.GetDouble("Boca"),
                        Pontal = reader.GetDouble("Pontal"),
                        Lanca = reader.GetDouble("Lanca"),
                        AnoConstrucao = reader.GetDouble("AnoConstrucao"),
                        Tipo = reader.GetString("Tipo")
                    });
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar navios: {ex.Message}");
            }
            return navios;
        }

    }
}
