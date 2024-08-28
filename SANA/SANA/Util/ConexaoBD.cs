using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace SANA.Util
{
    internal class ConexaoBD
    {
        private MySqlConnection con; // Atributo que representa a conexão com o banco de dados

        public ConexaoBD()
        {
            // String de Conexão sem especificar um banco de dados
            string strconexao = "server=localhost;userid=root;password=root;";
            con = new MySqlConnection(strconexao);
            CriarBancoDeDados();
            CriarTabelas();
        }

        // Método para acessar ou criar o banco de dados se não existir
        private void CriarBancoDeDados()
        {
            try
            {
                // Abre a conexão sem especificar o banco de dados
                con.Open();

                // Comando SQL para criar o banco de dados
                string comandoSQL = "CREATE DATABASE IF NOT EXISTS sana_db";

                using (var comando = new MySqlCommand(comandoSQL, con))
                {
                    comando.ExecuteNonQuery();
                }

                // Fecha a conexão inicial
                con.Close();

                // Atualiza a string de conexão para o banco de dados criado
                string strconexaoComDB = "server=localhost;userid=root;password=root;database=sana_db";
                con = new MySqlConnection(strconexaoComDB);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o banco de dados: {ex.Message}");
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void CriarTabelas()
        {
            try
            {
                // Abre a conexão com o banco de dados
                con.Open();

                // Comando SQL para criar a tabela Navio
                string comandoSQL_TabelaNavio = @"
                    CREATE TABLE IF NOT EXISTS Navio (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    NomeNavio VARCHAR(255) NOT NULL,
                    CaladoAereo DOUBLE NOT NULL,
                    DWT DOUBLE NOT NULL,
                    Loa DOUBLE NOT NULL,
                    CaladoSaida DOUBLE NOT NULL,
                    CaladoEntrada DOUBLE NOT NULL,
                    Boca DOUBLE NOT NULL,
                    Pontal DOUBLE NOT NULL,
                    Lanca DOUBLE NOT NULL,
                    AnoConstrucao INT NOT NULL,
                    Tipo VARCHAR(255) NOT NULL,
                    Solicitacao VARCHAR(255) DEFAULT 'Em processo.'
                );";

                string comandoSQL_TabelaSolicitacao = @"
                    CREATE TABLE IF NOT EXISTS Solicitacao (
                    Id INT AUTO_INCREMENT PRIMARY KEY,
                    Data DATETIME,
                    Status VARCHAR(40) NOT NULL DEFAULT 'Aguardando Aceite.',
                    NavioId INT,
                    FOREIGN KEY (NavioId) REFERENCES Navio(Id)
                );";

                using (var comando = new MySqlCommand(comandoSQL_TabelaNavio, con))
                {
                    comando.ExecuteNonQuery();
                }

                using (var comando = new MySqlCommand(comandoSQL_TabelaSolicitacao, con))
                {
                    comando.ExecuteNonQuery();
                }

                // Fechar a conexão
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar as tabelas: {ex.Message}");
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }
    }
}
