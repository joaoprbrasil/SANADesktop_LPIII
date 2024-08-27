using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SANA.Model
{
    public class Navio
    {

        public string NomeNavio { get; set; } = string.Empty;
        public double CaladoAereo { get; set; }
        public double DWT { get; set; }
        public double Loa { get; set; }
        public double CaladoSaida { get; set; }
        public double CaladoEntrada { get; set; }
        public double Boca { get; set; }
        public double Pontal { get; set; }
        public double Lanca { get; set; }
        public double AnoConstrucao { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public decimal Salario { get; set; }

        public String Solicitacao { get; set; } = "Em processo.";

        //public List<Solicitacao> Solicitacoes { get; set; } = new List<Solicitacao>();

        public Navio(string nomeNavio, double caladoAereo, double dWT, double loa, double caladoSaida, double caladoEntrada, double boca, double pontal, double lanca, double anoConstrucao, string tipo, decimal salario, String solicitacao)
        {
            NomeNavio = nomeNavio;
            CaladoAereo = caladoAereo;
            DWT = dWT;
            Loa = loa;
            CaladoSaida = caladoSaida;
            CaladoEntrada = caladoEntrada;
            Boca = boca;
            Pontal = pontal;
            Lanca = lanca;
            AnoConstrucao = anoConstrucao;
            Tipo = tipo;
            Salario = salario;
            Solicitacao = solicitacao;
        }
    }
}
