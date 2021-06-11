using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCesgranrioExame
{
    public class Redacao
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public void GerarAlunos(String Nome, int Nota, bool Revisao)
        {
            //Comando Sql
            cmd.CommandText = "insert into Alunos (Nome, Nota, Revisao) values (@Nome, @Nota, @Revisao)";
            //parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Nota", Nota);
            cmd.Parameters.AddWithValue("@Revisao", Revisao);



            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                //this.mensagem = "Cadastrado com Sucesso!";
                
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [Redação]";

            }
        }

        public int PercentComplete { get; set; }

    }
}
