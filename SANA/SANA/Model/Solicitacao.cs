using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.Model
{
    public class Solicitacao
    {


        public String nome { get; set; } = string.Empty;

        public String tipo { get; set; } = string.Empty;

        public String status {  get; set; } = string.Empty;

        public Solicitacao(String nome, String tipo, String status) 
        {
            this.nome = nome;
            this.tipo = tipo;
            this.status = status;
        }

    }
}
