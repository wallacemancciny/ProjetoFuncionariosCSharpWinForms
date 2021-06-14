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
        public String UltimoIdFuncionarioInserido = "";

        public void GerarAlunos(String Nome, bool Revisao)
        {
            //Comando Sql
            cmd.CommandText = "insert into Alunos (Nome, Revisao) values (@Nome, @Revisao) SELECT SCOPE_IDENTITY()";
            //parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);

            cmd.Parameters.AddWithValue("@Revisao", Revisao);



            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();

                //executar comando, pega o ultimo id inserido na tabela e guarda na variavel last_insertid
                int last_insertid = int.Parse(cmd.ExecuteScalar().ToString());
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                //this.mensagem = "Cadastrado com Sucesso!";
                //this.mensagem = Convert.ToString(last_insertid);
                string last_insert_String = Convert.ToString(last_insertid);
                //return last_insert_String;
                this.UltimoIdFuncionarioInserido = last_insert_String;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [Redação]";

            }
        }

        public int PercentComplete { get; set; }

    }
}
