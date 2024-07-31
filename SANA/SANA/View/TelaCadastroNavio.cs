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

namespace SANA
{
    public partial class TelaCadastroNavio : Form
    {
        private List<Navio> navios;

        public TelaCadastroNavio()
        {
            InitializeComponent();
        }

        public TelaCadastroNavio(List<Navio> navios)
        {
            InitializeComponent();
            this.navios = navios;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCaladoEntrada_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtAnoConstrucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();

            menuPrincipal.Show();

            this.Hide();


        }

        private void TelaCadastroNavio_Load(object sender, EventArgs e)
        {

        }

        private bool TodosCamposPreenchidos()
        {
            TextBox[] campos = new TextBox[]
            {
                txtNomeNavio,
                txtDwt,
                txtCaladoAereo,
                txtLoa,
                txtCaladoSaida,
                txtCaladoEntrada,
                txtBoca,
                txtPontal,
                txtTamanhoLanca,
                txtAnoConstrucao,
                txtTipoNavio
            };
            return campos.All(campo => !string.IsNullOrWhiteSpace(campo.Text));
        }

        private void btnVisualizarEditar_Click(object sender, EventArgs e)
        {

            if (TodosCamposPreenchidos())
            {
                try
                {
                    // Coleta e conversão dos dados
                    String nomeNavio = txtNomeNavio.Text;
                    double caladoAereo = Convert.ToDouble(txtCaladoAereo.Text);
                    double dWT = Convert.ToDouble(txtDwt.Text);
                    double lOA = Convert.ToDouble(txtLoa.Text);
                    double caladoSaida = Convert.ToDouble(txtCaladoSaida.Text);
                    double caladoEntrada = Convert.ToDouble(txtCaladoEntrada.Text);
                    double boca = Convert.ToDouble(txtBoca.Text);
                    double pontal = Convert.ToDouble(txtPontal.Text);
                    double tamanhoLanca = Convert.ToDouble(txtTamanhoLanca.Text);
                    double anoConstrucao = Convert.ToDouble(txtAnoConstrucao.Text);
                    String tipoNavio = txtTipoNavio.Text;
                    decimal salario = 100;
                    //decimal salario = Convert.ToDecimal(txtTipoNavio.Text);

                    Navio navio = new Navio(nomeNavio, caladoAereo, dWT, lOA, caladoSaida, caladoEntrada, boca, pontal, tamanhoLanca, anoConstrucao, tipoNavio, salario, "Em processo.");
                    navios.Add(navio);

                    MessageBox.Show("Navio cadastrado com sucesso.");
                    this.Close();

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Um ou mais campos contêm dados inválidos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
