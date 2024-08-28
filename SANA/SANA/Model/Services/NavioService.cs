using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SANA.Model.Entities;
using SANA.Model.DAO;

namespace SANA.Model.Services
{
    internal class NavioService
    {
        NavioDAO navioDAO = new NavioDAO();
        public NavioService() { }

        public void InserirNavio(Navio navio)
        {
            navioDAO.Salvar(navio);
        }
        public int EditarNavio(Navio navio)
        {
            return navioDAO.Alterar(navio);
        }

        public List<Navio> ListarNavios()
        {
            return navioDAO.ListarTodos();
        }

        public int RemoverNavio(Navio navio)
        {
            return navioDAO.Excluir(navio);
        }
    }
}
