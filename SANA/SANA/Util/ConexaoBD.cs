using MySqlConnector;
using System;

namespace SANA.Util
{
    // Esta classe cria a conexão com o banco
    // Agora as informações sobre conexão estão dentro de uma única classe
    public class ConexaoBD
    {
        private MySqlConnection con;

        public ConexaoBD()
        {
            // String de Conexão sem especificar um banco de dados
            string strconexao = "server=localhost;userid=root;password=;";
            con = new MySqlConnection(strconexao);
            CriarBancoDeDados();
        }

        // Método para criar o banco de dados se não existir
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

                // Fecha a conexão
                con.Close();

                // Atualiza a string de conexão para o banco de dados criado
                string strconexaoComDB = "server=localhost;userid=root;password=;database=sana_bd";
                con = new MySqlConnection(strconexaoComDB);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o banco de dados: {ex.Message}");
            }
        }

        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }
    }
}
