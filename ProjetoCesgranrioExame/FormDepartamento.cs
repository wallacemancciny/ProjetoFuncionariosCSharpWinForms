using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoCesgranrioExame
{
    public partial class FormDepartamento : Form
    {
        Departamento Depart = new Departamento();
        public FormDepartamento()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textName.Text == "")
            {
                MessageBox.Show("Digite pelo menos o nome do Departamento!");  
            } else
            {
                Departamento Dep = new Departamento();
                Dep.CadastrarDepartamento(textName.Text, textGestor.Text, textDescricao.Text);
                MessageBox.Show(Dep.mensagem);

                //limpando os campos
                textIdDepartamento.Text = "";
                textName.Text = "";
                textGestor.Text = "";
                textDescricao.Text = "";

                //instanciando departamento pra carregar a gridview após salvar um dado
                dataGridViewDepartamento.DataSource = Depart.GetDepartamentosRecord();
            }


            
        }

        private void FormDepartamento_Load(object sender, EventArgs e)
        {
            dataGridViewDepartamento.DataSource = Depart.GetDepartamentosRecord();
        }

        private void dataGridViewDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow registroClicado = this.dataGridViewDepartamento.Rows[e.RowIndex];

                //variavel que está guardando o id do departamento clicado no GRID
                string IdSelecionado = registroClicado.Cells["Id"].Value.ToString();
                //Esses registros estão sendo populados para dentro dos textbox do form
                textIdDepartamento.Text = registroClicado.Cells["Id"].Value.ToString();
                textName.Text = registroClicado.Cells["Nome"].Value.ToString();
                textGestor.Text = registroClicado.Cells["Gestor"].Value.ToString();
                textDescricao .Text = registroClicado.Cells["Descricao"].Value.ToString();


                //Testar pra saber se está trazendo o ID correto
                //MessageBox.Show(IdSelecionado);
            }
        }
        
        private void btnDeletarDepartamento_Click_1(object sender, EventArgs e)
        {
            if (textIdDepartamento.Text == "")
            {
                MessageBox.Show("Você precisa selecionar um departamento antes de deletar!");
            } else
            {
                Departamento deletarDep = new Departamento();
                int IdDepartamentoToInt = Convert.ToInt32(textIdDepartamento.Text);
                deletarDep.DeletarDepartamento(IdDepartamentoToInt);

                MessageBox.Show(deletarDep.mensagem);

                //limpando os campos do form
                textIdDepartamento.Text = "";
                textName.Text = "";
                textGestor.Text = "";
                textDescricao.Text = "";

                //instanciando departamento pra carregar a gridview após salvar um dado
                dataGridViewDepartamento.DataSource = deletarDep.GetDepartamentosRecord();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textIdDepartamento.Text = "";
            textName.Text = "";
            textGestor.Text = "";
            textDescricao.Text = "";
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            Departamento VerificaFKFuncionario = new Departamento();

            int IdDepartamentoToInt = Convert.ToInt32(textIdDepartamento.Text);
            VerificaFKFuncionario.VerificaDepartamentoEmUso(IdDepartamentoToInt);

            if (VerificaFKFuncionario.DepartamentoEmUso == true)
            {
                MessageBox.Show("Este departamento já esta em uso e não pode ser deletado!");
            }

            
            

        }
    }
}
