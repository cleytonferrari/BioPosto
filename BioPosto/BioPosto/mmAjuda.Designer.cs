namespace BioPosto
{
    partial class mmAjuda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barraFerramentas = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.barraFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraFerramentas
            // 
            this.barraFerramentas.BackColor = System.Drawing.Color.White;
            this.barraFerramentas.BackgroundImage = global::BioPosto.Properties.Resources.bgOffice2;
            this.barraFerramentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barraFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.barraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraFerramentas.Name = "barraFerramentas";
            this.barraFerramentas.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.TabIndex = 4;
            this.barraFerramentas.TabStop = true;
            this.barraFerramentas.Text = "Menu";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::BioPosto.Properties.Resources.icone_ajuda;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 72);
            this.toolStripButton2.Text = "Ajuda";
            // 
            // mmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barraFerramentas);
            this.Name = "mmAjuda";
            this.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.ResumeLayout(false);
            this.barraFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraFerramentas;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
