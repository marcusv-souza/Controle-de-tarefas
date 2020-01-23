namespace ControleDeTarefas.Formularios
{
    partial class FormSomarTempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSomarTempo));
            this.label1 = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoTempo = new System.Windows.Forms.TextBox();
            this.radioHoras = new System.Windows.Forms.RadioButton();
            this.radioMiutos = new System.Windows.Forms.RadioButton();
            this.botaoConfirmar = new System.Windows.Forms.Button();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(94, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da tarefa";
            // 
            // textoNome
            // 
            this.textoNome.Enabled = false;
            this.textoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.HideSelection = false;
            this.textoNome.Location = new System.Drawing.Point(232, 149);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(249, 26);
            this.textoNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(94, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo para adicionar";
            // 
            // textoTempo
            // 
            this.textoTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTempo.Location = new System.Drawing.Point(276, 213);
            this.textoTempo.Name = "textoTempo";
            this.textoTempo.Size = new System.Drawing.Size(205, 26);
            this.textoTempo.TabIndex = 3;
            // 
            // radioHoras
            // 
            this.radioHoras.AutoSize = true;
            this.radioHoras.BackColor = System.Drawing.Color.Transparent;
            this.radioHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHoras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioHoras.Location = new System.Drawing.Point(222, 278);
            this.radioHoras.Name = "radioHoras";
            this.radioHoras.Size = new System.Drawing.Size(70, 24);
            this.radioHoras.TabIndex = 12;
            this.radioHoras.TabStop = true;
            this.radioHoras.Text = "Horas";
            this.radioHoras.UseVisualStyleBackColor = false;
            // 
            // radioMiutos
            // 
            this.radioMiutos.AutoSize = true;
            this.radioMiutos.BackColor = System.Drawing.Color.Transparent;
            this.radioMiutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioMiutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMiutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioMiutos.Location = new System.Drawing.Point(98, 278);
            this.radioMiutos.Name = "radioMiutos";
            this.radioMiutos.Size = new System.Drawing.Size(83, 24);
            this.radioMiutos.TabIndex = 11;
            this.radioMiutos.TabStop = true;
            this.radioMiutos.Text = "Minutos";
            this.radioMiutos.UseVisualStyleBackColor = false;
            // 
            // botaoConfirmar
            // 
            this.botaoConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConfirmar.Location = new System.Drawing.Point(98, 345);
            this.botaoConfirmar.Name = "botaoConfirmar";
            this.botaoConfirmar.Size = new System.Drawing.Size(114, 31);
            this.botaoConfirmar.TabIndex = 13;
            this.botaoConfirmar.Text = "Confirmar";
            this.botaoConfirmar.UseVisualStyleBackColor = true;
            this.botaoConfirmar.Click += new System.EventHandler(this.botaoConfirmar_Click);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoVoltar.Location = new System.Drawing.Point(325, 320);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(114, 31);
            this.botaoVoltar.TabIndex = 14;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.botaoVoltar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(42, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 398);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o tempo dedicado a tarefa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormSomarTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 459);
            this.Controls.Add(this.botaoConfirmar);
            this.Controls.Add(this.radioHoras);
            this.Controls.Add(this.radioMiutos);
            this.Controls.Add(this.textoTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSomarTempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo dedicado a tarefa";
            this.Load += new System.EventHandler(this.FormSomarTempo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTempo;
        private System.Windows.Forms.RadioButton radioHoras;
        private System.Windows.Forms.RadioButton radioMiutos;
        private System.Windows.Forms.Button botaoConfirmar;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}