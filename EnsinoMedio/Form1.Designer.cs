namespace EnsinoMedio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btProcurarFoto = new System.Windows.Forms.Button();
            this.pbFotoAluno = new System.Windows.Forms.PictureBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btDeletarAluno = new System.Windows.Forms.Button();
            this.btCadastrarAluno = new System.Windows.Forms.Button();
            this.dtpDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(19, 208);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(437, 240);
            this.dgvAluno.TabIndex = 3;
            this.dgvAluno.DoubleClick += new System.EventHandler(this.dgvAluno_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(332, 63);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(165, 119);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(142, 21);
            this.cmbEstado.TabIndex = 2;
            // 
            // btProcurarFoto
            // 
            this.btProcurarFoto.Image = global::EnsinoMedio.Properties.Resources.if_image_1055042;
            this.btProcurarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProcurarFoto.Location = new System.Drawing.Point(28, 164);
            this.btProcurarFoto.Name = "btProcurarFoto";
            this.btProcurarFoto.Size = new System.Drawing.Size(94, 23);
            this.btProcurarFoto.TabIndex = 11;
            this.btProcurarFoto.Text = "Procurar";
            this.btProcurarFoto.UseVisualStyleBackColor = true;
            this.btProcurarFoto.Click += new System.EventHandler(this.btProcurarFoto_Click);
            // 
            // pbFotoAluno
            // 
            this.pbFotoAluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFotoAluno.Location = new System.Drawing.Point(19, 37);
            this.pbFotoAluno.Name = "pbFotoAluno";
            this.pbFotoAluno.Size = new System.Drawing.Size(112, 110);
            this.pbFotoAluno.TabIndex = 8;
            this.pbFotoAluno.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::EnsinoMedio.Properties.Resources.if_05_Eraser_2064480;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(262, 164);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(90, 23);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btDeletarAluno
            // 
            this.btDeletarAluno.Image = global::EnsinoMedio.Properties.Resources.if_Close_1891023__1_;
            this.btDeletarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletarAluno.Location = new System.Drawing.Point(358, 164);
            this.btDeletarAluno.Name = "btDeletarAluno";
            this.btDeletarAluno.Size = new System.Drawing.Size(86, 23);
            this.btDeletarAluno.TabIndex = 4;
            this.btDeletarAluno.Text = "Deletar";
            this.btDeletarAluno.UseVisualStyleBackColor = true;
            this.btDeletarAluno.Click += new System.EventHandler(this.btDeletarAluno_Click);
            // 
            // btCadastrarAluno
            // 
            this.btCadastrarAluno.Image = global::EnsinoMedio.Properties.Resources.if_sign_add_299068__1_;
            this.btCadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarAluno.Location = new System.Drawing.Point(166, 164);
            this.btCadastrarAluno.Name = "btCadastrarAluno";
            this.btCadastrarAluno.Size = new System.Drawing.Size(90, 23);
            this.btCadastrarAluno.TabIndex = 3;
            this.btCadastrarAluno.Text = "Cadastrar";
            this.btCadastrarAluno.UseVisualStyleBackColor = true;
            this.btCadastrarAluno.Click += new System.EventHandler(this.btCreateState_Click);
            // 
            // dtpDataMatricula
            // 
            this.dtpDataMatricula.CustomFormat = "dd/MM/yyyy";
            this.dtpDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMatricula.Location = new System.Drawing.Point(332, 119);
            this.dtpDataMatricula.Name = "dtpDataMatricula";
            this.dtpDataMatricula.Size = new System.Drawing.Size(100, 20);
            this.dtpDataMatricula.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data da Matrícula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataMatricula);
            this.Controls.Add(this.btProcurarFoto);
            this.Controls.Add(this.pbFotoAluno);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDeletarAluno);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.btCadastrarAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test CRUD with XAMPP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarAluno;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btDeletarAluno;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.PictureBox pbFotoAluno;
        private System.Windows.Forms.Button btProcurarFoto;
        private System.Windows.Forms.DateTimePicker dtpDataMatricula;
        private System.Windows.Forms.Label label4;
    }
}

