using SANA.Model;
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

        public SolicitarAceite()
        {
            InitializeComponent();
        }

        public SolicitarAceite(List<Navio> navios)
        {
            InitializeComponent();
            for (int i = 0; i < navios.Count; i++)
            {
                //Console.WriteLine(navios[i]);
                if (navios[i].Solicitacao.Equals("Aguardando Aceite.") || navios[i].Solicitacao.Equals("Recusada.") || navios[i].Solicitacao.Equals("Confirmada."))
                {
                    Solicitacao solicitacao = new Solicitacao(navios[i].NomeNavio, navios[i].Tipo, navios[i].Solicitacao);
                    solicitacoes.Add(solicitacao);
                }
            }
            if (solicitacoes.Count > 0)
            {
                label1.Text = "";
                dataGridView1.DataSource = solicitacoes;
                dataGridView1.Columns[0].Width = 290;
                dataGridView1.Columns[1].Width = 275;
                dataGridView1.Columns[2].Width = 290;

            }
            this.navios = navios;
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
                int index = linhaSelecionada.Index;
                string nomeNavio = linhaSelecionada.Cells[0].Value.ToString();
                string tipo = linhaSelecionada.Cells[1].Value.ToString();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < navios.Count; i++)
                    {
                        if (navios[i].NomeNavio.Equals(nomeNavio) && navios[i].Tipo.Equals(tipo))
                        {
                            if (navios[i].Solicitacao.Equals("Recusada.") || navios[i].Solicitacao.Equals("Confirmada."))
                            {
                                MessageBox.Show("Essa solicitação já foi " + navios[i].Solicitacao.ToLower() + ".");
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Tem certeza que você deseja confirmar essa solicitação?",
                                "Warning", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                                if (result == DialogResult.Yes)
                                {
                                    navios[i].Solicitacao = "Confirmada.";
                                    SolicitarAceite telaSolicitacao = new SolicitarAceite(navios);
                                    telaSolicitacao.Show();
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
            int index = linhaSelecionada.Index;
            string nomeNavio = linhaSelecionada.Cells[0].Value.ToString();
            string tipo = linhaSelecionada.Cells[1].Value.ToString();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < navios.Count; i++)
                {
                    if (navios[i].NomeNavio.Equals(nomeNavio) && navios[i].Tipo.Equals(tipo))
                    {
                        if (navios[i].Solicitacao.Equals("Recusada.") || navios[i].Solicitacao.Equals("Confirmada."))
                        {
                            MessageBox.Show("Essa solicitação já foi " + navios[i].Solicitacao.ToLower() + ".");
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Tem certeza que você deseja recusar essa solicitação?",
                            "Warning", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                navios[i].Solicitacao = "Recusada.";
                                SolicitarAceite telaSolicitacao = new SolicitarAceite(navios);
                                telaSolicitacao.Show();
                                this.Close();
                            }
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
    }
}
