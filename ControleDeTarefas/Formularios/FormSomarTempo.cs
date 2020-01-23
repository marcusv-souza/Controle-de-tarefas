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

namespace ControleDeTarefas.Formularios
{
    public partial class FormSomarTempo : Form
    {
        public string NomeTarefa { get; set; }
        public Usuario Usuario { get; set; }


        public FormSomarTempo(string nome, Usuario usuario)
        {
            NomeTarefa = nome;
            Usuario = usuario;
            InitializeComponent();
        }


        private void FormSomarTempo_Load(object sender, EventArgs e)
        {
            textoNome.Text = NomeTarefa;
            radioMiutos.Checked = true;
        }


        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            int tempo = 0;

            try { 
                tempo = int.Parse(textoTempo.Text);

                //converte para minutos
                if (radioHoras.Checked == true)
                {
                    tempo *= 60;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("O campo tempo está incorreto! Digite apenas numeros inteiros", "Campo tempo está errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE TAREFA SET TEMPO_DEDICADO = TEMPO_DEDICADO + @TEMPO WHERE NOME = @NOME AND ID_USUARIO = @IDUSUARIO";

            cmd.Parameters.AddWithValue("@TEMPO", tempo);
            cmd.Parameters.AddWithValue("@NOME", NomeTarefa);
            cmd.Parameters.AddWithValue("@IDUSUARIO", Usuario.IdUsuario);

            try { 
                cmd.Connection = con.Conectar();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Operação concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //testa se a tarefa está finalizada

                    SqlDataReader dr;
                    cmd.CommandText = "SELECT TEMPO_TOTAL, TEMPO_DEDICADO FROM TAREFA WHERE NOME = @NOME AND ID_USUARIO = @IDUSUARIO";

                    dr = cmd.ExecuteReader();

                    int tempoTotal, tempoDedicado;

                    bool finalizou = false;

                    while (dr.Read())
                    {
                        tempoTotal = (int) dr["TEMPO_TOTAL"];
                        tempoDedicado = (int)dr["TEMPO_DEDICADO"];

                        if (tempoDedicado >= tempoTotal)
                        {
                            MessageBox.Show("Parabéns! Você finalizou a tarefa " + NomeTarefa, "Tarefa finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            finalizou = true;
                            
                        }
                    }


                    dr.Close();
                    //SqlCommand cmd2 = new SqlCommand();
                    //cmd2.Connection = con.Conectar();
                    cmd.CommandText = "UPDATE TAREFA SET ESTADO = 'Finalizada' WHERE NOME = @NOME AND ID_USUARIO = @IDUSUARIO";

                    //cmd2.Parameters.AddWithValue("@NOME", NomeTarefa);
                    //cmd2.Parameters.AddWithValue("@IDUSUARIO", Usuario.IdUsuario);

                    if (finalizou == true)
                    {
                        cmd.ExecuteNonQuery();
                    }

                    con.Desconectar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            finally
            {
                con.Desconectar();
            }

            this.Close();

        }
    }
}
