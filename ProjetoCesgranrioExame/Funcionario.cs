using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCesgranrioExame 
{
    public class Funcionario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public void CadastrarFuncionario(String Nome, String Telefone, String Email, String DataNascimento, int IdDepartamento)
        {

            //Comando Sql
            cmd.CommandText = "insert into Funcionarios(Nome,Telefone,Email,DataNascimento,DepartamentoId) values(@Nome,@Telefone,@Email,@DataNascimento,@IdDepartamento)";
            //parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
            cmd.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [CadastrarFuncionario]";

            }

        }

        public DataTable GetFuncionariosRecord()
        {
            
            SqlCommand cmd = new SqlCommand("select * from Funcionarios order by Id desc", conexao.conectar());
            DataTable dt = new DataTable();

            conexao.conectar();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conexao.desconectar();

            return dt;
            
        }
        public DataTable GetDepartamentosList()
        {

            SqlCommand cmd = new SqlCommand("select * from Departamentos order by id desc", conexao.conectar());
            DataTable dt = new DataTable();

            conexao.conectar();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conexao.desconectar();

            return dt;

        }

        public void deletarFuncionadioPorId(int Id)
        {
            //Comando Sql
            cmd.CommandText = "delete from funcionarios where Id = @Id";
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
                this.mensagem = "Funcionario removido com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";

            }
        }

        public void atualizarFuncionarioPorId(String Nome, String Telefone, String Email, String DataNascimento, int Id, int DepartamentoId)
        {

            //Comando Sql
            cmd.CommandText = "update Funcionarios set Nome = @Nome, Telefone = @Telefone ,Email = @Email, DataNascimento = @DataNascimento, DepartamentoId = @DepartamentoId where Id = @Id";
            //parametros
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
            cmd.Parameters.AddWithValue("@DepartamentoId", DepartamentoId);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Funcionario atualizado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";

            }

        }

    }
}
