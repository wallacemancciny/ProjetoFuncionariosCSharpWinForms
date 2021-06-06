using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCesgranrioExame
{
    public class Departamento
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public void CadastrarDepartamento(String Nome, String Gestor, String Descricao)
        {
            //Comando Sql
            cmd.CommandText = "insert into Departamentos(Nome, Gestor, Descricao) values(@Nome, @Gestor, @Descricao)";
            //parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Gestor", Gestor);
            cmd.Parameters.AddWithValue("@Descricao", Descricao);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Departamento cadastrado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";

            }
        }

        public DataTable GetDepartamentosRecord()
        {

            SqlCommand cmd = new SqlCommand("select * from Departamentos order by Id desc", conexao.conectar());
            DataTable dt = new DataTable();

            conexao.conectar();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conexao.desconectar();

            return dt;

        }

        public void DeletarDepartamento(int Id)
        {
            //Comando Sql
            cmd.CommandText = "delete from Departamentos where Id = @Id";
            //parametros
            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Departamento deletado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";

            }
        }

        public DataTable DepartamentoEmUso(int FuncionarioId)
            {
            SqlCommand cmd = new SqlCommand("select * from Departamentos order by Id desc", conexao.conectar());
            DataTable dt = new DataTable();

            conexao.conectar();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conexao.desconectar();

            return dt;
        }

        
    }

    
}
