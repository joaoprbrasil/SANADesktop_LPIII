using SANA.Model;
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
        private List<Navio> navios;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(List<Navio> navios)
        {
            InitializeComponent();
            this.navios = navios;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciando TelaLogin
            Form1 telaLogin = new Form1();

            // Adicionando um manipulador de eventos para o FormClosed
            telaLogin.FormClosed += TelaLogin_FormClosed;

            // Mostrando o formulário TelaLogin
            telaLogin.Show();

            // Ocultando o MenuPrincipal
            this.Hide();
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

        private void btnHistoricoAceite_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitarAceite_Click(object sender, EventArgs e)
        {
            SolicitarAceite telaSolicitarAceite = new SolicitarAceite();
            telaSolicitarAceite.Show();
            this.Hide();
        }

        private void solicitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitarAceite solicitarAceite = new SolicitarAceite(navios);
            solicitarAceite.MdiParent = this;
            solicitarAceite.Show();
        }

        private void editarSenhaDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            TelaCadastroNavio telaCadastroNavio = new TelaCadastroNavio(navios);
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
            VisualizarNavios telaVisualizarNavios = new VisualizarNavios(navios);
            telaVisualizarNavios.MdiParent = this;
            telaVisualizarNavios.Show();
        }
    }
}
