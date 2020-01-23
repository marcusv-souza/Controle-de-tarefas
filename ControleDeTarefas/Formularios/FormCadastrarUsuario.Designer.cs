namespace ControleDeTarefas.Formularios
{
    partial class FormCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarUsuario));
            this.botaoCadastrarUsuario = new System.Windows.Forms.Button();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.textoLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoCadastrarUsuario
            // 
            this.botaoCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastrarUsuario.Location = new System.Drawing.Point(97, 162);
            this.botaoCadastrarUsuario.Name = "botaoCadastrarUsuario";
            this.botaoCadastrarUsuario.Size = new System.Drawing.Size(112, 48);
            this.botaoCadastrarUsuario.TabIndex = 9;
            this.botaoCadastrarUsuario.Text = "Cadastrar";
            this.botaoCadastrarUsuario.UseVisualStyleBackColor = true;
            this.botaoCadastrarUsuario.Click += new System.EventHandler(this.botaoCadastrarUsuario_Click);
            // 
            // textoSenha
            // 
            this.textoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(23, 111);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(186, 29);
            this.textoSenha.TabIndex = 8;
            // 
            // textoLogin
            // 
            this.textoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogin.Location = new System.Drawing.Point(23, 41);
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(186, 29);
            this.textoLogin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(232, 229);
            this.Controls.Add(this.botaoCadastrarUsuario);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.textoLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastrarUsuario;
        private System.Windows.Forms.TextBox textoSenha;
        private System.Windows.Forms.TextBox textoLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}