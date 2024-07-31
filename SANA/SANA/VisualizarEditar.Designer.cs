namespace SANA
{
    partial class VisualizarEditar
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
            ltvVisualizarEmbarcações = new ListView();
            SuspendLayout();
            // 
            // ltvVisualizarEmbarcações
            // 
            ltvVisualizarEmbarcações.Location = new Point(105, 110);
            ltvVisualizarEmbarcações.Name = "ltvVisualizarEmbarcações";
            ltvVisualizarEmbarcações.Size = new Size(532, 242);
            ltvVisualizarEmbarcações.TabIndex = 0;
            ltvVisualizarEmbarcações.UseCompatibleStateImageBehavior = false;
            ltvVisualizarEmbarcações.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // VisualizarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ltvVisualizarEmbarcações);
            Name = "VisualizarEditar";
            Text = "VisualizarEditar";
            ResumeLayout(false);
        }

        #endregion

        private ListView ltvVisualizarEmbarcações;
    }
}