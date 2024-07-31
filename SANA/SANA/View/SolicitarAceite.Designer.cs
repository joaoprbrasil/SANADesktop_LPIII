namespace SANA
{
    partial class SolicitarAceite
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
            btnVisualizarEditar = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            DatadeCadastro = new DataGridViewTextBoxColumn();
            Situação = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVisualizarEditar
            // 
            btnVisualizarEditar.BackColor = SystemColors.Highlight;
            btnVisualizarEditar.ForeColor = SystemColors.ControlLightLight;
            btnVisualizarEditar.Location = new Point(230, 405);
            btnVisualizarEditar.Margin = new Padding(3, 2, 3, 2);
            btnVisualizarEditar.Name = "btnVisualizarEditar";
            btnVisualizarEditar.Size = new Size(211, 34);
            btnVisualizarEditar.TabIndex = 3;
            btnVisualizarEditar.Text = "Cadastrar Navio";
            btnVisualizarEditar.UseVisualStyleBackColor = false;
            btnVisualizarEditar.Click += btnVisualizarEditar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(453, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, DatadeCadastro, Situação });
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(429, 373);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Navio";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // DatadeCadastro
            // 
            DatadeCadastro.HeaderText = "Data de Cadastro";
            DatadeCadastro.Name = "DatadeCadastro";
            DatadeCadastro.ReadOnly = true;
            DatadeCadastro.Width = 150;
            // 
            // Situação
            // 
            Situação.HeaderText = "Situação";
            Situação.Name = "Situação";
            Situação.ReadOnly = true;
            Situação.Width = 135;
            // 
            // SolicitarAceite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 448);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(btnVisualizarEditar);
            Name = "SolicitarAceite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolicitarAceite";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVisualizarEditar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DatadeCadastro;
        private DataGridViewTextBoxColumn Situação;
    }
}