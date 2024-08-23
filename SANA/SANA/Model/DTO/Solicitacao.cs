using System;

namespace SANA.Model.DTO
{
    public class Solicitacao
    {
        public int Id { get; set; } // Corrigido para ser uma propriedade
        public string Nome { get; set; } = string.Empty;
        public DateTime Data { get; set; } // Corrigido para ser DateTime
        public string Status { get; set; } = string.Empty;

        public Navio Navio { get; set; } // Referência ao navio associado

        // Construtor padrão
        public Solicitacao() { }

        // Construtor com parâmetros
        public Solicitacao(int id, string nome, DateTime data, string status, int navioId, Navio navio)
        {
            Id = id;
            Nome = nome;
            Data = data;
            Status = status;
            Navio = navio;
        }
    }
}
