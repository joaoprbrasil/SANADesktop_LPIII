using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace SANA.Model.Entities
{
    public class Navio
    {
        public int id { get; set; }
        public string NomeNavio { get; set; } = string.Empty;
        public double CaladoAereo { get; set; }
        public double DWT { get; set; }
        public double Loa { get; set; }
        public double CaladoSaida { get; set; }
        public double CaladoEntrada { get; set; }
        public double Boca { get; set; }
        public double Pontal { get; set; }
        public double Lanca { get; set; }
        public int AnoConstrucao { get; set; }
        public string Tipo { get; set; } = string.Empty;

        public string Solicitacao { get; set; } = "Em processo.";

        public List<Solicitacao> Solicitacoes { get; set; } = new List<Solicitacao>();

        public Navio() { }

        public Navio(string nomeNavio, double caladoAereo, double dWT, double loa, double caladoSaida, double caladoEntrada, double boca, double pontal, double lanca, int anoConstrucao, string tipo, string solicitacao)
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
            Solicitacao = solicitacao;
        }

        public Navio(int Id, string nomeNavio, double caladoAereo, double dWT, double loa, double caladoSaida, double caladoEntrada, double boca, double pontal, double lanca, int anoConstrucao, string tipo, string solicitacao)
        {
            id = Id;
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
            Solicitacao = solicitacao;
        }
    }
}
