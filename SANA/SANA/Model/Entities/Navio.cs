using System;
using System.Collections.Generic;

namespace SANA.Model.Entities
{
    // CLASSE REPRESENTATIVA DA ENTIDADE NAVIO
    public class Navio
    {
        public int Id { get; set; }
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

        // Lista de solicitações a qual o navio está associado
        public List<Solicitacao> Solicitacoes { get; set; } = new List<Solicitacao>();

        public Navio() { }

        public Navio(int id, string nomeNavio, double caladoAereo, double dwt, double loa, double caladoSaida, double caladoEntrada, double boca, double pontal, double lanca, double anoConstrucao, string tipo)
        {
            Id = id;
            NomeNavio = nomeNavio;
            CaladoAereo = caladoAereo;
            DWT = dwt;
            Loa = loa;
            CaladoSaida = caladoSaida;
            CaladoEntrada = caladoEntrada;
            Boca = boca;
            Pontal = pontal;
            Lanca = lanca;
            AnoConstrucao = anoConstrucao;
            Tipo = tipo;
        }

        public Navio(string nomeNavio, double caladoAereo, double dwt, double loa, double caladoSaida, double caladoEntrada, double boca, double pontal, double lanca, double anoConstrucao, string tipo)
        {
            NomeNavio = nomeNavio;
            CaladoAereo = caladoAereo;
            DWT = dwt;
            Loa = loa;
            CaladoSaida = caladoSaida;
            CaladoEntrada = caladoEntrada;
            Boca = boca;
            Pontal = pontal;
            Lanca = lanca;
            AnoConstrucao = anoConstrucao;
            Tipo = tipo;
        }
    }
}
