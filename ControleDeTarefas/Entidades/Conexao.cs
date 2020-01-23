using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControleDeTarefas.Entidades
{
    public class Conexao
    {
        //Objeto de conexão com o banco de dados
        private SqlConnection con = new SqlConnection();


        public Conexao()
        {
            //Caminho do banco de dados
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbTime.mdf;Integrated Security=True";
        }


        public SqlConnection Conectar()
        {
            //testa se a conexão está fechada
            if (con.State == System.Data.ConnectionState.Closed)
            {
                //abre a conexão
                con.Open();
            }

            //retorna a conexão
            return con;
        }


        public void Desconectar()
        {
            //testa se a conexão está aberta
            if(con.State == System.Data.ConnectionState.Open)
            {
                //fecha a conexão
                con.Close();
            }
        }
    }
}
