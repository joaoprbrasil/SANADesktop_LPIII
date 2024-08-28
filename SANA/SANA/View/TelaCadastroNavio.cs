using SANA.Controllers;
using SANA.Model.Entities;
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

namespace SANA
{
    public partial class TelaCadastroNavio : Form
    {

        NavioController navioController = new NavioController();

        public TelaCadastroNavio()
        {
            InitializeComponent();
        }

        

        private void txtAnoConstrucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

            };
            return campos.All(campo => !string.IsNullOrWhiteSpace(campo.Text));
        }

        private void btnVisualizarEditar_Click(object sender, EventArgs e)
        {
            String tipoNavio = "null";
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    tipoNavio = radioButton.Text;
                    break; // Encontre o RadioButton selecionado e saia do loop
                }
            }

            if (TodosCamposPreenchidos() && !tipoNavio.Equals("null"))
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
                    int anoConstrucao = Convert.ToInt32(comboBox2.Text);

                    Navio navio = new Navio(nomeNavio, caladoAereo, dWT, lOA, caladoSaida, caladoEntrada, boca, pontal, tamanhoLanca, anoConstrucao, tipoNavio, "Em processo.");

                    navioController.inserirNavio(navio);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastroNavio_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
