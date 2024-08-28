using SANA.Controllers;
using SANA.DTO;
using SANA.Model.Entities;
using SANA.Model.Services;
using SANA.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANA
{
    public partial class SolicitarAceite : Form
    {
        private List<Navio> navios;
        private List<Solicitacao> solicitacoes = new List<Solicitacao>();
        private List<SolicitacaoDTO> solicitacoesDTO = new List<SolicitacaoDTO>();
        SolicitacaoController solicitacaoController = new SolicitacaoController();


        public SolicitarAceite()
        {
            InitializeComponent();
            // Carrega a lista de navios do banco de dados
            this.solicitacoesDTO = solicitacaoController.ListarSolicitacoes();

            // Verifica se a lista contém elementos
            if (solicitacoesDTO != null)
            {
                // Limpa o texto do label e define a fonte de dados do DataGridView
                label1.Text = "";
                dataGridView1.DataSource = solicitacoesDTO;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].Width = 200;
            }
            else
            {
                label1.Text = "Nenhuma solicitação encontrado.";
            }
        }

        private void btnVisualizarEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
                SolicitacaoDTO solicitacaoDTO = (SolicitacaoDTO)dataGridView1.SelectedRows[0].DataBoundItem;


                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (solicitacaoDTO.StatusSolicitacao.Equals("Recusada.") || solicitacaoDTO.StatusSolicitacao.Equals("Confirmada."))
                    {
                        MessageBox.Show("Essa solicitação já foi " + solicitacaoDTO.StatusSolicitacao.ToLower());
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Tem certeza que você deseja confirmar essa solicitação?",
                        "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            solicitacaoDTO.StatusSolicitacao = "Confirmada.";
                            solicitacaoController.AlterarStatusSolicitacao(solicitacaoDTO);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
                SolicitacaoDTO solicitacaoDTO = (SolicitacaoDTO)dataGridView1.SelectedRows[0].DataBoundItem;


                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (solicitacaoDTO.StatusSolicitacao.Equals("Recusada.") || solicitacaoDTO.StatusSolicitacao.Equals("Confirmada."))
                    {
                        MessageBox.Show("Essa solicitação já foi " + solicitacaoDTO.StatusSolicitacao.ToLower());
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Tem certeza que você deseja recusar essa solicitação?",
                        "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            solicitacaoDTO.StatusSolicitacao = "Recusada.";
                            solicitacaoController.AlterarStatusSolicitacao(solicitacaoDTO);
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SolicitarAceite_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
