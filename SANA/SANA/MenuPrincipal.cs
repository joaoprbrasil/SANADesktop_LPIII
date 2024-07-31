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

        private void btnVisualizarEditar_Click(object sender, EventArgs e)
        {
            VisualizarEditar visualizarEditar = new VisualizarEditar();
            visualizarEditar.Show();
            this.Hide();
        }
    }
}
