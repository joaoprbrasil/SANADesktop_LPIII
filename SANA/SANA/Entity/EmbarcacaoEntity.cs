using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SANA.classesSana;
namespace SANA.Entity
{
    internal class EmbarcacaoEntity
    {
        public static List<Embarcacao> embarcacaoLst;


        public EmbarcacaoEntity()
        {
        }

        internal List<Embarcacao> List { get => embarcacaoLst; set => embarcacaoLst = value; }
    }
}
