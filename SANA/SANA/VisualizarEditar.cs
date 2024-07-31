using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SANA.Entity;

namespace SANA
{
    public partial class VisualizarEditar : Form
    {
        public VisualizarEditar()
        {
            InitializeComponent();
            PopulateListView();
        }

        private void PopulateListView()
        {
            // Configurar o modo de exibição do ListView
            ltvVisualizarEmbarcações.View = View.Details;

            // Adicionar colunas ao ListView
            ltvVisualizarEmbarcações.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Tamanho Lança", 100, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Boca", 50, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Loa", 50, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Calado Aéreo", 100, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Ano Construção", 100, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Calado Entrada", 100, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Calado Saída", 100, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Tipo Embarcação", 100, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("DWT", 100, HorizontalAlignment.Left);
            ltvVisualizarEmbarcações.Columns.Add("Pontal", 50, HorizontalAlignment.Left);

            // Adicionar os itens ao ListView
            AddItemsToListView();
        }

        private void AddItemsToListView()
        {
            foreach (var embarcacao in EmbarcacaoEntity.embarcacaoLst)
            {
                ListViewItem item = new ListViewItem(embarcacao.Nome);
                item.SubItems.Add(embarcacao.TamanhoLanca.ToString());
                item.SubItems.Add(embarcacao.Boca.ToString());
                item.SubItems.Add(embarcacao.Loa.ToString());
                item.SubItems.Add(embarcacao.CaladoAereo.ToString());
                item.SubItems.Add(embarcacao.AnoConstrucao.ToString());
                item.SubItems.Add(embarcacao.CaladoEntrada.ToString());
                item.SubItems.Add(embarcacao.CaladoSaida.ToString());
                item.SubItems.Add(embarcacao.TipoEmbarcacao);
                item.SubItems.Add(embarcacao.Dwt);
                item.SubItems.Add(embarcacao.Pontal.ToString());
                ltvVisualizarEmbarcações.Items.Add(item);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
