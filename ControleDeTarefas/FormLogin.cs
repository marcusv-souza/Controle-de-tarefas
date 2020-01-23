using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeTarefas.Formularios;
using ControleDeTarefas.Entidades;

namespace ControleDeTarefas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            string login = textoLogin.Text;
            string senha = textoSenha.Text;

            Usuario usuario = new Usuario(login, senha);

            //verifica se o usuario existe no banco de dados
            if (usuario.VerificarUsuario())
            {
                MessageBox.Show("Logado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHome formHome = new FormHome(usuario);
                //esconde a tela de login
                this.Hide();
                formHome.Show();
            }
            else
            {
                /* Se a mensagem de erro está vazia, siginifica que
                 * não houve erros de banco de dados. 
                 * Então os dados que o usuario digitou
                 * que estavam errados.
                 */
                if (usuario.MensagemErro == "")
                {
                    MessageBox.Show("Usuario ou senha errados", "Dados incorretos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Um erro ocorreu: " + usuario.MensagemErro);
                }
            }
        }

        private void botaoCriarUsuario_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario cad = new FormCadastrarUsuario();
            //limpa as caixas de texto pro usuario digitar o novo usuario cadastrado
            textoLogin.Clear();
            textoSenha.Clear();
            cad.ShowDialog();
        }
    }
}
