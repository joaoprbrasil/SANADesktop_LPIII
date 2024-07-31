namespace SANA.View
{
    partial class VisualizarNavios
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
            dataGridView1 = new DataGridView();
            btnVisualizarEditar = new Button();
            btnEditar = new Button();
            label1 = new Label();
            btnExcluir = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.Disable;
            dataGridView1.Location = new Point(15, 70);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnVisualizarEditar
            // 
            btnVisualizarEditar.BackColor = SystemColors.Highlight;
            btnVisualizarEditar.ForeColor = SystemColors.ControlLightLight;
            btnVisualizarEditar.Location = new Point(15, 31);
            btnVisualizarEditar.Margin = new Padding(3, 2, 3, 2);
            btnVisualizarEditar.Name = "btnVisualizarEditar";
            btnVisualizarEditar.Size = new Size(153, 34);
            btnVisualizarEditar.TabIndex = 4;
            btnVisualizarEditar.Text = "Adicionar Navio";
            btnVisualizarEditar.UseVisualStyleBackColor = false;
            btnVisualizarEditar.Click += btnVisualizarEditar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Highlight;
            btnEditar.ForeColor = SystemColors.ControlLightLight;
            btnEditar.Location = new Point(174, 31);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 34);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar Navio";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(313, 222);
            label1.Name = "label1";
            label1.Size = new Size(310, 28);
            label1.TabIndex = 6;
            label1.Text = "Não há nenhum navio cadastrado.";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.Highlight;
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(333, 31);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(153, 34);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir Navio";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(810, 438);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 34);
            button1.TabIndex = 8;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // VisualizarNavios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 483);
            Controls.Add(button1);
            Controls.Add(btnExcluir);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnVisualizarEditar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VisualizarNavios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisualizarNavios";
            Load += VisualizarNavios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnVisualizarEditar;
        private Button btnEditar;
        private Label label1;
        private Button btnExcluir;
        private Button button1;
    }
}