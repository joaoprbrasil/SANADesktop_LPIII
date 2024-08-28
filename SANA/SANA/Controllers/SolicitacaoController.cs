using System;
using System.Collections.Generic;
using SANA.Model.Entities;
using SANA.Model.Services;
using SANA.DTO;

namespace SANA.Controllers
{
    public class SolicitacaoController
    {
        private readonly SolicitacaoService solicitacaoService;

        public SolicitacaoController()
        {
            solicitacaoService = new SolicitacaoService();
        }

        public void InserirSolicitacao(Solicitacao solicitacao, Navio navio)
        {
            solicitacaoService.CriarSolicitacao(solicitacao, navio);
        }

        public void AlterarStatusSolicitacao(SolicitacaoDTO solicitacao)
        {
            solicitacaoService.AlterarStatusSolicitacao(solicitacao);
        }

        public List<SolicitacaoDTO> ListarSolicitacoes()
        {
            return solicitacaoService.HistoricoSolicitacoes();
        }

        public void EditarSolicitacao(Solicitacao solicitacao)
        {
            solicitacaoService.EditarSolicitacao(solicitacao);
        }

        public void RemoverSolicitacao(Solicitacao solicitacao)
        {
            solicitacaoService.RemoverNavio(solicitacao);
        }
    }
}
