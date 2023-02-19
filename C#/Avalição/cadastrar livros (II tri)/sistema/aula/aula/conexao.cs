using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula
{
    public class conexao
    {
        String jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";

        SqlConnection con = new SqlConnection();

        public conexao()
        {
         con.ConnectionString = jj;
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
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
