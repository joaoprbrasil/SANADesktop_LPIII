using SANA.Model.Entities;
using SANA.View;
using System;
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
    public partial class MenuPrincipal : Form
    {


        public MenuPrincipal()
        {
            InitializeComponent();
        }


        // Método de retorno de chamada para o evento FormClosed
        private void TelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrando o MenuPrincipal novamente quando TelaLogin for fechado
            this.Show();
        }

        private void btnCadastroNavios_Click(object sender, EventArgs e)
        {
            TelaCadastroNavio telaCadastroNavio = new TelaCadastroNavio();


            telaCadastroNavio.Show();
            this.Hide();
        }

        private void btnSolicitarAceite_Click(object sender, EventArgs e)
        {
            SolicitarAceite telaSolicitarAceite = new SolicitarAceite();
            telaSolicitarAceite.Show();
            this.Hide();
        }

        private void visualizarEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitarAceite solicitarAceite = new SolicitarAceite();
            solicitarAceite.MdiParent = this;
            solicitarAceite.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 telaLogin = new Form1();
            telaLogin.FormClosed += TelaLogin_FormClosed;
            telaLogin.Show();
            this.Close();
        }

        private void cadastrarNavioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastroNavio telaCadastroNavio = new TelaCadastroNavio();
            telaCadastroNavio.MdiParent = this;
            telaCadastroNavio.Show();
        }


        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que você realmente deseja sair?",
                "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void visualizarEditarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizarNavios telaVisualizarNavios = new VisualizarNavios();
            telaVisualizarNavios.MdiParent = this;
            telaVisualizarNavios.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
