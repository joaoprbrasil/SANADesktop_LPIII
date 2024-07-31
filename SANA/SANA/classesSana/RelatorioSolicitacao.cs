namespace SANA.classesSana
{
    internal class RelatorioSolicitacao
    {
        private string conteudo;
        private string observacao;

        public string Conteudo { get => conteudo; set => conteudo = value; }
        public string Observacao { get => observacao; set => observacao = value; }

        public RelatorioSolicitacao(string conteudo, string observacao)
        {
            Conteudo = conteudo;
            Observacao = observacao;
        }

        public RelatorioSolicitacao()
        {
        }
    }
}