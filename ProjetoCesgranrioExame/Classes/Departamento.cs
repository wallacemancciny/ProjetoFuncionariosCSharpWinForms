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
        public bool DepartamentoEmUso = false;

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

        public void VerificaDepartamentoEmUso(int FuncionarioId)
        {
            //Comando Sql
            cmd.CommandText = "select top(1) DepartamentoId from Funcionarios where  DepartamentoId = @FuncionarioId";
            //parametros
            cmd.Parameters.AddWithValue("@FuncionarioId", FuncionarioId);
            



            try
            {   //TENTA VERIFICAR SE A TABELA DEPARTAMENTO ESTÁ SENDO UTILIZADA NA TABELA FUNCIONARIOS.
                //Se filtrar pelo id do departamento e chegar valor é porque está em uso.
                //conectar com banco
                cmd.Connection = conexao.conectar();
                
                cmd.ExecuteNonQuery();
                //executa query e retorna numeros de linhas afetadas
                //string buscaIdFuncionario = cmd.ExecuteNonQuery().ToString();

                SqlDataReader ex = cmd.ExecuteReader();
                

                if (ex.HasRows == true ) 
                {
                    this.DepartamentoEmUso = true;
                    this.mensagem = "Departamento está em uso!";
                } else
                {
                    this.mensagem = "Departamento nunca usado!";
                }

                //desconectar
                conexao.desconectar();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [VerificaDepartamentoEmUso]";

            }
        }

        
    }

    
}
