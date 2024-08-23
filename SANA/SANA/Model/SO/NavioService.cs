using MySqlConnector;
using SANA.Model.DTO;
using SANA.Model.DAO;
using System;
using System.Collections.Generic;

namespace SANA.Model.Service
{
    public class NavioService
    {
        private readonly NavioDAO _navioDAO;
        private readonly SolicitacaoDAO _solicitacaoDAO;

        public NavioService(NavioDAO navioDAO, SolicitacaoDAO solicitacaoDAO)
        {
            _navioDAO = navioDAO;
            _solicitacaoDAO = solicitacaoDAO;
        }

        // Método para cadastrar um novo navio
        public void CadastrarNavio(Navio navio)
        {
            if (navio == null)
                throw new ArgumentNullException(nameof(navio));

            _navioDAO.Adicionar(navio);
        }

        // Método para excluir um navio
        public void ExcluirNavio(int id)
        {
            // Verifica se o navio existe antes de tentar excluir
            var navio = _navioDAO.ObterPorId(id);
            if (navio == null)
                throw new ArgumentException("Navio não encontrado.");

            _navioDAO.Excluir(id);
        }

        // Método para adicionar uma solicitação para um navio
        public void AdicionarSolicitacaoParaNavio(Solicitacao solicitacao)
        {
            if (solicitacao == null)
                throw new ArgumentNullException(nameof(solicitacao));

            if (solicitacao.Navio == null)
                throw new ArgumentException("Navio associado não pode ser nulo.");

            // Obtém o navio pelo ID para atualizar a lista de solicitações
            var navio = _navioDAO.ObterPorId(solicitacao.Navio.Id);
            if (navio == null)
                throw new ArgumentException("Navio associado não encontrado.");

            // Adiciona a solicitação ao banco de dados
            _solicitacaoDAO.Adicionar(solicitacao);

            // Atualiza a lista de solicitações do navio
            if (navio.Solicitacoes == null)
                navio.Solicitacoes = new List<Solicitacao>();

            navio.Solicitacoes.Add(solicitacao);

            // Atualiza o navio no banco de dados
            _navioDAO.Atualizar(navio);
        }

        // Método para obter um navio por ID
        public Navio ObterNavioPorId(int id)
        {
            return _navioDAO.ObterPorId(id);
        }

        // Método para listar todos os navios
        public IEnumerable<Navio> ListarTodosNavios()
        {
            // Implemente um método no NavioDAO para listar todos os navios, se necessário.
            // Por exemplo:
            return _navioDAO.ListarTodos(); // Exemplo, dependendo da implementação no NavioDAO
        }

        // Método para listar todas as solicitações de um navio
        public IEnumerable<Solicitacao> ListarSolicitacoesDoNavio(int navioId)
        {
            // Implemente um método no SolicitacaoDAO para listar todas as solicitações de um navio
            return _solicitacaoDAO.ListarPorNavio(navioId); // Exemplo, dependendo da implementação no SolicitacaoDAO
        }
    }
}
