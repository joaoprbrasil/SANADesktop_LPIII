using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.Model
{
    public class Solicitacao
    {

        public Navio navio { get; set; }

        public bool Status { get; set; }

        public Solicitacao(Navio navio, bool status)
        {
            this.navio = navio;
            Status = status;
        }
    }
}
