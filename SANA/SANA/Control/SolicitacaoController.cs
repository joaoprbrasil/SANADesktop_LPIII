using SANA.Model.DTO;
using SANA.Model.SO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SANA.Controller
{
    public class SolicitacaoController
    {
        private readonly SolicitacaoService _solicitacaoService;

        public SolicitacaoController(SolicitacaoService solicitacaoService)
        {
            _solicitacaoService = solicitacaoService;
        }

        // Método para criar uma nova solicitação
        public void CriarSolicitacaoParaNavio(string nome, DateTime data, string status, int navioId)
        {
            try
            {
                var solicitacao = new Solicitacao
                {
                    Nome = nome,
                    Data = data,
                    Status = status
                };

                _solicitacaoService.CriarSolicitacaoParaNavio(solicitacao, navioId);
                MessageBox.Show("Solicitação criada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar solicitação: {ex.Message}");
            }
        }

        // Método para processar uma solicitação
        public void ProcessarSolicitacao(int solicitacaoId)
        {
            try
            {
                _solicitacaoService.ProcessarSolicitacao(solicitacaoId);
                MessageBox.Show("Solicitação processada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar solicitação: {ex.Message}");
            }
        }

        // Método para excluir uma solicitação
        public void ExcluirSolicitacao(int solicitacaoId)
        {
            try
            {
                _solicitacaoService.ExcluirSolicitacao(solicitacaoId);
                MessageBox.Show("Solicitação excluída com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir solicitação: {ex.Message}");
            }
        }

        // Método para editar uma solicitação
        public void EditarSolicitacao(int id, string nome, DateTime data, string status, int navioId)
        {
            try
            {
                var solicitacao = new Solicitacao
                {
                    Id = id,
                    Nome = nome,
                    Data = data,
                    Status = status,
                    Navio = new Navio { id = navioId } // Simplificação para exemplo
                };

                _solicitacaoService.EditarSolicitacao(solicitacao);
                MessageBox.Show("Solicitação editada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar solicitação: {ex.Message}");
            }
        }

        // Método para obter o histórico de solicitações
        public List<Solicitacao> ObterHistoricoSolicitacoes()
        {
            try
            {
                var solicitacoes = _solicitacaoService.HistoricoSolicitacoes();
                return new List<Solicitacao>(solicitacoes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter histórico de solicitações: {ex.Message}");
                return new List<Solicitacao>();
            }
        }
    }
}
