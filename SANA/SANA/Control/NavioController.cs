using SANA.Model.DTO;
using SANA.Model.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SANA.Controller
{
    public class NavioController
    {
        private readonly NavioService _navioService;

        public NavioController(NavioService navioService)
        {
            _navioService = navioService;
        }

        // Método para cadastrar um novo navio
        public void CadastrarNavio(string nomeNavio, double caladoAereo, double dWT, double loa, double caladoSaida, double caladoEntrada, double boca, double pontal, double lanca, double anoConstrucao, string tipo)
        {
            try
            {
                var navio = new Navio
                {
                    NomeNavio = nomeNavio,
                    CaladoAereo = caladoAereo,
                    DWT = dWT,
                    Loa = loa,
                    CaladoSaida = caladoSaida,
                    CaladoEntrada = caladoEntrada,
                    Boca = boca,
                    Pontal = pontal,
                    Lanca = lanca,
                    AnoConstrucao = anoConstrucao,
                    Tipo = tipo
                };

                _navioService.CadastrarNavio(navio);
                MessageBox.Show("Navio cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar navio: {ex.Message}");
            }
        }

        // Método para excluir um navio
        public void ExcluirNavio(int id)
        {
            try
            {
                _navioService.ExcluirNavio(id);
                MessageBox.Show("Navio excluído com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir navio: {ex.Message}");
            }
        }

        // Método para editar um navio
        public void EditarNavio(int id, string nomeNavio, double caladoAereo, double dWT, double loa, double caladoSaida, double caladoEntrada, double boca, double pontal, double lanca, double anoConstrucao, string tipo)
        {
            try
            {
                var navio = new Navio
                {
                    id = id,
                    NomeNavio = nomeNavio,
                    CaladoAereo = caladoAereo,
                    DWT = dWT,
                    Loa = loa,
                    CaladoSaida = caladoSaida,
                    CaladoEntrada = caladoEntrada,
                    Boca = boca,
                    Pontal = pontal,
                    Lanca = lanca,
                    AnoConstrucao = anoConstrucao,
                    Tipo = tipo
                };

                _navioService.EditarNavio(navio);
                MessageBox.Show("Navio editado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar navio: {ex.Message}");
            }
        }

        // Método para obter um navio por ID
        public Navio ObterNavioPorId(int id)
        {
            try
            {
                return _navioService.ObterNavioPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter navio: {ex.Message}");
                return null;
            }
        }

        // Método para listar todos os navios
        public List<Navio> ListarNavios()
        {
            try
            {
                return _navioService.ListarNavios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar navios: {ex.Message}");
                return new List<Navio>();
            }
        }

        // Método para listar solicitações de um navio específico
        public List<Solicitacao> ListarSolicitacoesPorNavio(int navioId)
        {
            try
            {
                return _navioService.ListarSolicitacoesPorNavio(navioId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar solicitações do navio: {ex.Message}");
                return new List<Solicitacao>();
            }
        }
    }
}
