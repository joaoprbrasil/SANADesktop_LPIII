using SANA.Model.DAO;
using SANA.Model.Entities;
using SANA.Controllers;
using SANA.Model.Services;
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
        NavioController navioController = new NavioController();
        SolicitacaoController solicitacaoController = new SolicitacaoController();
       

        public VisualizarNavios()
        {
            InitializeComponent();

            // Carrega a lista de navios do banco de dados
            this.navios = navioController.listarNavios();

            // Verifica se a lista contém elementos
            if (navios != null && navios.Count > 0)
            {
                // Limpa o texto do label e define a fonte de dados do DataGridView
                label1.Text = "";
                dataGridView1.DataSource = navios;
            }
            else
            {
                label1.Text = "Nenhum navio encontrado.";
            }
        }


        private void btnVisualizarEditar_Click(object sender, EventArgs e)
        {
            TelaCadastroNavio telaCadastroNavio = new TelaCadastroNavio();
            telaCadastroNavio.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Navio navioSelecionado = (Navio)dataGridView1.SelectedRows[0].DataBoundItem;
                if (navioSelecionado.Solicitacao.Equals("Confirmada.") || navioSelecionado.Solicitacao.Equals("Recusada."))
                {
                    MessageBox.Show("Esse navio não pode ser excluido, a solicitação dele está " + navioSelecionado.Solicitacao.ToLower() + ".");
                }
                else
                {
                    //navios.Remove(navioSelecionado);
                    //navioDAO.Excluir(navioSelecionado);
                    navioController.removerNavio(navioSelecionado);
                    VisualizarNavios telaVisualizar = new VisualizarNavios();
                    telaVisualizar.Show();
                    this.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Navio navioSelecionado = (Navio)dataGridView1.SelectedRows[0].DataBoundItem;
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
                int index = linhaSelecionada.Index;
                EditarNavio editarNavio = new EditarNavio(navioSelecionado);
                editarNavio.Show();
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                Navio navioSelecionado = (Navio)dataGridView1.SelectedRows[0].DataBoundItem;
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
                if (navioSelecionado.Solicitacao.Equals("Aguardando Aceite.") || navioSelecionado.Solicitacao.Equals("Confirmada.") || navioSelecionado.Solicitacao.Equals("Recusada."))
                {
                    MessageBox.Show("ERRO: Solicitação já emitida!");
                }
                else
                {
                    Solicitacao solicitacao = new Solicitacao();
                    solicitacao.data = DateTime.Now;
                    solicitacaoController.InserirSolicitacao(solicitacao, navioSelecionado);


                    navioSelecionado.Solicitacao = "Aguardando Aceite.";
                    navioController.editarNavio(navioSelecionado);
                    
                    MessageBox.Show("Solicitação emitida!");

                }
            }
        }

        private void VisualizarNavios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
