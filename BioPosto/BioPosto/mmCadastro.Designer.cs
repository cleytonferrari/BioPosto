namespace BioPosto
{
    partial class mmCadastro
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.barraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraFerramentas.Name = "barraFerramentas";
            this.barraFerramentas.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.TabIndex = 3;
            this.barraFerramentas.TabStop = true;
            this.barraFerramentas.Text = "Menu";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::BioPosto.Properties.Resources.caixa;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 72);
            this.toolStripButton2.Text = "Venda de Combustivel";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BioPosto.Properties.Resources.digital;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 72);
            this.toolStripButton1.Text = "Cadastrar Impressão Digital";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::BioPosto.Properties.Resources.importar;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 72);
            this.toolStripButton3.Text = "Importar Dados";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::BioPosto.Properties.Resources.icone_relatorio;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(68, 72);
            this.toolStripButton4.Text = "Fechamento de Caixa";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // mmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barraFerramentas);
            this.Name = "mmCadastro";
            this.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.ResumeLayout(false);
            this.barraFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraFerramentas;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}
