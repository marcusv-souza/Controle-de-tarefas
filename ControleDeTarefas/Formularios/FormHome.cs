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
using System.Data.SqlClient;
using System.Globalization;

namespace ControleDeTarefas.Formularios
{
    public partial class FormHome : Form
    {
        public Usuario Usuario { get; private set; }


        public FormHome(Usuario usuario)
        {
            this.Usuario = usuario;
            InitializeComponent();
        }


        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void botaoAdicionarTarefa_Click(object sender, EventArgs e)
        {
            FormCadastrarTarefa formCad = new FormCadastrarTarefa(Usuario);
            formCad.ShowDialog();

            string filtro = comboFiltroTarefas.SelectedItem.ToString();
            CarregarListaTarefas(filtro);
            listaInformacoes.Items.Clear();
        }


        private void FormHome_Load(object sender, EventArgs e)
        {
            //mostra o nome do usuario
            textoUsuario.Text = Usuario.Login;

            DateTime data = DateTime.Now;
            labelData.Text = data.ToString("dd/MM/yyyy");

            comboFiltroTarefas.SelectedItem = "Pendentes";
            CarregarListaTarefas("Pendentes");
        }


        public void CarregarListaTarefas(string filtro)
        {
            string estado = filtro;

           
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
          
            if (filtro == "Todas")
            {
                cmd.CommandText = "SELECT NOME FROM TAREFA WHERE ID_USUARIO = @ID_USUARIO";
            }
            else if (filtro == "Pendentes")
            {
                cmd.CommandText = "SELECT NOME FROM TAREFA WHERE ID_USUARIO = @ID_USUARIO AND ESTADO = 'Pendente'";
            }
            else if (filtro == "Finalizadas")
            {
                cmd.CommandText = "SELECT NOME FROM TAREFA WHERE ID_USUARIO = @ID_USUARIO AND ESTADO = 'Finalizada'";
            }
            else if (filtro == "Canceladas")
            {
                cmd.CommandText = "SELECT NOME FROM TAREFA WHERE ID_USUARIO = @ID_USUARIO AND ESTADO = 'Cancelada'";
            }

            cmd.Parameters.AddWithValue("@ID_USUARIO", Usuario.IdUsuario);

            try { 
                cmd.Connection = con.Conectar();
                
                dr = cmd.ExecuteReader();

                //limpa a lista antes de recarregar
                listaDeTarefas.Items.Clear();

                while (dr.Read())
                {
                    listaDeTarefas.Items.Add(dr["NOME"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar tarefas: " + ex.Message);
            }
            finally { 
                con.Desconectar();
            }
        }


        private void listaDeTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaDeTarefas.SelectedIndex < 0)
            {
                return;
            }

            string nome = listaDeTarefas.SelectedItem.ToString();

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TAREFA WHERE NOME = @NOME";
            cmd.Parameters.AddWithValue("@NOME", nome);

            try { 
                cmd.Connection = con.Conectar();

                dr = cmd.ExecuteReader();

                listaInformacoes.Items.Clear();

                while (dr.Read())
                {
                    DateTime dataFim = DateTime.Parse(dr["DATA_FIM"].ToString());
                    DateTime dataInicio = DateTime.Parse(dr["DATA_INICIO"].ToString());
                    
                    TimeSpan diferenca = dataFim.Subtract(DateTime.Now);

                    if (diferenca.TotalDays > 0)
                    {
                        listaInformacoes.Items.Add("Dias restantes: " + (int) diferenca.TotalDays);
                        listaInformacoes.Items.Add("");
                    }
                    else
                    {
                        listaInformacoes.Items.Add("ATENÇÃO: a data expirou!");
                        listaInformacoes.Items.Add("");
                    }

                    listaInformacoes.Items.Add("Estado: " + dr["ESTADO"].ToString());
                    listaInformacoes.Items.Add("");

                    listaInformacoes.Items.Add("Data de início: " + dataInicio.ToString("dd/MM/yyyy"));
                    listaInformacoes.Items.Add("Data final: " + dataFim.ToString("dd/MM/yyyy"));

                    listaInformacoes.Items.Add("");
                    listaInformacoes.Items.Add("Tempo total: " + dr["TEMPO_TOTAL"] + " minutos");
                    listaInformacoes.Items.Add("Tempo dedicado: " + dr["TEMPO_DEDICADO"] + " minutos");

                    double porcentagem = (double) (((int) dr["TEMPO_DEDICADO"] * 100) / (int) dr["TEMPO_TOTAL"]);
                    listaInformacoes.Items.Add("Porcentagem: " + porcentagem.ToString("F0") + " %");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar Informações: " + ex.Message);
            }
            finally { 
                con.Desconectar();
            }
        }

        private void botaoSomarTempo_Click(object sender, EventArgs e)
        {
            if (listaDeTarefas.SelectedIndex >= 0)
            {
                FormSomarTempo formTempo = new FormSomarTempo(listaDeTarefas.SelectedItem.ToString(), Usuario);
                formTempo.ShowDialog();
                string selecao = listaDeTarefas.SelectedItem.ToString();
                CarregarListaTarefas(comboFiltroTarefas.SelectedItem.ToString());
                listaDeTarefas.SelectedItem = selecao;

            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma tarefa.", "Tarefa não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botaoRemoverTarefa_Click(object sender, EventArgs e)
        {
            if (listaDeTarefas.SelectedIndex >= 0)
            {
                DialogResult resultado = MessageBox.Show("Você tem certeza que deseja remover a tarefa selecionada?", "Remover tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resultado == DialogResult.No)
                {
                    return;
                }

                string nome = listaDeTarefas.SelectedItem.ToString();
                int idUsuario = Usuario.IdUsuario;

                Tarefa tarefa = new Tarefa(nome, idUsuario);

                if (tarefa.RemoverTarefa())
                {
                    MessageBox.Show("A tarefa foi removida do sistema.");
                    CarregarListaTarefas(comboFiltroTarefas.SelectedItem.ToString());
                    listaInformacoes.Items.Clear();
                }


            }
            else
            {
                MessageBox.Show("Selecione uma tarefa antes de remover.", "Tarefa não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void botaoEditarTarefa_Click(object sender, EventArgs e)
        {
            if (listaDeTarefas.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma tarefa para editar", "Tarefa não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormEditarTarefa formEditar = new FormEditarTarefa(listaDeTarefas.SelectedItem.ToString(), Usuario);
            formEditar.ShowDialog();

            this.CarregarListaTarefas(comboFiltroTarefas.SelectedItem.ToString());
            listaInformacoes.Items.Clear();
        }

        private void comboFiltroTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarListaTarefas(comboFiltroTarefas.SelectedItem.ToString());
            listaInformacoes.Items.Clear();
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio formR = new FormRelatorio(Usuario);
            formR.ShowDialog();
        }
    }
}
