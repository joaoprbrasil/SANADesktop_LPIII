using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.DTO
{
    public class SolicitacaoDTO
    {
        public int SolicitacaoId { get; set; }
        public string NomeNavio { get; set; }
        public string Tipo { get; set; }
        public int AnoConstrucao { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string StatusSolicitacao { get; set; }
    }

}
