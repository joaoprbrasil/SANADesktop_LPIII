﻿using SANA.Controllers;
using SANA.Model.DAO;
using SANA.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANA
{
    public partial class EditarNavio : Form
    {
        private Navio navio;
        NavioController navioController = new NavioController();

        public EditarNavio(Navio navio)
        {
            InitializeComponent();
            this.navio = navio;
            txtNomeNavio.Text = navio.NomeNavio;
            txtDwt.Text = Convert.ToString(navio.DWT);
            txtCaladoAereo.Text = Convert.ToString(navio.CaladoAereo);
            txtLoa.Text = Convert.ToString(navio.Loa);
            txtCaladoSaida.Text = Convert.ToString(navio.CaladoSaida);
            txtCaladoEntrada.Text = Convert.ToString(navio.CaladoEntrada);
            txtBoca.Text = Convert.ToString(navio.Boca);
            txtPontal.Text = Convert.ToString(navio.Pontal);
            txtTamanhoLanca.Text = Convert.ToString(navio.Lanca);
            txtAnoConstrucao.Text = Convert.ToString(navio.AnoConstrucao);
            txtTipoNavio.Text = navio.Tipo;
        }



        public EditarNavio(List<Navio> navios, Navio navio, int index)
        {
            InitializeComponent();


            this.navio = navio;
            txtNomeNavio.Text = navio.NomeNavio;
            txtDwt.Text = Convert.ToString(navio.DWT);
            txtCaladoAereo.Text = Convert.ToString(navio.CaladoAereo);
            txtLoa.Text = Convert.ToString(navio.Loa);
            txtCaladoSaida.Text = Convert.ToString(navio.CaladoSaida);
            txtCaladoEntrada.Text = Convert.ToString(navio.CaladoEntrada);
            txtBoca.Text = Convert.ToString(navio.Boca);
            txtPontal.Text = Convert.ToString(navio.Pontal);
            txtTamanhoLanca.Text = Convert.ToString(navio.Lanca);
            txtAnoConstrucao.Text = Convert.ToString(navio.AnoConstrucao);
            txtTipoNavio.Text = navio.Tipo;
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
                    int anoConstrucao = Convert.ToInt32(txtAnoConstrucao.Text);
                    String tipoNavio = txtTipoNavio.Text;

                    Navio navio = new Navio(this.navio.id, nomeNavio, caladoAereo, dWT, lOA, caladoSaida, caladoEntrada, boca, pontal, tamanhoLanca, anoConstrucao, tipoNavio, "Em processo.");

                    navioController.editarNavio(navio);

                    MessageBox.Show("Navio atualizado com sucesso.");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDwt_Click(object sender, EventArgs e)
        {

        }

        private void EditarNavio_Load(object sender, EventArgs e)
        {

        }

        private void lblCaladoEntrada_Click(object sender, EventArgs e)
        {

        }
    }
}
