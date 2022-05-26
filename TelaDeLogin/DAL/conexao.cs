using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TelaDeLogin.DAL
{
    public class conexao
    {
        static string serverName = "127.0.0.1";  //localhost
        static string port = "5432";             //porta default
        static string userName = "postgres";     //nome do administrador
        static string password = "102030";     //senha do administrador
        static string databaseName = "PIM"; //nome do banco de dados
        NpgsqlConnection pgsqlConnection = null;
        string connString = null;

        NpgsqlConnection con = new NpgsqlConnection();
        public conexao()
        {
            con.ConnectionString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                           serverName, port, userName, password, databaseName);
        }

        public NpgsqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
        }
    }
}
