using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.classesSana
{
    internal class AgenteNavio : User
    {
        private string empresa;

        public AgenteNavio()
        {
        }

        public AgenteNavio(string nome, string password, string matricula) : base(nome, password, matricula)
        {
        }

        public string Empresa { get => empresa; set => empresa = value; }
    }
}
