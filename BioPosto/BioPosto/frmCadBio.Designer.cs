namespace BioPosto
{
    partial class frmCadBio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadBio));
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.axGrFingerXCtrl1 = new AxGrFingerXLib.AxGrFingerXCtrl();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImg.Image = global::BioPosto.Properties.Resources.bioMicrosoft;
            this.pbImg.Location = new System.Drawing.Point(12, 51);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(300, 300);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 24;
            this.pbImg.TabStop = false;
            // 
            // lbLog
            // 
            this.lbLog.Location = new System.Drawing.Point(12, 359);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.Size = new System.Drawing.Size(658, 82);
            this.lbLog.TabIndex = 25;
            // 
            // txt01
            // 
            this.txt01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.txt01.Location = new System.Drawing.Point(324, 74);
            this.txt01.Name = "txt01";
            this.txt01.ReadOnly = true;
            this.txt01.Size = new System.Drawing.Size(63, 20);
            this.txt01.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(322, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "01.Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(390, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "02.Nome do Cliente";
            // 
            // txt02
            // 
            this.txt02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.txt02.Location = new System.Drawing.Point(393, 74);
            this.txt02.Name = "txt02";
            this.txt02.ReadOnly = true;
            this.txt02.Size = new System.Drawing.Size(277, 20);
            this.txt02.TabIndex = 28;
            // 
            // axGrFingerXCtrl1
            // 
            this.axGrFingerXCtrl1.Enabled = true;
            this.axGrFingerXCtrl1.Location = new System.Drawing.Point(451, 451);
            this.axGrFingerXCtrl1.Name = "axGrFingerXCtrl1";
            this.axGrFingerXCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrFingerXCtrl1.OcxState")));
            this.axGrFingerXCtrl1.Size = new System.Drawing.Size(32, 32);
            this.axGrFingerXCtrl1.TabIndex = 30;
            this.axGrFingerXCtrl1.SensorPlug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEventHandler(this.axGrFingerXCtrl1_SensorPlug);
            this.axGrFingerXCtrl1.SensorUnplug += new AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEventHandler(this.axGrFingerXCtrl1_SensorUnplug);
            this.axGrFingerXCtrl1.ImageAcquired += new AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEventHandler(this.axGrFingerXCtrl1_ImageAcquired);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 60);
            this.button1.TabIndex = 31;
            this.button1.Text = "Gravar Bio 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(519, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 60);
            this.button3.TabIndex = 33;
            this.button3.Text = "Gravar Bio 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cadastrar Biometria";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnSair.Image = global::BioPosto.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(558, 447);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 38);
            this.btnSair.TabIndex = 38;
            this.btnSair.Text = "   Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(324, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Passos para o Cadastramento Biometrico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(325, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 143);
            this.label5.TabIndex = 40;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::BioPosto.Properties.Resources.logoAL;
            this.pictureBox2.Location = new System.Drawing.Point(14, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // frmCadBio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::BioPosto.Properties.Resources.bg_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(682, 491);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axGrFingerXCtrl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.pbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadBio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Biometria";
            this.Load += new System.EventHandler(this.frmCadBio_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadBio_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrFingerXCtrl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt02;
        private AxGrFingerXLib.AxGrFingerXCtrl axGrFingerXCtrl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}