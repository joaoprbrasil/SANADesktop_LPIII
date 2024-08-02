namespace SANA
{
    partial class EditarNavio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtAnoConstrucao = new TextBox();
            lblAnoConstrucao = new Label();
            txtDwt = new TextBox();
            lblDwt = new Label();
            txtTipoNavio = new TextBox();
            lblTipoNavio = new Label();
            txtTamanhoLanca = new TextBox();
            lblTamanhoLanca = new Label();
            txtPontal = new TextBox();
            lblPontal = new Label();
            txtCaladoSaida = new TextBox();
            lblCaladoSaida = new Label();
            txtCaladoAereo = new TextBox();
            lblCaladoAereo = new Label();
            txtCaladoEntrada = new TextBox();
            lblCaladoEntrada = new Label();
            txtBoca = new TextBox();
            lblBoca = new Label();
            txtLoa = new TextBox();
            lblLoa = new Label();
            txtNomeNavio = new TextBox();
            lblNomeNavio = new Label();
            lblCadastroNavio = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.Highlight;
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.Location = new Point(713, 424);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 34);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnVisualizarEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(573, 424);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtAnoConstrucao
            // 
            txtAnoConstrucao.Location = new Point(370, 357);
            txtAnoConstrucao.Margin = new Padding(3, 2, 3, 2);
            txtAnoConstrucao.MaxLength = 4;
            txtAnoConstrucao.Name = "txtAnoConstrucao";
            txtAnoConstrucao.Size = new Size(116, 23);
            txtAnoConstrucao.TabIndex = 37;
            // 
            // lblAnoConstrucao
            // 
            lblAnoConstrucao.AutoSize = true;
            lblAnoConstrucao.Location = new Point(370, 340);
            lblAnoConstrucao.Name = "lblAnoConstrucao";
            lblAnoConstrucao.Size = new Size(102, 15);
            lblAnoConstrucao.TabIndex = 44;
            lblAnoConstrucao.Text = "Ano de Costrução";
            // 
            // txtDwt
            // 
            txtDwt.Location = new Point(632, 173);
            txtDwt.Margin = new Padding(3, 2, 3, 2);
            txtDwt.Name = "txtDwt";
            txtDwt.Size = new Size(110, 23);
            txtDwt.TabIndex = 26;
            // 
            // lblDwt
            // 
            lblDwt.AutoSize = true;
            lblDwt.Location = new Point(634, 156);
            lblDwt.Name = "lblDwt";
            lblDwt.Size = new Size(32, 15);
            lblDwt.TabIndex = 43;
            lblDwt.Text = "DWT";
            // 
            // txtTipoNavio
            // 
            txtTipoNavio.Location = new Point(511, 357);
            txtTipoNavio.Margin = new Padding(3, 2, 3, 2);
            txtTipoNavio.Name = "txtTipoNavio";
            txtTipoNavio.Size = new Size(110, 23);
            txtTipoNavio.TabIndex = 38;
            // 
            // lblTipoNavio
            // 
            lblTipoNavio.AutoSize = true;
            lblTipoNavio.Location = new Point(511, 340);
            lblTipoNavio.Name = "lblTipoNavio";
            lblTipoNavio.Size = new Size(64, 15);
            lblTipoNavio.TabIndex = 42;
            lblTipoNavio.Text = "Tipo Navio";
            // 
            // txtTamanhoLanca
            // 
            txtTamanhoLanca.Location = new Point(189, 357);
            txtTamanhoLanca.Margin = new Padding(3, 2, 3, 2);
            txtTamanhoLanca.Name = "txtTamanhoLanca";
            txtTamanhoLanca.Size = new Size(153, 23);
            txtTamanhoLanca.TabIndex = 35;
            // 
            // lblTamanhoLanca
            // 
            lblTamanhoLanca.AutoSize = true;
            lblTamanhoLanca.Location = new Point(191, 340);
            lblTamanhoLanca.Name = "lblTamanhoLanca";
            lblTamanhoLanca.Size = new Size(138, 15);
            lblTamanhoLanca.TabIndex = 41;
            lblTamanhoLanca.Text = "Tamanho Lança (metros)";
            // 
            // txtPontal
            // 
            txtPontal.Location = new Point(335, 291);
            txtPontal.Margin = new Padding(3, 2, 3, 2);
            txtPontal.Name = "txtPontal";
            txtPontal.Size = new Size(110, 23);
            txtPontal.TabIndex = 34;
            // 
            // lblPontal
            // 
            lblPontal.AutoSize = true;
            lblPontal.Location = new Point(335, 274);
            lblPontal.Name = "lblPontal";
            lblPontal.Size = new Size(89, 15);
            lblPontal.TabIndex = 40;
            lblPontal.Text = "Pontal (metros)";
            // 
            // txtCaladoSaida
            // 
            txtCaladoSaida.Location = new Point(355, 223);
            txtCaladoSaida.Margin = new Padding(3, 2, 3, 2);
            txtCaladoSaida.Name = "txtCaladoSaida";
            txtCaladoSaida.Size = new Size(138, 23);
            txtCaladoSaida.TabIndex = 30;
            // 
            // lblCaladoSaida
            // 
            lblCaladoSaida.AutoSize = true;
            lblCaladoSaida.Location = new Point(355, 206);
            lblCaladoSaida.Name = "lblCaladoSaida";
            lblCaladoSaida.Size = new Size(123, 15);
            lblCaladoSaida.TabIndex = 39;
            lblCaladoSaida.Text = "Calado Saida (metros)";
            // 
            // txtCaladoAereo
            // 
            txtCaladoAereo.Location = new Point(425, 173);
            txtCaladoAereo.Margin = new Padding(3, 2, 3, 2);
            txtCaladoAereo.Name = "txtCaladoAereo";
            txtCaladoAereo.Size = new Size(160, 23);
            txtCaladoAereo.TabIndex = 25;
            // 
            // lblCaladoAereo
            // 
            lblCaladoAereo.AutoSize = true;
            lblCaladoAereo.Location = new Point(425, 156);
            lblCaladoAereo.Name = "lblCaladoAereo";
            lblCaladoAereo.Size = new Size(126, 15);
            lblCaladoAereo.TabIndex = 36;
            lblCaladoAereo.Text = "Calado Aéreo (metros)";
            // 
            // txtCaladoEntrada
            // 
            txtCaladoEntrada.Location = new Point(531, 223);
            txtCaladoEntrada.Margin = new Padding(3, 2, 3, 2);
            txtCaladoEntrada.Name = "txtCaladoEntrada";
            txtCaladoEntrada.Size = new Size(174, 23);
            txtCaladoEntrada.TabIndex = 31;
            // 
            // lblCaladoEntrada
            // 
            lblCaladoEntrada.AutoSize = true;
            lblCaladoEntrada.Location = new Point(530, 206);
            lblCaladoEntrada.Name = "lblCaladoEntrada";
            lblCaladoEntrada.Size = new Size(151, 15);
            lblCaladoEntrada.TabIndex = 33;
            lblCaladoEntrada.Text = "Calado de Entrada (metros)";
            // 
            // txtBoca
            // 
            txtBoca.Location = new Point(189, 291);
            txtBoca.Margin = new Padding(3, 2, 3, 2);
            txtBoca.Name = "txtBoca";
            txtBoca.Size = new Size(110, 23);
            txtBoca.TabIndex = 32;
            // 
            // lblBoca
            // 
            lblBoca.AutoSize = true;
            lblBoca.Location = new Point(189, 274);
            lblBoca.Name = "lblBoca";
            lblBoca.Size = new Size(81, 15);
            lblBoca.TabIndex = 29;
            lblBoca.Text = "Boca (metros)";
            // 
            // txtLoa
            // 
            txtLoa.Location = new Point(189, 223);
            txtLoa.Margin = new Padding(3, 2, 3, 2);
            txtLoa.Name = "txtLoa";
            txtLoa.Size = new Size(110, 23);
            txtLoa.TabIndex = 28;
            // 
            // lblLoa
            // 
            lblLoa.AutoSize = true;
            lblLoa.Location = new Point(189, 206);
            lblLoa.Name = "lblLoa";
            lblLoa.Size = new Size(74, 15);
            lblLoa.TabIndex = 27;
            lblLoa.Text = "Loa (metros)";
            // 
            // txtNomeNavio
            // 
            txtNomeNavio.Location = new Point(189, 173);
            txtNomeNavio.Margin = new Padding(3, 2, 3, 2);
            txtNomeNavio.Name = "txtNomeNavio";
            txtNomeNavio.Size = new Size(189, 23);
            txtNomeNavio.TabIndex = 23;
            // 
            // lblNomeNavio
            // 
            lblNomeNavio.AutoSize = true;
            lblNomeNavio.Location = new Point(189, 156);
            lblNomeNavio.Name = "lblNomeNavio";
            lblNomeNavio.Size = new Size(91, 15);
            lblNomeNavio.TabIndex = 24;
            lblNomeNavio.Text = "Nome do Navio";
            // 
            // lblCadastroNavio
            // 
            lblCadastroNavio.AutoSize = true;
            lblCadastroNavio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastroNavio.Location = new Point(189, 108);
            lblCadastroNavio.Name = "lblCadastroNavio";
            lblCadastroNavio.Size = new Size(143, 32);
            lblCadastroNavio.TabIndex = 22;
            lblCadastroNavio.Text = "Editar Navio";
            // 
            // EditarNavio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 550);
            Controls.Add(txtAnoConstrucao);
            Controls.Add(lblAnoConstrucao);
            Controls.Add(txtDwt);
            Controls.Add(lblDwt);
            Controls.Add(txtTipoNavio);
            Controls.Add(lblTipoNavio);
            Controls.Add(txtTamanhoLanca);
            Controls.Add(lblTamanhoLanca);
            Controls.Add(txtPontal);
            Controls.Add(lblPontal);
            Controls.Add(txtCaladoSaida);
            Controls.Add(lblCaladoSaida);
            Controls.Add(txtCaladoAereo);
            Controls.Add(lblCaladoAereo);
            Controls.Add(txtCaladoEntrada);
            Controls.Add(lblCaladoEntrada);
            Controls.Add(txtBoca);
            Controls.Add(lblBoca);
            Controls.Add(txtLoa);
            Controls.Add(lblLoa);
            Controls.Add(txtNomeNavio);
            Controls.Add(lblNomeNavio);
            Controls.Add(lblCadastroNavio);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarNavio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarNavio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtAnoConstrucao;
        private Label lblAnoConstrucao;
        private TextBox txtDwt;
        private Label lblDwt;
        private TextBox txtTipoNavio;
        private Label lblTipoNavio;
        private TextBox txtTamanhoLanca;
        private Label lblTamanhoLanca;
        private TextBox txtPontal;
        private Label lblPontal;
        private TextBox txtCaladoSaida;
        private Label lblCaladoSaida;
        private TextBox txtCaladoAereo;
        private Label lblCaladoAereo;
        private TextBox txtCaladoEntrada;
        private Label lblCaladoEntrada;
        private TextBox txtBoca;
        private Label lblBoca;
        private TextBox txtLoa;
        private Label lblLoa;
        private TextBox txtNomeNavio;
        private Label lblNomeNavio;
        private Label lblCadastroNavio;
    }
}