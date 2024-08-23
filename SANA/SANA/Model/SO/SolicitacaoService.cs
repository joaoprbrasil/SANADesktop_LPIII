using System;
using System.Collections.Generic;
using SANA.Model.DTO;
using SANA.Util;

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

        // Método para cadastrar uma nova solicitação
        public void CadastrarSolicitacao(Solicitacao solicitacao)
        {
            if (solicitacao == null)
                throw new ArgumentNullException(nameof(solicitacao));

            if (solicitacao.Navio == null || _navioDAO.ObterPorId(solicitacao.Navio.Id) == null)
                throw new ArgumentException("Navio associado não encontrado.");

            _solicitacaoDAO.Adicionar(solicitacao);
        }

        // Método para atualizar uma solicitação existente
        public void AtualizarSolicitacao(Solicitacao solicitacao)
        {
            if (solicitacao == null)
                throw new ArgumentNullException(nameof(solicitacao));

            if (_solicitacaoDAO.ObterPorId(solicitacao.Id) == null)
                throw new ArgumentException("Solicitação não encontrada.");

            if (solicitacao.Navio == null || _navioDAO.ObterPorId(solicitacao.Navio.Id) == null)
                throw new ArgumentException("Navio associado não encontrado.");

            _solicitacaoDAO.Atualizar(solicitacao);
        }

        // Método para excluir uma solicitação pelo ID
        public void ExcluirSolicitacao(int id)
        {
            var solicitacao = _solicitacaoDAO.ObterPorId(id);
            if (solicitacao == null)
                throw new ArgumentException("Solicitação não encontrada.");

            _solicitacaoDAO.Remover(id);
        }

        // Método para obter uma solicitação pelo ID
        public Solicitacao ObterSolicitacaoPorId(int id)
        {
            var solicitacao = _solicitacaoDAO.ObterPorId(id);
            if (solicitacao == null)
                throw new ArgumentException("Solicitação não encontrada.");

            return solicitacao;
        }

        // Método para listar todas as solicitações
        public IEnumerable<Solicitacao> ListarTodasSolicitacoes()
        {
            return _solicitacaoDAO.ObterTodas();
        }

        // Método para listar todas as solicitações de um navio
        public IEnumerable<Solicitacao> ListarSolicitacoesPorNavio(int navioId)
        {
            var navio = _navioDAO.ObterPorId(navioId);
            if (navio == null)
                throw new ArgumentException("Navio não encontrado.");

            return _solicitacaoDAO.ObterTodas().Where(s => s.Navio.Id == navioId);
        }
    }
}
