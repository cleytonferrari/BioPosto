namespace BioPosto
{
    partial class frmImportarDados
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
            this.components = new System.ComponentModel.Container();
            this.totToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCaminho = new System.Windows.Forms.Button();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCampos = new System.Windows.Forms.GroupBox();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.grpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnGravar.Image = global::BioPosto.Properties.Resources.Good2;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(220, 187);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 38);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "    Importar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCaminho
            // 
            this.btnCaminho.Location = new System.Drawing.Point(412, 89);
            this.btnCaminho.Name = "btnCaminho";
            this.btnCaminho.Size = new System.Drawing.Size(27, 23);
            this.btnCaminho.TabIndex = 0;
            this.btnCaminho.Text = "...";
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click);
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // grpCampos
            // 
            this.grpCampos.BackColor = System.Drawing.Color.Transparent;
            this.grpCampos.Controls.Add(this.btnCaminho);
            this.grpCampos.Controls.Add(this.pbar);
            this.grpCampos.Controls.Add(this.lblCaminho);
            this.grpCampos.Location = new System.Drawing.Point(11, 54);
            this.grpCampos.Name = "grpCampos";
            this.grpCampos.Size = new System.Drawing.Size(445, 118);
            this.grpCampos.TabIndex = 19;
            this.grpCampos.TabStop = false;
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(9, 45);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(430, 23);
            this.pbar.TabIndex = 1;
            // 
            // lblCaminho
            // 
            this.lblCaminho.Location = new System.Drawing.Point(11, 95);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(396, 13);
            this.lblCaminho.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Importar Dados";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnSair.Image = global::BioPosto.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(341, 187);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 38);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "     Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BioPosto.Properties.Resources.importar;
            this.pictureBox1.Location = new System.Drawing.Point(418, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmImportarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::BioPosto.Properties.Resources.bg_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(466, 229);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpCampos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportarDados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Dados";
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.grpCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip totToolTip;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCaminho;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.GroupBox grpCampos;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}