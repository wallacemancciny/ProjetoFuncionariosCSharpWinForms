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
            //Atualizar os registros do Grid ao carregar o form
            Funcionario Funcionario = new Funcionario();
            dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

            //Metodo para listar os items do Departamento no combobox
            Funcionario Func = new Funcionario();
            Func.GetDepartamentosList();
            comboDepartamento.DataSource = Func.GetDepartamentosList();
            comboDepartamento.ValueMember = "Id";
            comboDepartamento.DisplayMember = "Nome";



        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validar se digitou ao menos o nome do Funcionário
            if (textNomeCompleto.Text == "" || textCPF.Text == "")
            {
                MessageBox.Show("Digite ao menos o NOME e CPF do Funcionário");
            }
            else
            {
                //Salvar apenas se não tiver registro carregado na tela 
                if (textIdFunc.Text == "")
                {
                    //Pegando valor do combo box selecionado, convertendo e salvando em uma variavel
                    String IdDepartamentoSelecionadoString = Convert.ToString(comboDepartamento.SelectedValue);
                    //convertendo para Inteiro
                    int IdDepartamentoSelecionadoInt = Convert.ToInt32(IdDepartamentoSelecionadoString);

                    Funcionario Funcionario = new Funcionario();
                    Funcionario.CadastrarFuncionario(textNomeCompleto.Text,textCPF.Text, textTelefone.Text, textEmail.Text, textDataNascimento.Text, IdDepartamentoSelecionadoInt);
                    textNomeCompleto.Text = "";
                    textCPF.Text = "";
                    textTelefone.Text = "";
                    textEmail.Text = "";
                    textDataNascimento.Text = "";

                    MessageBox.Show(Funcionario.mensagem);
                    dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();
                }
                else
                {
                    //Pegando valor do combo box selecionado, convertendo e salvando em uma variavel
                    String IdDepartamentoSelecionadoString = Convert.ToString(comboDepartamento.SelectedValue);
                    //convertendo para Inteiro
                    int IdDepartamentoSelecionadoInt = Convert.ToInt32(IdDepartamentoSelecionadoString);
                    //caso tenha Id do funcionario carregado no formulário ele vai atualizar apenas.
                    int IdFuncionarioInteiro = Convert.ToInt32(textIdFunc.Text);
                    Funcionario funcUpdate = new Funcionario();
                    funcUpdate.atualizarFuncionarioPorId(textNomeCompleto.Text, textCPF.Text,textTelefone.Text, textEmail.Text, textDataNascimento.Text, IdFuncionarioInteiro, IdDepartamentoSelecionadoInt);
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

        private void ComboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Funcionario Func = new Funcionario();
            //Func.GetDepartamentosList();
            //comboDepartamento.DataSource = Func.GetDepartamentosList();
            //comboDepartamento.DisplayMember = "Nome";
            //comboDepartamento.ValueMember = "Id";

        }

        private void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            String IdDepartamentoSelecionado = Convert.ToString(comboDepartamento.SelectedValue);
            //LabIdDepartamento.Text = IdDepartamentoSelecionado;


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
                DataGridViewRow registroClicado = this.dataGridViewHome.Rows[e.RowIndex];

                //
                //string IdSelecionado = registro.Cells["Id"].Value.ToString();

                textIdFunc.Text = registroClicado.Cells["Id"].Value.ToString();
                textNomeCompleto.Text = registroClicado.Cells["Nome"].Value.ToString();
                textCPF.Text = registroClicado.Cells["CPF"].Value.ToString();
                textTelefone.Text = registroClicado.Cells["Telefone"].Value.ToString();
                textEmail.Text = registroClicado.Cells["Email"].Value.ToString();
                textDataNascimento.Text = registroClicado.Cells["DataNascimento"].Value.ToString();
                comboDepartamento.Text = registroClicado.Cells["DepartamentoId"].Value.ToString();
                

                //Testar pra saber se está trazendo o ID correto
                //MessageBox.Show(IdSelecionado);
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            if (textIdFunc.Text == "")
            {
                MessageBox.Show("Você precisa selecionar alguém!");
            } else
            {
                if (MessageBox.Show("Tem certeza que deseja deletar este funcionário?", "Cuidado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    MessageBox.Show("Delete cancelado!");
                }
                else
                {
                    Funcionario func = new Funcionario();
                    int IdFuncionarioInteiro = Convert.ToInt32(textIdFunc.Text);
                    func.deletarFuncionadioPorId(IdFuncionarioInteiro);
                    textIdFunc.Text = "";
                    textNomeCompleto.Text = "";
                    textCPF.Text = "";
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
            textCPF.Text = "";
            textTelefone.Text = "";
            textEmail.Text = "";
            textDataNascimento.Text = "";
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            //atualizar grid com a pesquisa do funcionario
            Funcionario pesquisaFun = new Funcionario();
            dataGridViewHome.DataSource = pesquisaFun.PesquisarFuncionarios(textPesquisaFuncionario.Text);

        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            //Atualizar os registros do Grid ao carregar o form
            Funcionario Funcionario = new Funcionario();
            dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();
        }
    }
}
