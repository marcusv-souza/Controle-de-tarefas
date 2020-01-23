using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControleDeTarefas.Entidades;

namespace ControleDeTarefas.Formularios
{
    public partial class FormEditarTarefa : Form
    {
        public string NomeTarefa { get; set; }
        public int IdTarefa { get; set; }
        public Usuario Usuario { get; set; }

        public FormEditarTarefa(string nome, Usuario usuario)
        {
            NomeTarefa = nome;
            Usuario = usuario;
            InitializeComponent();
        }

        private void FormEditarTarefa_Load(object sender, EventArgs e)
        {
            /* os blocos abaixo carregam as informações 
             * da tarefa selecionada e exibe 
             * nas caixas de texto
             */

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT * FROM TAREFA WHERE NOME = @NOME AND ID_USUARIO = @IDUSUARIO";
            cmd.Parameters.AddWithValue("@NOME", NomeTarefa);
            cmd.Parameters.AddWithValue("@IDUSUARIO", Usuario.IdUsuario);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {
                    MessageBox.Show("Erro ao carregar tarefa", "Erro na tarefa selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    while (dr.Read())
                    {
                        IdTarefa = (int) dr["IDTAREFA"];

                        textoNome.Text = dr["NOME"].ToString();

                        DateTime dataInicio = DateTime.Parse(dr["DATA_INICIO"].ToString());
                        textoDataInicio.Text = dataInicio.ToString("dd/MM/yyyy");

                        DateTime dataFim = DateTime.Parse(dr["DATA_FIM"].ToString());
                        textoDataFim.Text = dataFim.ToString("dd/MM/yyyy");

                        textoTempoTotal.Text = dr["TEMPO_TOTAL"].ToString();

                        radioMiutos.Checked = true;

                        comboEstado.SelectedItem = dr["ESTADO"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Desconectar();
            }
            
        }


        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            //validando os campos
            if (textoNome.Text == "" || textoDataInicio.Text == "" || textoDataFim.Text == "" || textoTempoTotal.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de confirmar.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Inicializando as datas 
            DateTime dataInicio = DateTime.Parse("01/01/2020");
            DateTime dataFim = DateTime.Parse("01/01/2020");

            //Verificando se os campos datas estão corretos
            try
            {
                dataInicio = DateTime.Parse(textoDataInicio.Text);
                dataFim = DateTime.Parse(textoDataFim.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os campos das datas antes de prosseguir.", "Datas erradas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Salvando os campos de texto

            string nome = textoNome.Text;

            int tempoTotal = 0;
            try
            {
                tempoTotal = int.Parse(textoTempoTotal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no campo tempo, digite apenas números inteiros.", "Erro no campo tempo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (radioHoras.Checked == true)
            {
                tempoTotal *= 60;
            }

            string estado = comboEstado.SelectedItem.ToString();


            //Perguntando se o usuario deseja prosseguir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja confirmar essas mudanças?", "Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.No)
            {
                return;
            }

          
            // Conectando com o banco e dando um update

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE TAREFA SET NOME = @NOME, DATA_INICIO = @DATAINICIO, DATA_FIM = @DATAFIM, TEMPO_TOTAL = @TEMPOTOTAL, ESTADO = @ESTADO WHERE NOME = @NOMEANTIGO AND ID_USUARIO = @IDUSUARIO";

            cmd.Parameters.AddWithValue("@NOME", nome);
            cmd.Parameters.AddWithValue("@DATAINICIO", dataInicio);
            cmd.Parameters.AddWithValue("@DATAFIM", dataFim);
            cmd.Parameters.AddWithValue("@TEMPOTOTAL", tempoTotal);
            cmd.Parameters.AddWithValue("@ESTADO", estado);
            cmd.Parameters.AddWithValue("@NOMEANTIGO", NomeTarefa);
            cmd.Parameters.AddWithValue("@IDUSUARIO", Usuario.IdUsuario);

            try
            {
                cmd.Connection = con.Conectar();

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Os dados foram alterados com sucesso!", "Dados alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Desconectar();
                this.Close();
            }
        }
    }
}
