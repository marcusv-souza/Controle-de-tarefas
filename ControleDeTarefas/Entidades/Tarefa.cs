using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControleDeTarefas.Entidades
{
    public class Tarefa
    {
        public int IdTarefa { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int TempoTotal { get; set; }
        public int TempoDedicado { get; set; }
        public EstadoTarefa Estado { get; set; }
        public int IdUsuario { get; set; }

        public string MensagemErro { get; set; }

        public Tarefa(string nome, int idusuario)
        {
            Nome = nome;
            IdUsuario = idusuario;
        }
        public Tarefa(string nome, DateTime dataInicio, DateTime dataFim, int tempoTotal, int idUsuario)
        {
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            TempoTotal = tempoTotal;
            Estado = EstadoTarefa.Pendente;
            IdUsuario = idUsuario;

            IdTarefa = 0;
        }

        public bool RegistrarTarefa()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO TAREFA(NOME, DATA_INICIO, DATA_FIM, TEMPO_TOTAL, TEMPO_DEDICADO, ESTADO, ID_USUARIO) OUTPUT INSERTED.IDTAREFA ";
            cmd.CommandText += "VALUES(@NOME, @DATAINICIO, @DATAFIM, @TEMPOTOTAL, @TEMPODEDICADO, @ESTADO, @IDUSUARIO)";

            cmd.Parameters.AddWithValue("@NOME", Nome);
            cmd.Parameters.AddWithValue("@DATAINICIO", DataInicio);
            cmd.Parameters.AddWithValue("@DATAFIM", DataFim);
            cmd.Parameters.AddWithValue("@TEMPOTOTAL", TempoTotal);
            cmd.Parameters.AddWithValue("@TEMPODEDICADO", 0);
            cmd.Parameters.AddWithValue("@ESTADO", Estado.ToString());
            cmd.Parameters.AddWithValue("@IDUSUARIO", IdUsuario);

            try
            {
                cmd.Connection = con.Conectar();

                // O comando retorna o id da tarefa cadastrada
                IdTarefa = (int) cmd.ExecuteScalar();

                // Testa se a tarefa foi realmente cadastrada no banco
                if (IdTarefa > 0)
                {
                    con.Desconectar();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MensagemErro = ex.Message;
            }
            finally
            {
                con.Desconectar();
            }

            return false;
        }

        public bool RemoverTarefa()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM TAREFA WHERE NOME = @NOME AND ID_USUARIO = @IDUSUARIO";
            cmd.Parameters.AddWithValue("@NOME", Nome);
            cmd.Parameters.AddWithValue("@IDUSUARIO", IdUsuario);

            try
            {
                cmd.Connection = con.Conectar();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Desconectar();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MensagemErro = ex.Message;
            }
            finally
            {
                con.Desconectar();
            }

            return false;
        }
    }
}
