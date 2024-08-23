using SANA.Model.DAO;
using SANA.Model.DTO;
using System;
using System.Collections.Generic;

namespace SANA.Model.Service
{
    public class NavioService
    {
        private readonly NavioDAO _navioDAO;

        public NavioService(NavioDAO navioDAO)
        {
            _navioDAO = navioDAO;
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
            var navio = _navioDAO.ObterPorId(id);
            if (navio == null)
                throw new ArgumentException("Navio não encontrado.");

            _navioDAO.Excluir(id);
        }

        // Método para editar um navio
        public void EditarNavio(Navio navio)
        {
            if (navio == null || navio.id == 0)
                throw new ArgumentNullException(nameof(navio));

            _navioDAO.Atualizar(navio);
        }

        // Método para obter um navio por ID
        public Navio ObterNavioPorId(int id)
        {
            return _navioDAO.ObterPorId(id);
        }

        // Método para listar todos os navios
        public List<Navio> ListarNavios()
        {
            return _navioDAO.ListarTodos();
        }

        // Método para listar solicitações de um navio específico
        public List<Solicitacao> ListarSolicitacoesPorNavio(int navioId)
        {
            return _navioDAO.ListarSolicitacoesPorNavio(navioId);
        }
    }
}
