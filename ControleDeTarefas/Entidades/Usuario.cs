using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControleDeTarefas.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public string MensagemErro { get; private set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;

            IdUsuario = 0;

            /* Achei interessante inicar vazia pra testar isso depois */
            MensagemErro = "";
        }

        public bool CadastrarUsuario()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            
            try {

                cmd.CommandText = "INSERT INTO USUARIO OUTPUT INSERTED.IDUSUARIO VALUES(@LOGIN, @SENHA)";
                cmd.Parameters.AddWithValue("@LOGIN", Login);
                cmd.Parameters.AddWithValue("@SENHA", Senha);

                cmd.Connection = con.Conectar();

                /* Executa o comando do banco
                 * Testa se o registro foi feito com sucesso
                 */ 
                if ((int) cmd.ExecuteScalar() > 0)
                {
                    return true;
                }
                
            }
            catch (SqlException ex)
            {
                MensagemErro += ex.Message;
            }
            finally
            {
                con.Desconectar();
            }

            return false;
        }

        public bool VerificarUsuario()
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            MensagemErro = "";

            cmd.CommandText = "SELECT IDUSUARIO, LOGIN, SENHA FROM USUARIO WHERE LOGIN = @LOGIN AND SENHA = @SENHA";
            cmd.Parameters.AddWithValue("@LOGIN", Login);
            cmd.Parameters.AddWithValue("@SENHA", Senha);

            try
            {
                cmd.Connection = con.Conectar();

                dr = cmd.ExecuteReader();

                //IdUsuario = (int) cmd.ExecuteScalar();

                if (dr.HasRows)
                {
                    
                    while (dr.Read()) {
                        IdUsuario = (int) dr["IDUSUARIO"];
                    }
                    
                    con.Desconectar();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MensagemErro += ex.Message;
            }
            finally
            {
                con.Desconectar();
            }

            return false;
        }
    }
}
