using SANA.Model.DAO;
using SANA.DTO;
using SANA.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.Model.Services
{
    internal class SolicitacaoService
    {
        private readonly SolicitacaoDAO solicitacaoDAO;

        public SolicitacaoService()
        {
            this.solicitacaoDAO = new SolicitacaoDAO();
        }


        public int CriarSolicitacao(Solicitacao solicitacao, Navio navio)
        {
            return solicitacaoDAO.Salvar(solicitacao, navio);
        }

        public List<SolicitacaoDTO> HistoricoSolicitacoes()
        {
            return solicitacaoDAO.ListarTodos();
        }

        public int EditarSolicitacao(Solicitacao solicitacao)
        {
            return solicitacaoDAO.Alterar(solicitacao);
        }

        public int AlterarStatusSolicitacao(SolicitacaoDTO solicitacao)
        {
            return solicitacaoDAO.AlterarStatus(solicitacao);
        }

        public int RemoverNavio(Solicitacao solicitacao)
        {
            return solicitacaoDAO.Excluir(solicitacao);
        }



    }
}
