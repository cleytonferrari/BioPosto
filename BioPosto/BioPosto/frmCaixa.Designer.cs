namespace BioPosto
{
    partial class frmCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl01 = new System.Windows.Forms.Label();
            this.txt01 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt02 = new System.Windows.Forms.DateTimePicker();
            this.dgdGrid = new System.Windows.Forms.DataGridView();
            this.lbl04 = new System.Windows.Forms.Label();
            this.txt03 = new System.Windows.Forms.TextBox();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt04 = new System.Windows.Forms.TextBox();
            this.lbl25 = new System.Windows.Forms.Label();
            this.txt05 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fechamento de Caixa";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnCalcular.Image = global::BioPosto.Properties.Resources.confirmar;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(320, 331);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 38);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "      Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnSair.Image = global::BioPosto.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(448, 331);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 38);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "   Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.BackColor = System.Drawing.Color.Transparent;
            this.lbl01.Location = new System.Drawing.Point(9, 54);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(95, 13);
            this.lbl01.TabIndex = 80;
            this.lbl01.Text = "01.Data Inicial:";
            // 
            // txt01
            // 
            this.txt01.CustomFormat = "dd/MM/yyyy";
            this.txt01.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt01.Location = new System.Drawing.Point(12, 70);
            this.txt01.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.txt01.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(170, 21);
            this.txt01.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(207, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "02.Data Final:";
            // 
            // txt02
            // 
            this.txt02.CustomFormat = "dd/MM/yyyy";
            this.txt02.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt02.Location = new System.Drawing.Point(210, 70);
            this.txt02.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.txt02.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(170, 21);
            this.txt02.TabIndex = 2;
            // 
            // dgdGrid
            // 
            this.dgdGrid.AllowUserToAddRows = false;
            this.dgdGrid.AllowUserToDeleteRows = false;
            this.dgdGrid.AllowUserToResizeRows = false;
            this.dgdGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgdGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.data,
            this.nome,
            this.cpf,
            this.quantidade,
            this.total});
            this.dgdGrid.Location = new System.Drawing.Point(9, 106);
            this.dgdGrid.MultiSelect = false;
            this.dgdGrid.Name = "dgdGrid";
            this.dgdGrid.ReadOnly = true;
            this.dgdGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdGrid.Size = new System.Drawing.Size(557, 169);
            this.dgdGrid.TabIndex = 3;
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.BackColor = System.Drawing.Color.Transparent;
            this.lbl04.Location = new System.Drawing.Point(405, 55);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(79, 13);
            this.lbl04.TabIndex = 85;
            this.lbl04.Text = "03.Valor R$:";
            // 
            // txt03
            // 
            this.txt03.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt03.Location = new System.Drawing.Point(408, 70);
            this.txt03.MaxLength = 75;
            this.txt03.Name = "txt03";
            this.txt03.Size = new System.Drawing.Size(141, 21);
            this.txt03.TabIndex = 0;
            this.txt03.Leave += new System.EventHandler(this.txt03_Leave);
            this.txt03.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt03_KeyPress);
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // txt04
            // 
            this.txt04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.txt04.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt04.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt04.Location = new System.Drawing.Point(330, 297);
            this.txt04.MaxLength = 9;
            this.txt04.Name = "txt04";
            this.txt04.ReadOnly = true;
            this.txt04.Size = new System.Drawing.Size(97, 21);
            this.txt04.TabIndex = 4;
            this.txt04.TabStop = false;
            this.txt04.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt04.TextChanged += new System.EventHandler(this.txt04_TextChanged);
            // 
            // lbl25
            // 
            this.lbl25.AutoSize = true;
            this.lbl25.BackColor = System.Drawing.Color.Transparent;
            this.lbl25.Location = new System.Drawing.Point(327, 281);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(100, 13);
            this.lbl25.TabIndex = 86;
            this.lbl25.Text = "04.Quant. Total:";
            // 
            // txt05
            // 
            this.txt05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.txt05.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt05.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt05.Location = new System.Drawing.Point(440, 297);
            this.txt05.MaxLength = 9;
            this.txt05.Name = "txt05";
            this.txt05.ReadOnly = true;
            this.txt05.Size = new System.Drawing.Size(125, 21);
            this.txt05.TabIndex = 5;
            this.txt05.TabStop = false;
            this.txt05.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt05.TextChanged += new System.EventHandler(this.txt05_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(437, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "05.Valor Total R$:";
            // 
            // Código
            // 
            this.Código.DataPropertyName = "cliente_id";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 50;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 170;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.quantidade.DefaultCellStyle = dataGridViewCellStyle9;
            this.quantidade.HeaderText = "Quant.";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 65;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle10;
            this.total.HeaderText = "Valor R$";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // frmCaixa
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::BioPosto.Properties.Resources.bg_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(574, 381);
            this.Controls.Add(this.txt05);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt04);
            this.Controls.Add(this.lbl25);
            this.Controls.Add(this.lbl04);
            this.Controls.Add(this.txt03);
            this.Controls.Add(this.dgdGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.DateTimePicker txt01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt02;
        public System.Windows.Forms.DataGridView dgdGrid;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.TextBox txt03;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.TextBox txt05;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt04;
        private System.Windows.Forms.Label lbl25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}