using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCesgranrioExame
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {   
            //CONEXAO LOCAL
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=CesgranrioTestDB;Integrated Security=True;
            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            ////CONEXAO NA AZURE SQL SERVER
            //    con.ConnectionString = "Data Source=serverdbwallacemanccinyazure.database.windows.net;" +
            //    "Initial Catalog=dbAzureWallaceExame;User ID=wallroot;Password=Brna@7171;" +
            //    "Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;" +
            //    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }


        //Metodo Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        //internal class Conectar
        // {
        // }
    }
}
