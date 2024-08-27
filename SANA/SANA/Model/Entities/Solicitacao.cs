using System;

namespace SANA.Model.Entities
{
    // CLASSE REPRESENTATIVA DA ENTIDADE SOLICITACAO
    public class Solicitacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; } = string.Empty;

        public Navio Navio { get; set; } // Referência ao navio associado a solicitação

        public Solicitacao() { }

        public Solicitacao(int id, DateTime data, string status, Navio navio)
        {
            Id = id;
            Data = data;
            Status = status;
            Navio = navio;
        }

        public Solicitacao(DateTime data, string status, Navio navio)
        {
            Data = data;
            Status = status;
            Navio = navio;
        }
    }
}
