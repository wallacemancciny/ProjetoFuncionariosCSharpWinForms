﻿using System;
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
    public partial class FormHomeFuncionarios : Form
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public FormHomeFuncionarios()
        {
            InitializeComponent();
        }


        private void FormHomeFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cesgranrioTestDBDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionariosTableAdapter.Fill(this.cesgranrioTestDBDataSet.Funcionarios);

            //Atualizar os registros do Grid ao carregar o form
            Funcionario Funcionario = new Funcionario();
            dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

            //Metodo para listar os items do combobox
            Funcionario Func = new Funcionario();
            Func.GetDepartamentosList();
            comboDepartamento.DataSource = Func.GetDepartamentosList();
            comboDepartamento.DisplayMember = "Nome";
            comboDepartamento.ValueMember = "Id";
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {   
            //Validar se digitou ao menos o nome do Funcionário
            if (textNomeCompleto.Text == "")
            {
                MessageBox.Show("Digite ao menos o nome do Funcionário");
            } else
            {
                //Salvar apenas se não tiver registro carregado na tela 
                if (textIdFunc.Text == "")
                {
                    Funcionario Funcionario = new Funcionario();
                    Funcionario.CadastrarFuncionario(textNomeCompleto.Text, textTelefone.Text, textEmail.Text, textDataNascimento.Text);
                    textNomeCompleto.Text = "";
                    textTelefone.Text = "";
                    textEmail.Text = "";
                    textDataNascimento.Text = "";

                    MessageBox.Show(Funcionario.mensagem);
                    dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();
                }
                else
                {
                    int IdFuncionarioInteiro = Convert.ToInt32(textIdFunc.Text);
                    Funcionario funcUpdate = new Funcionario();
                    funcUpdate.atualizarFuncionarioPorId(textNomeCompleto.Text, textTelefone.Text, textEmail.Text, textDataNascimento.Text, IdFuncionarioInteiro);
                    MessageBox.Show(funcUpdate.mensagem);
                    dataGridViewHome.DataSource = funcUpdate.GetFuncionariosRecord();
                }
            }  

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormDepartamento formdep = new FormDepartamento();
            formdep.Show();
        }

        private void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcionario Func = new Funcionario();
            Func.GetDepartamentosList();
            comboDepartamento.DataSource = Func.GetDepartamentosList();
            comboDepartamento.DisplayMember = "Nome";
            comboDepartamento.ValueMember = "Id";
            

            comboDepartamento.SelectedItem = comboDepartamento.ValueMember = "Id";


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Funcionario Func = new Funcionario();
            Func.GetDepartamentosList();
            comboDepartamento.DataSource = Func.GetDepartamentosList();
        }

        public void dataGridViewHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow registro = this.dataGridViewHome.Rows[e.RowIndex];
                
                //
                //string IdSelecionado = registro.Cells["Id"].Value.ToString();

                textIdFunc.Text = registro.Cells["Id"].Value.ToString();
                textNomeCompleto.Text = registro.Cells["Nome"].Value.ToString();
                textTelefone.Text = registro.Cells["Telefone"].Value.ToString();
                textEmail.Text = registro.Cells["Email"].Value.ToString();
                textDataNascimento.Text = registro.Cells["DataNascimento"].Value.ToString();

                //Testar pra saber se está trazendo o ID correto
                //MessageBox.Show(IdSelecionado);
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja deletar este funcionário?", "Cuidado", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                MessageBox.Show("Delete cancelado!");
            }
            else
            {
                Funcionario func = new Funcionario();
                

                if (textIdFunc.Text == "")
                {
                    MessageBox.Show("Você precisa selecionar alguém!");
                } else
                {
                    int IdFuncionarioInteiro = Convert.ToInt32(textIdFunc.Text);
                    func.deletarFuncionadioPorId(IdFuncionarioInteiro);
                    textIdFunc.Text = "";
                    textNomeCompleto.Text = "";
                    textTelefone.Text = "";
                    textEmail.Text = "";
                    textDataNascimento.Text = "";
                    MessageBox.Show("Funcionario Deletado com sucesso!");
                }
               
                
            }

            //Atualizar os registros do Grid ao carregar o form
            Funcionario Funcionario = new Funcionario();
            dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textIdFunc.Text = "";
            textNomeCompleto.Text = "";
            textTelefone.Text = "";
            textEmail.Text = "";
            textDataNascimento.Text = "";
        }
    }
    
}