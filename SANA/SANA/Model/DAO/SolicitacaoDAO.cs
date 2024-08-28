using MySqlConnector;
using SANA.Model.Entities;
using SANA.Util;
using SANA.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.Model.DAO
{
    internal class SolicitacaoDAO
    {
        private MySqlConnection con;
        private string? comandosql;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;

        public SolicitacaoDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            this.con = conexaobd.RetornaConexao();
        }

        public int Salvar(Solicitacao solicitacao, Navio navio)
        {
            // Abre a conexão com o banco de dados
            con.Open();
            DateTime dataHoraAtual = DateTime.Now;
            // Comando SQL para inserir um novo registro na tabela Solicitacao
            comandosql = @"
                INSERT INTO Solicitacao (Data, NavioID)
                VALUES (@Data, @NavioID);"
            ;

            envelope = new MySqlCommand();
            envelope.Connection = con; // Associa a conexão ao comando
            envelope.CommandText = comandosql; // Define o texto do comando SQL

            // Adiciona os parâmetros e seus valores ao comando
            envelope.Parameters.AddWithValue("@Data", solicitacao.data);
            envelope.Parameters.AddWithValue("@NavioID", navio.id);

            // Prepara o comando para execução
            envelope.Prepare();

            // Executa o comando SQL e retorna o número de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();

            // Fecha a conexão com o banco de dados
            con.Close();

            // Retorna o número de linhas afetadas pela execução do comando
            return retorno;

        }

        public List<SolicitacaoDTO> ListarTodos()
        {
            // Criação da lista que irá guardar os objetos do tipo SolicitacaoDTO
            List<SolicitacaoDTO> lista_solicitacoes = new List<SolicitacaoDTO>();

            try
            {
                // Abre a conexão com o banco de dados
                con.Open();

                // Comando SQL para selecionar todos os registros da tabela Solicitacao com os dados dos navios
                comandosql = @"
                    SELECT 
                        s.Id AS SolicitacaoId, 
                        n.NomeNavio, 
                        n.Tipo, 
                        n.AnoConstrucao, 
                        s.Data AS DataSolicitacao, 
                        s.Status AS StatusSolicitacao
                    FROM 
                        Solicitacao s
                    JOIN 
                        Navio n 
                    ON 
                        s.NavioId = n.Id
                    ORDER BY 
                        s.Data DESC;"; // Ordena pela data em ordem decrescente

                // Cria um novo comando SQL
                envelope = new MySqlCommand();
                envelope.CommandText = comandosql;
                envelope.Connection = con;

                // Executa a leitura dos registros
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {
                    // Cria um objeto SolicitacaoDTO para cada registro retornado
                    SolicitacaoDTO solicitacao = new SolicitacaoDTO
                    {
                        SolicitacaoId = cursor.GetInt32("SolicitacaoId"),
                        NomeNavio = cursor.GetString("NomeNavio"),
                        Tipo = cursor.GetString("Tipo"),
                        AnoConstrucao = cursor.GetInt32("AnoConstrucao"),
                        DataSolicitacao = cursor.GetDateTime("DataSolicitacao"),
                        StatusSolicitacao = cursor.GetString("StatusSolicitacao")
                    };

                    // Adiciona o objeto SolicitacaoDTO à lista
                    lista_solicitacoes.Add(solicitacao);
                }
            }
            catch (Exception ex)
            {
                // Trata qualquer exceção que possa ocorrer
                Console.WriteLine("Erro ao listar solicitações: " + ex.Message);
            }
            finally
            {
                // Fecha o leitor e a conexão com o banco de dados
                if (cursor != null && !cursor.IsClosed)
                    cursor.Close();
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            // Retorna a lista de solicitações
            return lista_solicitacoes;
        }

        public int AlterarStatus(SolicitacaoDTO solicitacao)
        {
            // Abre a conexão com o banco de dados
            con.Open();

            // Comando SQL para atualizar o status da solicitação
            comandosql = @"
                UPDATE Solicitacao
                SET Status = @StatusSolicitacao
                WHERE Id = @SolicitacaoId";

            // Cria um novo comando SQL
            envelope = new MySqlCommand();
            envelope.Connection = con;
            envelope.CommandText = comandosql;

            // Adiciona os parâmetros e seus valores ao comando
            envelope.Parameters.AddWithValue("@StatusSolicitacao", solicitacao.StatusSolicitacao);
            envelope.Parameters.AddWithValue("@SolicitacaoId", solicitacao.SolicitacaoId);

            // Prepara o comando para execução
            envelope.Prepare();

            // Executa o comando SQL e retorna o número de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();

            // Fecha a conexão com o banco de dados
            con.Close();

            // Retorna o número de linhas afetadas pela execução do comando
            return retorno;
        }


        public int Alterar(Solicitacao solicitacao)
        {
            // Abre a conexão com o banco de dados
            con.Open();

            // Comando SQL para atualizar um registro existente na tabela Solicitacao
            comandosql = @"
                UPDATE Solicitacao
                SET Data = @Data,
                    NavioID = @NavioID
                WHERE Id = @Id";

            // Cria um novo comando SQL
            envelope = new MySqlCommand();
            envelope.Connection = con; // Associa a conexão ao comando
            envelope.CommandText = comandosql; // Define o texto do comando SQL

            // Adiciona os parâmetros e seus valores ao comando
            envelope.Parameters.AddWithValue("@Data", solicitacao.data);
            envelope.Parameters.AddWithValue("@NavioID", solicitacao.navio.id);

            // Prepara o comando para execução
            envelope.Prepare();

            // Executa o comando SQL e retorna o número de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();

            // Fecha a conexão com o banco de dados
            con.Close();

            // Retorna o número de linhas afetadas pela execução do comando
            return retorno;
        }

        public int Excluir(Solicitacao solicitacao)
        {
            // Abre a conexão com o banco de dados
            con.Open();

            // Comando sql para excluir um registro de uma solicitação
            comandosql = @"
                DELETE FROM Solitacao
                WHERE Id = @Id";

            // Cria um novo comando SQL
            envelope = new MySqlCommand();
            envelope.Connection = con; // Associa a conexão ao comando
            envelope.CommandText = comandosql; // Define o texto do comando SQL

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
