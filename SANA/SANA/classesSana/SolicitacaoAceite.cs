namespace SANA.classesSana
{
    internal class SolicitacaoAceite
    {
        private DateTime dataAtracacao;
        private string status;
        private string motivacao;
        private List<RelatorioSolicitacao> relatorio;

        public DateTime DataAtracacao { get => dataAtracacao; set => dataAtracacao = value; }
        public string Status { get => status; set => status = value; }
        public string Motivacao { get => motivacao; set => motivacao = value; }
        public List<RelatorioSolicitacao> Relatorio { get => relatorio; set => relatorio = value; }

        public SolicitacaoAceite(DateTime dataAtracacao, string status, string motivacao, List<RelatorioSolicitacao> relatorio)
        {
            DataAtracacao = dataAtracacao;
            Status = status;
            Motivacao = motivacao;
            Relatorio = relatorio;
        }

        public SolicitacaoAceite()
        {
        }


    }
}