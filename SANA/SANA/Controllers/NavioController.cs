using SANA.Model.Entities;
using SANA.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.Controllers
{
    public class NavioController
    {
        private NavioService _service = new NavioService();
        public NavioController() { }

        public void inserirNavio(Navio navio)
        {
            _service.InserirNavio(navio);

        }

        public void editarNavio(Navio navio)
        {
            _service.EditarNavio(navio);
        }

        public void removerNavio(Navio navio)
        {
            _service.RemoverNavio(navio);
        }


        public List<Navio> listarNavios()
        {
            return _service.ListarNavios();
        }
    }
}
