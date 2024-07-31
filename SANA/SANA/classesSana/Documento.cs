namespace SANA.classesSana
{
    internal class Documento
    {
        private string tipoDocumento;
        private string conteudo;


        public Documento(string tipoDocumento, string conteudo)
        {
            TipoDocumento = tipoDocumento;
            Conteudo = conteudo;
        }

        public Documento() { }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Conteudo { get => conteudo; set => conteudo = value; }


    }
}