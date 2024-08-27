using SANA.Model.DAO;
using SANA.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SANA.Model.Service
{
    public class SolicitacaoService
    {
        private readonly SolicitacaoDAO _solicitacaoDAO;
        private readonly NavioDAO _navioDAO;

        public SolicitacaoService(SolicitacaoDAO solicitacaoDAO, NavioDAO navioDAO)
        {
            _solicitacaoDAO = solicitacaoDAO;
            _navioDAO = navioDAO;
        }

        // Método para criar uma solicitação e associá-la a um navio
        public void CriarSolicitacaoParaNavio(Solicitacao solicitacao, int navioId)
        {
            var navio = _navioDAO.ObterPorId(navioId);
            if (navio == null)
                throw new ArgumentException("Navio não encontrado.");

            solicitacao.Navio = navio;
            _solicitacaoDAO.Adicionar(solicitacao);

            navio.Solicitacoes.Add(solicitacao);
            _navioDAO.Atualizar(navio); // Atualiza o navio com a nova solicitação
        }

        // Método para processar uma solicitação
        public void ProcessarSolicitacao(int solicitacaoId)
        {
            var solicitacao = _solicitacaoDAO.ObterPorId(solicitacaoId);
            if (solicitacao == null)
                throw new ArgumentException("Solicitação não encontrada.");

            // Exemplo de validação; ajuste conforme necessário
            if (solicitacao.Navio.DWT > 10000) // Condição fictícia
            {
                solicitacao.Status = "Aceita";
            }
            else
            {
                solicitacao.Status = "Rejeitada";
            }

            _solicitacaoDAO.Atualizar(solicitacao);
        }

        // Método para excluir uma solicitação
        public void ExcluirSolicitacao(int id)
        {
            _solicitacaoDAO.Excluir(id);
        }

        // Método para editar uma solicitação
        public void EditarSolicitacao(Solicitacao solicitacao)
        {
            _solicitacaoDAO.Atualizar(solicitacao);
        }

        // Método para obter o histórico de solicitações (mais recente para mais antiga)
        public IEnumerable<Solicitacao> HistoricoSolicitacoes()
        {
            return _solicitacaoDAO.ListarTodos();
        }
    }
}
