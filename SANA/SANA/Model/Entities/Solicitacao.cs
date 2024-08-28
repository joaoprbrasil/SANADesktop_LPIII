using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.Model.Entities
{
    public class Solicitacao
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string status { get; set; } = string.Empty;

        public Navio navio { get; set; }

        public Solicitacao() { }

        public Solicitacao(int id, string status)
        {
            this.id = id;
            this.status = status;
        }

        public Solicitacao(string status)
        {
            this.status = status;
        }

    }

}
