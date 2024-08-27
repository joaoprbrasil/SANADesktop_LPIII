using MySqlConnector;
using SANA.Model.DAO;
using SANA.Model.Entities;
using SANA.Util;
using System.Collections.Generic;

namespace SANA.Service
{
    public class NavioService
    {
        private NavioDAO _navioDAO;

        // Construtor que aceita uma instância de ConexaoBD
        public NavioService(ConexaoBD conexaoBD)
        {
            // Obtendo a conexão do ConexaoBD
            MySqlConnection connection = conexaoBD.RetornaConexao();
            // Inicializando o DAO com a conexão
            _navioDAO = new NavioDAO(connection);
        }

        // Método para cadastrar um novo navio
        public void CadastrarNavio(Navio navio)
        {
            try
            {
                _navioDAO.salvar(navio);
                Console.WriteLine("Navio cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar navio: {ex.Message}");
            }
        }

        // Método para editar um navio existente
        public void EditarNavio(Navio navio)
        {
            try
            {
                _navioDAO.atualizar(navio);
                Console.WriteLine("Navio atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar navio: {ex.Message}");
            }
        }

        // Método para deletar um navio pelo ID
        public void DeletarNavio(int id)
        {
            try
            {
                _navioDAO.Excluir(id);
                Console.WriteLine("Navio excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir navio: {ex.Message}");
            }
        }

        // Método para visualizar todos os navios
        public List<Navio> ListarNavios()
        {
            try
            {
                var navios = _navioDAO.ListarTodos();
                Console.WriteLine("Navios listados com sucesso!");
                return navios;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar navios: {ex.Message}");
                return new List<Navio>();
            }
        }

        // Método para visualizar um navio pelo ID
        public Navio ObterNavioPorId(int id)
        {
            try
            {
                var navio = _navioDAO.obterPorId(id);
                if (navio != null)
                {
                    Console.WriteLine("Navio encontrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Navio não encontrado.");
                }
                return navio;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter navio: {ex.Message}");
                return null;
            }
        }
    }
}
}
