namespace SANA
{
    partial class MenuPrincipal
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
            label1 = new Label();
            btnCadastroNavios = new Button();
            btnVisualizarEditar = new Button();
            btnHistoricoAceite = new Button();
            btnSolicitarAceite = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            editarSenhaDeAcessoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            checkedListBox1 = new CheckedListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 98);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            label1.Click += label1_Click;
            // 
            // btnCadastroNavios
            // 
            btnCadastroNavios.BackColor = SystemColors.Highlight;
            btnCadastroNavios.ForeColor = SystemColors.ControlLightLight;
            btnCadastroNavios.Location = new Point(171, 235);
            btnCadastroNavios.Name = "btnCadastroNavios";
            btnCadastroNavios.Size = new Size(231, 116);
            btnCadastroNavios.TabIndex = 1;
            btnCadastroNavios.Text = "Cadastro de Navios";
            btnCadastroNavios.UseVisualStyleBackColor = false;
            btnCadastroNavios.Click += btnCadastroNavios_Click;
            // 
            // btnVisualizarEditar
            // 
            btnVisualizarEditar.BackColor = SystemColors.Highlight;
            btnVisualizarEditar.ForeColor = SystemColors.ControlLightLight;
            btnVisualizarEditar.Location = new Point(492, 235);
            btnVisualizarEditar.Name = "btnVisualizarEditar";
            btnVisualizarEditar.Size = new Size(231, 116);
            btnVisualizarEditar.TabIndex = 2;
            btnVisualizarEditar.Text = "Visualizar/Editar";
            btnVisualizarEditar.UseVisualStyleBackColor = false;
            btnVisualizarEditar.Click += btnVisualizarEditar_Click;
            // 
            // btnHistoricoAceite
            // 
            btnHistoricoAceite.BackColor = SystemColors.Highlight;
            btnHistoricoAceite.ForeColor = SystemColors.ControlLightLight;
            btnHistoricoAceite.Location = new Point(171, 393);
            btnHistoricoAceite.Name = "btnHistoricoAceite";
            btnHistoricoAceite.Size = new Size(231, 116);
            btnHistoricoAceite.TabIndex = 3;
            btnHistoricoAceite.Text = "Historico de Aceite";
            btnHistoricoAceite.UseVisualStyleBackColor = false;
            // 
            // btnSolicitarAceite
            // 
            btnSolicitarAceite.BackColor = SystemColors.Highlight;
            btnSolicitarAceite.ForeColor = SystemColors.ControlLightLight;
            btnSolicitarAceite.Location = new Point(492, 393);
            btnSolicitarAceite.Name = "btnSolicitarAceite";
            btnSolicitarAceite.Size = new Size(231, 116);
            btnSolicitarAceite.TabIndex = 4;
            btnSolicitarAceite.Text = "Solicitar Aceite";
            btnSolicitarAceite.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarSenhaDeAcessoToolStripMenuItem, sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // editarSenhaDeAcessoToolStripMenuItem
            // 
            editarSenhaDeAcessoToolStripMenuItem.Name = "editarSenhaDeAcessoToolStripMenuItem";
            editarSenhaDeAcessoToolStripMenuItem.Size = new Size(242, 26);
            editarSenhaDeAcessoToolStripMenuItem.Text = "Editar senha de acesso";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(242, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(899, 398);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(checkedListBox1);
            Controls.Add(btnSolicitarAceite);
            Controls.Add(btnHistoricoAceite);
            Controls.Add(btnVisualizarEditar);
            Controls.Add(btnCadastroNavios);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastroNavios;
        private Button btnVisualizarEditar;
        private Button btnHistoricoAceite;
        private Button btnSolicitarAceite;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem editarSenhaDeAcessoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private CheckedListBox checkedListBox1;
    }
}