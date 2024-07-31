using SANA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANA.View
{
    public partial class VisualizarNavios : Form
    {
        private List<Navio> navios;

        public VisualizarNavios()
        {
            InitializeComponent();
        }

        public VisualizarNavios(List<Navio> navios)
        {
            InitializeComponent();
            this.navios = navios;
            if (navios != null)
            {
                label1.Text = "";
                dataGridView1.DataSource = navios;
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVisualizarEditar_Click(object sender, EventArgs e)
        {
            TelaCadastroNavio telaCadastroNavio = new TelaCadastroNavio(navios);
            telaCadastroNavio.Show();
            this.Close();
        }

        private void VisualizarNavios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Navio navioSelecionado = (Navio)dataGridView1.SelectedRows[0].DataBoundItem;
                navios.Remove(navioSelecionado);
                VisualizarNavios telaVisualizar = new VisualizarNavios(navios);
                telaVisualizar.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Navio navioSelecionado = (Navio)dataGridView1.SelectedRows[0].DataBoundItem;
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
                int index = linhaSelecionada.Index;
                EditarNavio editarNavio = new EditarNavio(navios, navioSelecionado, index);
                editarNavio.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
