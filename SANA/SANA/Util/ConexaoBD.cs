using MySqlConnector;
using System;

namespace SANA.Util
{
    // CLASSE QUE GERENCIA A CONEXÃO COM O BANCO DE DADOS
    public class ConexaoBD
    {
        private MySqlConnection con; // Atributo que representa a conexão com o banco de dados

        public ConexaoBD()
        {
            // String de Conexão sem especificar um banco de dados
            string strconexao = "server=localhost;userid=root;password=;";
            con = new MySqlConnection(strconexao);
            CriarBancoDeDados();
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
                string strconexaoComDB = "server=localhost;userid=root;password=;database=sana_db";
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

        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }
    }
}
