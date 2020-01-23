namespace ControleDeTarefas
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoLogin = new System.Windows.Forms.TextBox();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.botaoCriarUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(166, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(166, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // textoLogin
            // 
            this.textoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textoLogin.Location = new System.Drawing.Point(170, 39);
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(186, 29);
            this.textoLogin.TabIndex = 2;
            // 
            // textoSenha
            // 
            this.textoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textoSenha.Location = new System.Drawing.Point(170, 109);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.PasswordChar = '*';
            this.textoSenha.Size = new System.Drawing.Size(186, 29);
            this.textoSenha.TabIndex = 3;
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEntrar.Location = new System.Drawing.Point(244, 160);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.Size = new System.Drawing.Size(112, 48);
            this.botaoEntrar.TabIndex = 4;
            this.botaoEntrar.Text = "Entrar";
            this.botaoEntrar.UseVisualStyleBackColor = true;
            this.botaoEntrar.Click += new System.EventHandler(this.botaoEntrar_Click);
            // 
            // botaoCriarUsuario
            // 
            this.botaoCriarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCriarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriarUsuario.Location = new System.Drawing.Point(12, 180);
            this.botaoCriarUsuario.Name = "botaoCriarUsuario";
            this.botaoCriarUsuario.Size = new System.Drawing.Size(114, 28);
            this.botaoCriarUsuario.TabIndex = 5;
            this.botaoCriarUsuario.Text = "Criar usuario";
            this.botaoCriarUsuario.UseVisualStyleBackColor = true;
            this.botaoCriarUsuario.Click += new System.EventHandler(this.botaoCriarUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoCriarUsuario);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.textoLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoLogin;
        private System.Windows.Forms.TextBox textoSenha;
        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.Button botaoCriarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

