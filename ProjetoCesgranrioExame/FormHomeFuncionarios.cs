using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace ProjetoCesgranrioExame
{
    public partial class FormHomeFuncionarios : Form
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        //public String idDependenteFuncionario = "";
        

        public FormHomeFuncionarios()
        {
            InitializeComponent();
        }



        private void FormHomeFuncionarios_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow registroDeDado in dataGridViewHome.Rows)
            {
                if (registroDeDado.Cells[1].Value.Equals("Leo"))
                {
                   registroDeDado.Cells[1].Style.Font = new System.Drawing.Font(dataGridViewHome.Font, System.Drawing.FontStyle.Bold);
                   registroDeDado.Cells[1].Style.BackColor = Color.Red;

                }
            }



            //ESCONDER O ID DO FUNCIONARIO
            textIdFunc.Hide();
            ////ESCONDER BOTÃO DO ID DO DEPENDENTEFUNCIONARIO
            textIdDependenteFuncionario.Hide();

            
            ////Atualizar os registros do Grid ao carregar o form
            //Funcionario Funcionario = new Funcionario();
            //dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

            //METODO PRA LISTAR A TABELA NA GRID
            DadosNaGrid();


            //Metodo para listar os items do Departamento no combobox
            Funcionario Func = new Funcionario();
            Func.GetDepartamentosList();
            comboDepartamento.DataSource = Func.GetDepartamentosList();
            comboDepartamento.ValueMember = "Id";
            comboDepartamento.DisplayMember = "Nome";



        }

        public void DadosNaGrid()
        {
            //AQUI DIZ QUANTAS COLUNAS A GRID VAI TER
            dataGridViewHome.AutoGenerateColumns = false;
            dataGridViewHome.ColumnCount = 4;
            //AQUI DIZ A COLUNA E O VALOR QUE VEM NA CONSULTA DO GET DEPARTAMENTO LIST
            dataGridViewHome.Columns[0].HeaderText = "Id";
            dataGridViewHome.Columns[0].DataPropertyName = "Id";

            dataGridViewHome.Columns[1].HeaderText = "Nome";
            dataGridViewHome.Columns[1].DataPropertyName = "Nome";

            dataGridViewHome.Columns[2].HeaderText = "CPF";
            dataGridViewHome.Columns[2].DataPropertyName = "CPF";

            dataGridViewHome.Columns[3].HeaderText = "Telefone";
            dataGridViewHome.Columns[3].DataPropertyName = "Telefone";


            //INSTANCIA A CLASSE FUNCIONARIO
            Funcionario GetListFunc = new Funcionario();
            //CHAMA O METODO QUE BUSCA TODOS OS FUNCIONARIOS COM JOIN E ACOPLA NA GRID, MAS VAI MOSTRAR APENAS AS COLUNAS INFORMADAS ACIMA
            dataGridViewHome.DataSource = GetListFunc.GetFuncionariosRecord();

            //INSTANCIA A CLASSE QUE MANIPULA O BOTÃO NA GRID
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //ADICIONA OS PARAMETROS DO BOTÃO
            btn.HeaderText = "";
            btn.Name = "btnSelectFunc";
            btn.Text = "Selecionar";
            btn.UseColumnTextForButtonValue = true;
        
            dataGridViewHome.Columns.Add(btn);


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

                    //instancia classe funcionario e chama o metodo para cadastrar
                    Funcionario Funcionario = new Funcionario();
                    Funcionario.CadastrarFuncionario(textNomeCompleto.Text,textCPF.Text, textTelefone.Text, textEmail.Text, textDataNascimento.Text, IdDepartamentoSelecionadoInt);

                    //Pega o ultimo ID inserido no banco após cadastramento do Funcionario
                    string UltimaIdCad = Funcionario.UltimoIdFuncionarioInserido;
                    //Converte ultimo id cadastradado para inteiro
                    int UltimaIdCadToInt = Convert.ToInt32(UltimaIdCad);


                    //instancia a classe dependente e chama o metodo para cadastrar
                    Dependente cadDependente = new Dependente();
                    cadDependente.CadastrarDependente(textDependente1.Text, textDependente2.Text, UltimaIdCadToInt);

                    textNomeCompleto.Text = "";
                    textCPF.Text = "";
                    textTelefone.Text = "";
                    textEmail.Text = "";
                    textDataNascimento.Text = "";
                    textDependente1.Text = "";
                    textDependente2.Text = "";

                    MessageBox.Show(Funcionario.mensagem);
                    dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();
                }
                else
                {

                    //CONDIÇÃO ATUALIZAR O FUNCIONARIO
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

                    //Se ID dependenteFuncionario tiver preenchido ele vai apenas atualizar, caso contrario ele vai criar os dependentes
                    if (textIdDependenteFuncionario.Text != "")
                    {
                        //instancia a classe dependente e depois pega
                        Dependente atualizaDependente = new Dependente();

                        //Cadastra os dependentes no banco
                        atualizaDependente.AtualizarDependente(textDependente1.Text, textDependente2.Text, IdFuncionarioInteiro);
                        //aproveia o metodo funcUpdate pra atualizar a GRID
                        dataGridViewHome.DataSource = funcUpdate.GetFuncionariosRecord();
                    }
                    else
                    {
                        Dependente criaDependente = new Dependente();
                        criaDependente.CadastrarDependente(textDependente1.Text, textDependente2.Text, IdFuncionarioInteiro);
                        dataGridViewHome.DataSource = funcUpdate.GetFuncionariosRecord();
                    }
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
            String IdDepartamentoSelecionado = Convert.ToString(comboDepartamento.SelectedValue);
            //LabIdDepartamento.Text = IdDepartamentoSelecionado;


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Funcionario Func = new Funcionario();
            Func.GetDepartamentosList();
            comboDepartamento.DataSource = Func.GetDepartamentosList();
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
                    textDependente1.Text = "";
                    textDependente2.Text = "";


                    btnSave.Text = "Salvar";
                    
                    MessageBox.Show("Funcionario Deletado com sucesso!");
                    


                }
            }

            

            //Atualizar os registros do Grid ao carregar o form
            Funcionario Funcionario = new Funcionario();
            dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Salvar";

            MessageBox.Show("Formulário limpo!");
            textIdFunc.Text = "";
            textNomeCompleto.Text = "";
            textCPF.Text = "";
            textTelefone.Text = "";
            textEmail.Text = "";
            textDataNascimento.Text = "";
            textDependente1.Text = "";
            textDependente2.Text = "";
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

        private void textPesquisaFuncionario_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void dataGridViewHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)

               
            {
                int IdFuncionario = (int) dataGridViewHome.SelectedRows[0].Cells[0].Value;


                Funcionario buscaFuncPorId = new Funcionario();
                var dadosFuncionario = buscaFuncPorId.GetFuncionariosRecordById(IdFuncionario);
                textCPF.Text = dadosFuncionario.Rows[0]["CPF"].ToString();
                textDataNascimento.Text = dadosFuncionario.Rows[0]["DataNascimento"].ToString();
                textEmail.Text = dadosFuncionario.Rows[0]["Email"].ToString();
                textNomeCompleto.Text = dadosFuncionario.Rows[0]["Nome"].ToString();


                textIdDependenteFuncionario.Text = dadosFuncionario.Rows[0]["DependenteFuncionarioId"].ToString();
                textIdFunc.Text = dadosFuncionario.Rows[0]["Id"].ToString();
                textNomeCompleto.Text = dadosFuncionario.Rows[0]["Nome"].ToString();
                textCPF.Text = dadosFuncionario.Rows[0]["CPF"].ToString();
                textTelefone.Text = dadosFuncionario.Rows[0]["Telefone"].ToString();
                textEmail.Text = dadosFuncionario.Rows[0]["Email"].ToString();
                textDataNascimento.Text = dadosFuncionario.Rows[0]["DataNascimento"].ToString();
                comboDepartamento.Text = dadosFuncionario.Rows[0]["DepartamentoId"].ToString();
                textDependente1.Text = dadosFuncionario.Rows[0]["Dependente1"].ToString();
                textDependente2.Text = dadosFuncionario.Rows[0]["Dependente2"].ToString();

                btnSave.Text = "Atualizar";

            }
            
            
            ////Ao clicar na celula do GRID o dado vai aparecer nos campos do formulario.
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow registroClicado = this.dataGridViewHome.Rows[e.RowIndex];

            //    //
            //    //string IdSelecionado = registro.Cells["Id"].Value.ToString();
            //    //string idDependenteFuncionario = registroClicado.Cells["DependenteFuncionarioId"].Value.ToString();
            //    textIdDependenteFuncionario.Text = registroClicado.Cells["DependenteFuncionarioId"].Value.ToString();
            //    textIdFunc.Text = registroClicado.Cells["Id"].Value.ToString();
            //    textNomeCompleto.Text = registroClicado.Cells["Nome"].Value.ToString();
            //    textCPF.Text = registroClicado.Cells["CPF"].Value.ToString();
            //    textTelefone.Text = registroClicado.Cells["Telefone"].Value.ToString();
            //    textEmail.Text = registroClicado.Cells["Email"].Value.ToString();
            //    textDataNascimento.Text = registroClicado.Cells["DataNascimento"].Value.ToString();
            //    comboDepartamento.Text = registroClicado.Cells["DepartamentoId"].Value.ToString();
            //    textDependente1.Text = registroClicado.Cells["Dependente1"].Value.ToString();
            //    textDependente2.Text = registroClicado.Cells["Dependente2"].Value.ToString();

            //MUDA O NOME DO BOTÃO SALVAR PARA ATUALIZAR
            //    if (textIdFunc.Text != "")
            //    {
            //        btnSave.Text = "Atualizar";
            //    }

            //    //Testar pra saber se está trazendo o ID correto
            //    //MessageBox.Show(IdSelecionado);
            //}
        }
    }
}
