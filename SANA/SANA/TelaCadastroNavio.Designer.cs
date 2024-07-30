namespace SANA
{
    partial class TelaCadastroNavio
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
            lblCadastroNavio = new Label();
            lblNomeNavio = new Label();
            txtNomeNavio = new TextBox();
            txtLoa = new TextBox();
            lblLoa = new Label();
            txtBoca = new TextBox();
            lblBoca = new Label();
            txtCaladoEntrada = new TextBox();
            lblCaladoEntrada = new Label();
            txtCaladoAereo = new TextBox();
            lblCaladoAereo = new Label();
            txtCaladoSaida = new TextBox();
            lblCaladoSaida = new Label();
            txtPontal = new TextBox();
            lblPontal = new Label();
            txtTamanhoLanca = new TextBox();
            lblTamanhoLanca = new Label();
            txtTipoNavio = new TextBox();
            lblTipoNavio = new Label();
            txtDwt = new TextBox();
            lblDwt = new Label();
            txtAnoConstrucao = new TextBox();
            lblAnoConstrucao = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadastroNavio
            // 
            lblCadastroNavio.AutoSize = true;
            lblCadastroNavio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastroNavio.Location = new Point(22, 20);
            lblCadastroNavio.Name = "lblCadastroNavio";
            lblCadastroNavio.Size = new Size(262, 41);
            lblCadastroNavio.TabIndex = 0;
            lblCadastroNavio.Text = "Cadastro de Navio";
            // 
            // lblNomeNavio
            // 
            lblNomeNavio.AutoSize = true;
            lblNomeNavio.Location = new Point(22, 119);
            lblNomeNavio.Name = "lblNomeNavio";
            lblNomeNavio.Size = new Size(115, 20);
            lblNomeNavio.TabIndex = 1;
            lblNomeNavio.Text = "Nome do Navio";
            lblNomeNavio.Click += label1_Click;
            // 
            // txtNomeNavio
            // 
            txtNomeNavio.Location = new Point(22, 142);
            txtNomeNavio.Name = "txtNomeNavio";
            txtNomeNavio.Size = new Size(215, 27);
            txtNomeNavio.TabIndex = 2;
            // 
            // txtLoa
            // 
            txtLoa.Location = new Point(22, 208);
            txtLoa.Name = "txtLoa";
            txtLoa.Size = new Size(125, 27);
            txtLoa.TabIndex = 4;
            txtLoa.TextChanged += textBox2_TextChanged;
            // 
            // lblLoa
            // 
            lblLoa.AutoSize = true;
            lblLoa.Location = new Point(22, 185);
            lblLoa.Name = "lblLoa";
            lblLoa.Size = new Size(93, 20);
            lblLoa.TabIndex = 3;
            lblLoa.Text = "Loa (metros)";
            // 
            // txtBoca
            // 
            txtBoca.Location = new Point(22, 299);
            txtBoca.Name = "txtBoca";
            txtBoca.Size = new Size(125, 27);
            txtBoca.TabIndex = 6;
            txtBoca.TextChanged += textBox3_TextChanged;
            // 
            // lblBoca
            // 
            lblBoca.AutoSize = true;
            lblBoca.Location = new Point(22, 276);
            lblBoca.Name = "lblBoca";
            lblBoca.Size = new Size(102, 20);
            lblBoca.TabIndex = 5;
            lblBoca.Text = "Boca (metros)";
            lblBoca.Click += label3_Click;
            // 
            // txtCaladoEntrada
            // 
            txtCaladoEntrada.Location = new Point(413, 208);
            txtCaladoEntrada.Name = "txtCaladoEntrada";
            txtCaladoEntrada.Size = new Size(198, 27);
            txtCaladoEntrada.TabIndex = 8;
            // 
            // lblCaladoEntrada
            // 
            lblCaladoEntrada.AutoSize = true;
            lblCaladoEntrada.Location = new Point(412, 185);
            lblCaladoEntrada.Name = "lblCaladoEntrada";
            lblCaladoEntrada.Size = new Size(192, 20);
            lblCaladoEntrada.TabIndex = 7;
            lblCaladoEntrada.Text = "Calado de Entrada (metros)";
            lblCaladoEntrada.Click += lblCaladoEntrada_Click;
            // 
            // txtCaladoAereo
            // 
            txtCaladoAereo.Location = new Point(291, 142);
            txtCaladoAereo.Name = "txtCaladoAereo";
            txtCaladoAereo.Size = new Size(182, 27);
            txtCaladoAereo.TabIndex = 10;
            // 
            // lblCaladoAereo
            // 
            lblCaladoAereo.AutoSize = true;
            lblCaladoAereo.Location = new Point(291, 119);
            lblCaladoAereo.Name = "lblCaladoAereo";
            lblCaladoAereo.Size = new Size(160, 20);
            lblCaladoAereo.TabIndex = 9;
            lblCaladoAereo.Text = "Calado Aéreo (metros)";
            // 
            // txtCaladoSaida
            // 
            txtCaladoSaida.Location = new Point(211, 208);
            txtCaladoSaida.Name = "txtCaladoSaida";
            txtCaladoSaida.Size = new Size(157, 27);
            txtCaladoSaida.TabIndex = 12;
            // 
            // lblCaladoSaida
            // 
            lblCaladoSaida.AutoSize = true;
            lblCaladoSaida.Location = new Point(211, 185);
            lblCaladoSaida.Name = "lblCaladoSaida";
            lblCaladoSaida.Size = new Size(157, 20);
            lblCaladoSaida.TabIndex = 11;
            lblCaladoSaida.Text = "Calado Saida (metros)";
            // 
            // txtPontal
            // 
            txtPontal.Location = new Point(189, 299);
            txtPontal.Name = "txtPontal";
            txtPontal.Size = new Size(125, 27);
            txtPontal.TabIndex = 14;
            txtPontal.TextChanged += textBox2_TextChanged_1;
            // 
            // lblPontal
            // 
            lblPontal.AutoSize = true;
            lblPontal.Location = new Point(189, 276);
            lblPontal.Name = "lblPontal";
            lblPontal.Size = new Size(110, 20);
            lblPontal.TabIndex = 13;
            lblPontal.Text = "Pontal (metros)";
            lblPontal.Click += label2_Click;
            // 
            // txtTamanhoLanca
            // 
            txtTamanhoLanca.Location = new Point(22, 387);
            txtTamanhoLanca.Name = "txtTamanhoLanca";
            txtTamanhoLanca.Size = new Size(174, 27);
            txtTamanhoLanca.TabIndex = 16;
            // 
            // lblTamanhoLanca
            // 
            lblTamanhoLanca.AutoSize = true;
            lblTamanhoLanca.Location = new Point(24, 364);
            lblTamanhoLanca.Name = "lblTamanhoLanca";
            lblTamanhoLanca.Size = new Size(171, 20);
            lblTamanhoLanca.TabIndex = 15;
            lblTamanhoLanca.Text = "Tamanho Lança (metros)";
            // 
            // txtTipoNavio
            // 
            txtTipoNavio.Location = new Point(390, 387);
            txtTipoNavio.Name = "txtTipoNavio";
            txtTipoNavio.Size = new Size(125, 27);
            txtTipoNavio.TabIndex = 18;
            // 
            // lblTipoNavio
            // 
            lblTipoNavio.AutoSize = true;
            lblTipoNavio.Location = new Point(390, 364);
            lblTipoNavio.Name = "lblTipoNavio";
            lblTipoNavio.Size = new Size(82, 20);
            lblTipoNavio.TabIndex = 17;
            lblTipoNavio.Text = "Tipo Navio";
            // 
            // txtDwt
            // 
            txtDwt.Location = new Point(528, 142);
            txtDwt.Name = "txtDwt";
            txtDwt.Size = new Size(125, 27);
            txtDwt.TabIndex = 20;
            txtDwt.TextChanged += textBox2_TextChanged_2;
            // 
            // lblDwt
            // 
            lblDwt.AutoSize = true;
            lblDwt.Location = new Point(530, 119);
            lblDwt.Name = "lblDwt";
            lblDwt.Size = new Size(42, 20);
            lblDwt.TabIndex = 19;
            lblDwt.Text = "DWT";
            // 
            // txtAnoConstrucao
            // 
            txtAnoConstrucao.Location = new Point(229, 387);
            txtAnoConstrucao.MaxLength = 4;
            txtAnoConstrucao.Name = "txtAnoConstrucao";
            txtAnoConstrucao.Size = new Size(132, 27);
            txtAnoConstrucao.TabIndex = 22;
            txtAnoConstrucao.KeyPress += txtAnoConstrucao_KeyPress;
            // 
            // lblAnoConstrucao
            // 
            lblAnoConstrucao.AutoSize = true;
            lblAnoConstrucao.Location = new Point(229, 364);
            lblAnoConstrucao.Name = "lblAnoConstrucao";
            lblAnoConstrucao.Size = new Size(127, 20);
            lblAnoConstrucao.TabIndex = 21;
            lblAnoConstrucao.Text = "Ano de Costrução";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1054, 28);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // TelaCadastroNavio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 547);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaCadastroNavio";
            Text = "TelaCadastroNavio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroNavio;
        private Label lblNomeNavio;
        private TextBox txtNomeNavio;
        private TextBox txtLoa;
        private Label lblLoa;
        private TextBox txtBoca;
        private Label lblBoca;
        private TextBox txtCaladoEntrada;
        private Label lblCaladoEntrada;
        private TextBox txtCaladoAereo;
        private Label lblCaladoAereo;
        private TextBox txtCaladoSaida;
        private Label lblCaladoSaida;
        private TextBox txtPontal;
        private Label lblPontal;
        private TextBox txtTamanhoLanca;
        private Label lblTamanhoLanca;
        private TextBox txtTipoNavio;
        private Label lblTipoNavio;
        private TextBox txtDwt;
        private Label lblDwt;
        private TextBox txtAnoConstrucao;
        private Label lblAnoConstrucao;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}