using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeTarefas.Entidades;

namespace ControleDeTarefas.Formularios
{
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void botaoCadastrarUsuario_Click(object sender, EventArgs e)
        {
            string login = textoLogin.Text;
            string senha = textoSenha.Text;

            Usuario usuario = new Usuario(login, senha);
            
            if (usuario.CadastrarUsuario())
            {
                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro: " + usuario.MensagemErro, "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
