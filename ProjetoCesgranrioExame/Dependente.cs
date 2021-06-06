using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCesgranrioExame
{
    public class Dependente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public void CadastrarDependente(String Nome1, String Nome2, int FuncionarioId)
        {
            //Comando Sql
            cmd.CommandText = "insert into Dependentes(Nome1,Nome2,FuncionarioId) values(@Nome1,@Nome2,@FuncionarioId)";
            //parametros
            cmd.Parameters.AddWithValue("@Nome1", Nome1);
            cmd.Parameters.AddWithValue("@Nome2", Nome2);
            cmd.Parameters.AddWithValue("@FuncionarioId", FuncionarioId);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Dependente cadastrado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [CadastrarFuncionario]";

            }

        }

        public void AtualizarDependente(String Nome1, String Nome2, int FuncionarioId)
        {
            //Comando Sql
            cmd.CommandText = "update Dependentes set Nome1 = @Nome1, Nome2 = @Nome2 where FuncionarioId = @FuncionarioId";
            //parametros
            cmd.Parameters.AddWithValue("@Nome1", Nome1);
            cmd.Parameters.AddWithValue("@Nome2", Nome2);
            cmd.Parameters.AddWithValue("@FuncionarioId", FuncionarioId);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Dependente atualizado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados [CadastrarFuncionario]";

            }
        }
    }

    
}
