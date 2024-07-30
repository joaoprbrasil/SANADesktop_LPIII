using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA
{
    internal class Embarcacao
    {
        private string nome;
        private string tipoCarga;
        private string tipoEmbarcacao;
        private List<string> solicitacao;
        private List<string> planoAmarracao;
        private double loa;
        private double boca;
        private double caladoEntrada;
        private double caladoSaida;
        private double caladoAereo;
        private double pontal;
        private double tamanhoLanca;
        private string dwt;
        private int anoConstrucao;

        
        public Embarcacao()
        {
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
