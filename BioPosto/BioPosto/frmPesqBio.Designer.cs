namespace BioPosto
{
    partial class frmPesqBio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesqBio));
            this.lbLog = new System.Windows.Forms.ListBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.axGrFingerXCtrl1 = new AxGrFingerXLib.AxGrFingerXCtrl();
            this.label2 = new System.Windows.Forms.Label();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt03 = new System.Windows.Forms.TextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl05 = new System.Windows.Forms.Label();
            this.txt04 = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.lbLog.Location = new System.Drawing.Point(14, 335);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.Size = new System.Drawing.Size(682, 82);
            this.lbLog.TabIndex = 4;
            this.lbLog.TabStop = false;
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImg.Image = global::BioPosto.Properties.Resources.bioMicrosoft;
            this.pbImg.Location = new System.Drawing.Point(14, 54);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(270, 270);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 26;
            this.pbImg.TabStop = false;
            // 
            // axGrFingerXCtrl1
            // 
            this.axGrFingerXCtrl1.Enabled = true;
            this.axGrFingerXCtrl1.Location = new System.Drawing.Point(665, 46);
            this.axGrFingerXCtrl1.Name = "axGrFingerXCtrl1";
            this.axGrFingerXCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrFingerXCtrl1.OcxState")));
            this.axGrFingerXCtrl1.Size = new System.Drawing.Size(32, 32);
            this.axGrFingerXCtrl1.TabIndex = 28;
            this.axGrFingerXCtrl1.SensorPlug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEventHandler(this.axGrFingerXCtrl1_SensorPlug);
            this.axGrFingerXCtrl1.SensorUnplug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEventHandler(this.axGrFingerXCtrl1_SensorUnplug);
            this.axGrFingerXCtrl1.ImageAcquired += new AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEventHandler(this.axGrFingerXCtrl1_ImageAcquired);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(372, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "02.Nome do Cliente";
            // 
            // txt02
            // 
            this.txt02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.txt02.Location = new System.Drawing.Point(374, 71);
            this.txt02.Name = "txt02";
            this.txt02.ReadOnly = true;
            this.txt02.Size = new System.Drawing.Size(322, 21);
            this.txt02.TabIndex = 1;
            this.txt02.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(292, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "01.Código:";
            // 
            // txt01
            // 
            this.txt01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.txt01.Location = new System.Drawing.Point(293, 71);
            this.txt01.Name = "txt01";
            this.txt01.ReadOnly = true;
            this.txt01.Size = new System.Drawing.Size(73, 21);
            this.txt01.TabIndex = 0;
            this.txt01.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BioPosto.Properties.Resources.caixa;
            this.pictureBox1.Location = new System.Drawing.Point(657, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Venda de Combustivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Status do Cliente:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(457, 98);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 18);
            this.lblStatus.TabIndex = 37;
            // 
            // pbIcone
            // 
            this.pbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pbIcone.Image = global::BioPosto.Properties.Resources.iconeLupa;
            this.pbIcone.Location = new System.Drawing.Point(568, 102);
            this.pbIcone.Name = "pbIcone";
            this.pbIcone.Size = new System.Drawing.Size(128, 128);
            this.pbIcone.TabIndex = 38;
            this.pbIcone.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnSair.Image = global::BioPosto.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(582, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "   Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::BioPosto.Properties.Resources.logoAL;
            this.pictureBox2.Location = new System.Drawing.Point(15, 425);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // txt03
            // 
            this.txt03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.txt03.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt03.Location = new System.Drawing.Point(297, 148);
            this.txt03.MaxLength = 70;
            this.txt03.Name = "txt03";
            this.txt03.ReadOnly = true;
            this.txt03.Size = new System.Drawing.Size(136, 21);
            this.txt03.TabIndex = 2;
            this.txt03.TabStop = false;
            this.txt03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Transparent;
            this.lbl12.Location = new System.Drawing.Point(295, 132);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(57, 13);
            this.lbl12.TabIndex = 93;
            this.lbl12.Text = "03.Data:";
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.BackColor = System.Drawing.Color.Transparent;
            this.lbl05.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl05.Location = new System.Drawing.Point(299, 218);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(272, 18);
            this.lbl05.TabIndex = 92;
            this.lbl05.Text = "04.Quantidade Abastecida(Lts):";
            // 
            // txt04
            // 
            this.txt04.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt04.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt04.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt04.Location = new System.Drawing.Point(302, 239);
            this.txt04.MaxLength = 75;
            this.txt04.Name = "txt04";
            this.txt04.Size = new System.Drawing.Size(394, 85);
            this.txt04.TabIndex = 3;
            this.txt04.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt04.Leave += new System.EventHandler(this.txt04_Leave);
            this.txt04.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt04_KeyPress);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnGravar.Image = global::BioPosto.Properties.Resources.salvar;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(461, 423);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 38);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "    Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // frmPesqBio
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::BioPosto.Properties.Resources.bg_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(717, 466);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txt03);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl05);
            this.Controls.Add(this.txt04);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.axGrFingerXCtrl1);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.pbIcone);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesqBio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de Combustivel";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesqBio_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.PictureBox pbImg;
        private AxGrFingerXLib.AxGrFingerXCtrl axGrFingerXCtrl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pbIcone;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt03;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.TextBox txt04;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ErrorProvider errErro;
    }
}

