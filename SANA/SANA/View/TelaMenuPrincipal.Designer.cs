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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarNavioToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNavioToolStripMenuItem1 = new ToolStripMenuItem();
            visualizarEditarToolStripMenuItem1 = new ToolStripMenuItem();
            solicitaçõesToolStripMenuItem = new ToolStripMenuItem();
            visualizarEditarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem1, cadastrarNavioToolStripMenuItem, solicitaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(38, 20);
            menuToolStripMenuItem1.Text = "Sair";
            menuToolStripMenuItem1.Click += menuToolStripMenuItem1_Click;
            // 
            // cadastrarNavioToolStripMenuItem
            // 
            cadastrarNavioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNavioToolStripMenuItem1, visualizarEditarToolStripMenuItem1 });
            cadastrarNavioToolStripMenuItem.Name = "cadastrarNavioToolStripMenuItem";
            cadastrarNavioToolStripMenuItem.Size = new Size(55, 20);
            cadastrarNavioToolStripMenuItem.Text = "Navios";
            // 
            // cadastrarNavioToolStripMenuItem1
            // 
            cadastrarNavioToolStripMenuItem1.Name = "cadastrarNavioToolStripMenuItem1";
            cadastrarNavioToolStripMenuItem1.Size = new Size(158, 22);
            cadastrarNavioToolStripMenuItem1.Text = "Cadastrar Navio";
            cadastrarNavioToolStripMenuItem1.Click += cadastrarNavioToolStripMenuItem1_Click;
            // 
            // visualizarEditarToolStripMenuItem1
            // 
            visualizarEditarToolStripMenuItem1.Name = "visualizarEditarToolStripMenuItem1";
            visualizarEditarToolStripMenuItem1.Size = new Size(158, 22);
            visualizarEditarToolStripMenuItem1.Text = "Visualizar/Editar";
            visualizarEditarToolStripMenuItem1.Click += visualizarEditarToolStripMenuItem1_Click;
            // 
            // solicitaçõesToolStripMenuItem
            // 
            solicitaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarEditarToolStripMenuItem });
            solicitaçõesToolStripMenuItem.Name = "solicitaçõesToolStripMenuItem";
            solicitaçõesToolStripMenuItem.Size = new Size(81, 20);
            solicitaçõesToolStripMenuItem.Text = "Solicitações";
            solicitaçõesToolStripMenuItem.Click += solicitaçõesToolStripMenuItem_Click;
            // 
            // visualizarEditarToolStripMenuItem
            // 
            visualizarEditarToolStripMenuItem.Name = "visualizarEditarToolStripMenuItem";
            visualizarEditarToolStripMenuItem.Size = new Size(189, 22);
            visualizarEditarToolStripMenuItem.Text = "Gerenciar Solicitações";
            visualizarEditarToolStripMenuItem.Click += visualizarEditarToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1000, 800);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarNavioToolStripMenuItem;
        private ToolStripMenuItem solicitaçõesToolStripMenuItem;
        private ToolStripMenuItem visualizarEditarToolStripMenuItem;
        private ToolStripMenuItem cadastrarNavioToolStripMenuItem1;
        private ToolStripMenuItem visualizarEditarToolStripMenuItem1;
        private ToolStripMenuItem menuToolStripMenuItem1;
    }
}