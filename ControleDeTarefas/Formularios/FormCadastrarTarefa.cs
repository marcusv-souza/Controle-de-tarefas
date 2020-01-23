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
using System.Globalization;

namespace ControleDeTarefas.Formularios
{
    public partial class FormCadastrarTarefa : Form
    {
        public Usuario Usuario { get; set; }

        public FormCadastrarTarefa(Usuario usuario)
        {
            this.Usuario = usuario;
            InitializeComponent();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            if (textoNome.Text == "" || textoTempoTotal.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de prosseguir.", "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nome = textoNome.Text;
            int tempoTotal = 0;
            
            try { 
                tempoTotal = int.Parse(textoTempoTotal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique o campo tempo, digite apenas números inteiros.", "Erro no campo temp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            if (radioHoras.Checked == true)
            {
                tempoTotal *= 60;
            }

            DateTime dataInicio = DateTime.Now;
            DateTime dataFim = DateTime.Now;

            try { 
                dataInicio = DateTime.ParseExact(textoDataInicio.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dataFim = DateTime.ParseExact(textoDataFim.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os campos de datas antes de prosseguir.", "Erro de dada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            

            int idUsuario = Usuario.IdUsuario;
            
            //testa se existe algum campo vazio
            if (nome != null && dataInicio != null && dataFim != null && tempoTotal > 0)
            {
                /* Testa se a data final é maior que a data do dia de cadastro */
                TimeSpan diferenca = dataFim.Subtract(DateTime.Now);
                if (diferenca.TotalDays > 0)
                {
                    Tarefa tarefa = new Tarefa(nome, dataInicio, dataFim, tempoTotal, idUsuario);

                    if (tarefa.RegistrarTarefa())
                    {
                        MessageBox.Show("Tarefa registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpando os campos
                        textoNome.Clear();
                        textoDataInicio.Clear();
                        textoDataFim.Clear();
                        textoTempoTotal.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível registrar tarefa. Erro: " + tarefa.MensagemErro, "Erro no banco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique a data final antes de prosseguir.", "Data errada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de prosseguir.", "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FormCadastrarTarefa_Load(object sender, EventArgs e)
        {
            radioMiutos.Checked = true;
            radioHoras.Checked = false;
        }
    }
}
