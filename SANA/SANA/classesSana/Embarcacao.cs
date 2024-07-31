namespace SANA.classesSana
{
    internal class Embarcacao
    {
        private string nome;
        private string tipoCarga;
        private string tipoEmbarcacao;
        private List<string> solicitacao;
      
        private double loa;
        private double boca;
        private double caladoEntrada;
        private double caladoSaida;
        private double caladoAereo;
        private double pontal;
        private double tamanhoLanca;
        private string dwt;
        private int anoConstrucao;
        private List<Documento> documentos;
        private List<SolicitacaoAceite> solicitacoes;


        public Embarcacao()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public string TipoCarga { get => tipoCarga; set => tipoCarga = value; }
        public string TipoEmbarcacao { get => tipoEmbarcacao; set => tipoEmbarcacao = value; }
        public List<string> Solicitacao { get => solicitacao; set => solicitacao = value; }
        public double Loa { get => loa; set => loa = value; }
        public double Boca { get => boca; set => boca = value; }
        public double CaladoEntrada { get => caladoEntrada; set => caladoEntrada = value; }
        public double CaladoSaida { get => caladoSaida; set => caladoSaida = value; }
        public double CaladoAereo { get => caladoAereo; set => caladoAereo = value; }
        public double Pontal { get => pontal; set => pontal = value; }
        public double TamanhoLanca { get => tamanhoLanca; set => tamanhoLanca = value; }
        public string Dwt { get => dwt; set => dwt = value; }
        public int AnoConstrucao { get => anoConstrucao; set => anoConstrucao = value; }

        public void addDocumento(Documento documento)
        {
            documentos.Add(documento);
        }

        public void addSolicitcao(SolicitacaoAceite solicitacaoAceite)
        {
            solicitacoes.Add(solicitacaoAceite);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $" Nome: {Nome}\n Tipo de Carga: {TipoCarga}\n Tipo de Embarcação: {TipoEmbarcacao}\n " +
                   $"LOA: {Loa}\n Boca: {Boca}\n Calado de Entrada: {CaladoEntrada}\n " +
                   $"Calado de Saída: {CaladoSaida}\n Calado Aéreo: {CaladoAereo}\n " +
                   $"Pontal: {Pontal}\n Tamanho da Lança: {TamanhoLanca}\n DWT: {Dwt}\n " +
                   $"Ano de Construção: {AnoConstrucao}";
        }
    }
}
