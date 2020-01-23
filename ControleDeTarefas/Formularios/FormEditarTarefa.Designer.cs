namespace ControleDeTarefas.Formularios
{
    partial class FormEditarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarTarefa));
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.radioHoras = new System.Windows.Forms.RadioButton();
            this.radioMiutos = new System.Windows.Forms.RadioButton();
            this.textoTempoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textoDataFim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoDataInicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoVoltar.Location = new System.Drawing.Point(535, 474);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(103, 32);
            this.botaoVoltar.TabIndex = 25;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // radioHoras
            // 
            this.radioHoras.AutoSize = true;
            this.radioHoras.BackColor = System.Drawing.Color.Transparent;
            this.radioHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHoras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioHoras.Location = new System.Drawing.Point(501, 266);
            this.radioHoras.Name = "radioHoras";
            this.radioHoras.Size = new System.Drawing.Size(70, 24);
            this.radioHoras.TabIndex = 23;
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
            this.radioMiutos.Location = new System.Drawing.Point(377, 266);
            this.radioMiutos.Name = "radioMiutos";
            this.radioMiutos.Size = new System.Drawing.Size(83, 24);
            this.radioMiutos.TabIndex = 22;
            this.radioMiutos.TabStop = true;
            this.radioMiutos.Text = "Minutos";
            this.radioMiutos.UseVisualStyleBackColor = false;
            // 
            // textoTempoTotal
            // 
            this.textoTempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTempoTotal.Location = new System.Drawing.Point(185, 265);
            this.textoTempoTotal.Name = "textoTempoTotal";
            this.textoTempoTotal.Size = new System.Drawing.Size(160, 26);
            this.textoTempoTotal.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(74, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tempo total";
            // 
            // textoDataFim
            // 
            this.textoDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDataFim.Location = new System.Drawing.Point(270, 209);
            this.textoDataFim.Name = "textoDataFim";
            this.textoDataFim.Size = new System.Drawing.Size(301, 26);
            this.textoDataFim.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(74, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data final (dia/mês/ano)";
            // 
            // textoDataInicio
            // 
            this.textoDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDataInicio.Location = new System.Drawing.Point(296, 145);
            this.textoDataInicio.Name = "textoDataInicio";
            this.textoDataInicio.Size = new System.Drawing.Size(275, 26);
            this.textoDataInicio.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(74, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data de inicio (dia/mês/ano)";
            // 
            // textoNome
            // 
            this.textoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.Location = new System.Drawing.Point(141, 82);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(430, 26);
            this.textoNome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(74, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.botaoConfirmar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(36, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 420);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edite os campos da tarefa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // comboEstado
            // 
            this.comboEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Pendente",
            "Finalizada",
            "Cancelada"});
            this.comboEstado.Location = new System.Drawing.Point(104, 291);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(204, 28);
            this.comboEstado.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(38, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Estado";
            // 
            // botaoConfirmar
            // 
            this.botaoConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoConfirmar.Location = new System.Drawing.Point(42, 356);
            this.botaoConfirmar.Name = "botaoConfirmar";
            this.botaoConfirmar.Size = new System.Drawing.Size(191, 32);
            this.botaoConfirmar.TabIndex = 27;
            this.botaoConfirmar.Text = "Confirmar mudanças";
            this.botaoConfirmar.UseVisualStyleBackColor = true;
            this.botaoConfirmar.Click += new System.EventHandler(this.botaoConfirmar_Click);
            // 
            // FormEditarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(676, 518);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.radioHoras);
            this.Controls.Add(this.radioMiutos);
            this.Controls.Add(this.textoTempoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textoDataFim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoDataInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar tarefa";
            this.Load += new System.EventHandler(this.FormEditarTarefa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.RadioButton radioHoras;
        private System.Windows.Forms.RadioButton radioMiutos;
        private System.Windows.Forms.TextBox textoTempoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoDataFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoDataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoConfirmar;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}