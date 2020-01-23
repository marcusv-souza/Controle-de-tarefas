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
    public partial class FormRelatorio : Form
    {
        public Usuario Usuario { get; set; }

        public FormRelatorio(Usuario usuario)
        {
            Usuario = usuario;
            InitializeComponent();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "SELECT ESTADO FROM TAREFA WHERE ID_USUARIO = @IDUSUARIO";
            cmd.Parameters.AddWithValue("@IDUSUARIO", Usuario.IdUsuario);

            try
            {
                cmd.Connection = con.Conectar();

                dr = cmd.ExecuteReader();

                int totalTarefas = 0;
                int finalizadas = 0;
                int canceladas = 0;
                int pendentes = 0;

                while (dr.Read())
                {
                    totalTarefas += 1;

                    if (dr["ESTADO"].ToString() == "Pendente")
                    {
                        pendentes += 1;
                    }
                    else if (dr["ESTADO"].ToString() == "Finalizada")
                    {
                        finalizadas += 1;
                    }
                    else if (dr["ESTADO"].ToString() == "Cancelada")
                    {
                        canceladas += 1;
                    }
                }

                labelTotal.Text = totalTarefas.ToString();
                labelPendentes.Text = pendentes.ToString();
                labelCanceladas.Text = canceladas.ToString();
                labelFinalizadas.Text = finalizadas.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                con.Desconectar();
            }
        }
    }
}
