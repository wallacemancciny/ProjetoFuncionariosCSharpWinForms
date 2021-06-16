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
        public int UltimoIdFuncionarioInserido = 0;

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
                //cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                //this.mensagem = "Cadastrado com Sucesso!";
                //this.mensagem = Convert.ToString(last_insertid);
                //string last_insert_String = Convert.ToString(last_insertid);
                //return last_insert_String;
                this.UltimoIdFuncionarioInserido = last_insertid;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [Redação]";

            }
        }

        public int PercentComplete { get; set; }

        public DataTable BuscaAlunoRandon()
        {

            SqlCommand cmd = new SqlCommand
                ("select top 1 * from Alunos where Revisao = 0 order by NEWID()", conexao.conectar());
            DataTable dt = new DataTable();

            conexao.conectar();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conexao.desconectar();

            return dt;
        
        }

        public void SalvaNotaRevisadaAlunoAleatorio(int IdAlunoRandon, int Nota)
        {

            //Comando Sql
            cmd.CommandText = "update Alunos set Nota = @Nota, Revisao = 'true' where Id = @IdAlunoRandon";
            //parametros
            cmd.Parameters.AddWithValue("@IdAlunoRandon", IdAlunoRandon);
            cmd.Parameters.AddWithValue("@Nota", Nota);


            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Revisão efetuada com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [SalvaNotaRevisadaAlunoAleatorio]";

            }

        }


    }
}
