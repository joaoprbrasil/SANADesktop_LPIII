﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SANA.classesSana;


namespace SANA
{
    public partial class TelaCadastroNavio : Form
    {
        public TelaCadastroNavio()
        {
            InitializeComponent();
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

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            pnlInfromacoesEmbarcao.Visible = true;
            Embarcacao embarcacao = new Embarcacao
            {
                Nome = txtNomeNavio.Text,
                TamanhoLanca = Convert.ToDouble(txtTamanhoLanca.Text),
                Boca = Convert.ToDouble(txtBoca.Text),
                Loa = Convert.ToDouble(txtLoa.Text),
                AnoConstrucao = Convert.ToInt32(txtAnoConstrucao.Text),
                CaladoAereo = Convert.ToDouble(txtCaladoAereo.Text),
                CaladoEntrada = Convert.ToDouble(txtCaladoEntrada.Text),
                CaladoSaida = Convert.ToDouble(txtCaladoSaida.Text),
                TipoEmbarcacao = txtTipoNavio.Text,
                Dwt = txtDwt.Text,
                Pontal = Convert.ToDouble(txtPontal.Text)
            };




            lblInformcoesEmbarcacao.Text = embarcacao.ToString();

            MessageBox.Show("Enviado com sucesso");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            pnlInfromacoesEmbarcao.Visible = true;
            Embarcacao embarcacao = new Embarcacao
            {
                Nome = txtNomeNavio.Text,
                TamanhoLanca = Convert.ToDouble(txtTamanhoLanca.Text),
                Boca = Convert.ToDouble(txtBoca.Text),
                Loa = Convert.ToDouble(txtLoa.Text),
                AnoConstrucao = Convert.ToInt32(txtAnoConstrucao.Text),
                CaladoAereo = Convert.ToDouble(txtCaladoAereo.Text),
                CaladoEntrada = Convert.ToDouble(txtCaladoEntrada.Text),
                CaladoSaida = Convert.ToDouble(txtCaladoSaida.Text),
                TipoEmbarcacao = txtTipoNavio.Text,
                Dwt = txtDwt.Text,
                Pontal = Convert.ToDouble(txtPontal.Text)
            };




            lblInformcoesEmbarcacao.Text = embarcacao.ToString();

            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult resultMessageBox =  MessageBox.Show("Enviado com sucesso");
            if (resultMessageBox == DialogResult.OK)
            {
                pnlInfromacoesEmbarcao.Visible = false;
            }

        }
    }
}
