namespace ControleDeTarefas.Formularios
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiltroTarefas = new System.Windows.Forms.ComboBox();
            this.botaoAdicionarTarefa = new System.Windows.Forms.Button();
            this.botaoEditarTarefa = new System.Windows.Forms.Button();
            this.botaoRemoverTarefa = new System.Windows.Forms.Button();
            this.botaoSomarTempo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textoUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaInformacoes = new System.Windows.Forms.ListBox();
            this.listaDeTarefas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoRelatorio = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botaoSair
            // 
            this.botaoSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(777, 509);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 33);
            this.botaoSair.TabIndex = 1;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(187, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar tarefas por";
            // 
            // comboFiltroTarefas
            // 
            this.comboFiltroTarefas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboFiltroTarefas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFiltroTarefas.FormattingEnabled = true;
            this.comboFiltroTarefas.Items.AddRange(new object[] {
            "Pendentes",
            "Finalizadas",
            "Canceladas",
            "Todas"});
            this.comboFiltroTarefas.Location = new System.Drawing.Point(341, 73);
            this.comboFiltroTarefas.Name = "comboFiltroTarefas";
            this.comboFiltroTarefas.Size = new System.Drawing.Size(191, 28);
            this.comboFiltroTarefas.TabIndex = 4;
            this.comboFiltroTarefas.SelectedIndexChanged += new System.EventHandler(this.comboFiltroTarefas_SelectedIndexChanged);
            // 
            // botaoAdicionarTarefa
            // 
            this.botaoAdicionarTarefa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botaoAdicionarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdicionarTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoAdicionarTarefa.Location = new System.Drawing.Point(25, 449);
            this.botaoAdicionarTarefa.Name = "botaoAdicionarTarefa";
            this.botaoAdicionarTarefa.Size = new System.Drawing.Size(94, 34);
            this.botaoAdicionarTarefa.TabIndex = 5;
            this.botaoAdicionarTarefa.Text = "Adicionar";
            this.botaoAdicionarTarefa.UseVisualStyleBackColor = false;
            this.botaoAdicionarTarefa.Click += new System.EventHandler(this.botaoAdicionarTarefa_Click);
            // 
            // botaoEditarTarefa
            // 
            this.botaoEditarTarefa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botaoEditarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEditarTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoEditarTarefa.Location = new System.Drawing.Point(125, 449);
            this.botaoEditarTarefa.Name = "botaoEditarTarefa";
            this.botaoEditarTarefa.Size = new System.Drawing.Size(94, 34);
            this.botaoEditarTarefa.TabIndex = 6;
            this.botaoEditarTarefa.Text = "Editar";
            this.botaoEditarTarefa.UseVisualStyleBackColor = false;
            this.botaoEditarTarefa.Click += new System.EventHandler(this.botaoEditarTarefa_Click);
            // 
            // botaoRemoverTarefa
            // 
            this.botaoRemoverTarefa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botaoRemoverTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemoverTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRemoverTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoRemoverTarefa.Location = new System.Drawing.Point(225, 449);
            this.botaoRemoverTarefa.Name = "botaoRemoverTarefa";
            this.botaoRemoverTarefa.Size = new System.Drawing.Size(94, 34);
            this.botaoRemoverTarefa.TabIndex = 7;
            this.botaoRemoverTarefa.Text = "Remover";
            this.botaoRemoverTarefa.UseVisualStyleBackColor = false;
            this.botaoRemoverTarefa.Click += new System.EventHandler(this.botaoRemoverTarefa_Click);
            // 
            // botaoSomarTempo
            // 
            this.botaoSomarTempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSomarTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSomarTempo.Location = new System.Drawing.Point(401, 449);
            this.botaoSomarTempo.Name = "botaoSomarTempo";
            this.botaoSomarTempo.Size = new System.Drawing.Size(131, 34);
            this.botaoSomarTempo.TabIndex = 9;
            this.botaoSomarTempo.Text = "Somar tempo";
            this.botaoSomarTempo.UseVisualStyleBackColor = true;
            this.botaoSomarTempo.Click += new System.EventHandler(this.botaoSomarTempo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(647, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario:";
            // 
            // textoUsuario
            // 
            this.textoUsuario.Enabled = false;
            this.textoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoUsuario.HideSelection = false;
            this.textoUsuario.Location = new System.Drawing.Point(721, 12);
            this.textoUsuario.Name = "textoUsuario";
            this.textoUsuario.Size = new System.Drawing.Size(131, 26);
            this.textoUsuario.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(590, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Informações da tarefa";
            // 
            // listaInformacoes
            // 
            this.listaInformacoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listaInformacoes.Enabled = false;
            this.listaInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaInformacoes.FormattingEnabled = true;
            this.listaInformacoes.ItemHeight = 20;
            this.listaInformacoes.Location = new System.Drawing.Point(594, 127);
            this.listaInformacoes.Name = "listaInformacoes";
            this.listaInformacoes.Size = new System.Drawing.Size(258, 304);
            this.listaInformacoes.TabIndex = 14;
            // 
            // listaDeTarefas
            // 
            this.listaDeTarefas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaDeTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDeTarefas.FormattingEnabled = true;
            this.listaDeTarefas.ItemHeight = 20;
            this.listaDeTarefas.Location = new System.Drawing.Point(25, 127);
            this.listaDeTarefas.Name = "listaDeTarefas";
            this.listaDeTarefas.Size = new System.Drawing.Size(507, 304);
            this.listaDeTarefas.TabIndex = 15;
            this.listaDeTarefas.SelectedIndexChanged += new System.EventHandler(this.listaDeTarefas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(22, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Desenvolvido por: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(156, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "marcusv.souza@outlook.com";
            // 
            // botaoRelatorio
            // 
            this.botaoRelatorio.BackColor = System.Drawing.Color.Firebrick;
            this.botaoRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRelatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoRelatorio.Location = new System.Drawing.Point(594, 449);
            this.botaoRelatorio.Name = "botaoRelatorio";
            this.botaoRelatorio.Size = new System.Drawing.Size(108, 34);
            this.botaoRelatorio.TabIndex = 18;
            this.botaoRelatorio.Text = "Relatório";
            this.botaoRelatorio.UseVisualStyleBackColor = false;
            this.botaoRelatorio.Click += new System.EventHandler(this.botaoRelatorio_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelData.Location = new System.Drawing.Point(437, 12);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(99, 20);
            this.labelData.TabIndex = 19;
            this.labelData.Text = "17/01/2020";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(354, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data atual:";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 554);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.botaoRelatorio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaDeTarefas);
            this.Controls.Add(this.listaInformacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoSomarTempo);
            this.Controls.Add(this.botaoRemoverTarefa);
            this.Controls.Add(this.botaoEditarTarefa);
            this.Controls.Add(this.botaoAdicionarTarefa);
            this.Controls.Add(this.comboFiltroTarefas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de tarefas";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFiltroTarefas;
        private System.Windows.Forms.Button botaoAdicionarTarefa;
        private System.Windows.Forms.Button botaoEditarTarefa;
        private System.Windows.Forms.Button botaoRemoverTarefa;
        private System.Windows.Forms.Button botaoSomarTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listaInformacoes;
        private System.Windows.Forms.ListBox listaDeTarefas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botaoRelatorio;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label7;
    }
}