using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCesgranrioExame
{
    public partial class GerenciarFuncionario : UserControl
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";


        public GerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void GerenciarFuncionario_Load(object sender, EventArgs e)
        {
            
            //ESCONDER O ID DO FUNCIONARIO
            textIdFunc.Hide();
            ////ESCONDER BOTÃO DO ID DO DEPENDENTEFUNCIONARIO
            textIdDependenteFuncionario.Hide();


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
            dataGridViewHome.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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

            PintarCelulas();


        }

        public void PintarCelulas()
        {
            foreach (DataGridViewRow registroDeDado in dataGridViewHome.Rows)
            {
                string registroTrim = registroDeDado.Cells[1].Value.ToString().Trim();
                if (registroTrim.Substring(0, 1) == "a" || registroTrim.Substring(0, 1) == "A")
                {
                    //Font font = new Font(dataGridViewHome.Font, FontStyle.Regular);
                    //registroDeDado.Cells[1].Style.Font = font = #FFFFF;

                    registroDeDado.Cells[1].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    registroDeDado.Cells[1].Style.BackColor = Color.Orange;
                    registroDeDado.Cells[1].Style.BackColor = Color.Orange;
                    registroDeDado.Cells[1].Style.BackColor = Color.Orange;
                    registroDeDado.Cells[1].Style.BackColor = Color.Orange;
                }
            }
        }



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //Validar se digitou ao menos o nome do Funcionário
            if (textNomeCompleto.Text == "" || maskedTextCPF.Text == "")
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
                    Funcionario.CadastrarFuncionario(textNomeCompleto.Text, maskedTextCPF.Text, textTelefone.Text, textEmail.Text, maskTextDataNascimento.Text, IdDepartamentoSelecionadoInt);

                    //Pega o ultimo ID inserido no banco após cadastramento do Funcionario
                    string UltimaIdCad = Funcionario.UltimoIdFuncionarioInserido;
                    //Converte ultimo id cadastradado para inteiro
                    int UltimaIdCadToInt = Convert.ToInt32(UltimaIdCad);


                    //instancia a classe dependente e chama o metodo para cadastrar
                    Dependente cadDependente = new Dependente();
                    cadDependente.CadastrarDependente(textDependente1.Text, textDependente2.Text, UltimaIdCadToInt);

                    textNomeCompleto.Text = "";
                    maskedTextCPF.Text = "";
                    textTelefone.Text = "";
                    textEmail.Text = "";
                    maskTextDataNascimento.Text = "";
                    textDependente1.Text = "";
                    textDependente2.Text = "";

                    MessageBox.Show(Funcionario.mensagem);

                    dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

                    PintarCelulas();
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
                    funcUpdate.atualizarFuncionarioPorId(textNomeCompleto.Text, maskedTextCPF.Text, textTelefone.Text, textEmail.Text, maskTextDataNascimento.Text, IdFuncionarioInteiro, IdDepartamentoSelecionadoInt);
                    MessageBox.Show(funcUpdate.mensagem);

                    dataGridViewHome.DataSource = funcUpdate.GetFuncionariosRecord();

                    PintarCelulas();

                    //Se ID dependenteFuncionario tiver preenchido ele vai apenas atualizar, caso contrario ele vai criar os dependentes
                    if (textIdDependenteFuncionario.Text != "")
                    {
                        //instancia a classe dependente e depois pega
                        Dependente atualizaDependente = new Dependente();

                        //Cadastra os dependentes no banco
                        atualizaDependente.AtualizarDependente(textDependente1.Text, textDependente2.Text, IdFuncionarioInteiro);
                        //aproveia o metodo funcUpdate pra atualizar a GRID
                        dataGridViewHome.DataSource = funcUpdate.GetFuncionariosRecord();

                        PintarCelulas();
                    }
                    else
                    {
                        Dependente criaDependente = new Dependente();
                        criaDependente.CadastrarDependente(textDependente1.Text, textDependente2.Text, IdFuncionarioInteiro);
                        dataGridViewHome.DataSource = funcUpdate.GetFuncionariosRecord();

                        PintarCelulas();
                    }
                }
            }

        }

        private void BtnDepartamento_Click(object sender, EventArgs e)
        {
            FormDepartamento formdep = new FormDepartamento();
            formdep.Show();
        }

        private void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            String IdDepartamentoSelecionado = Convert.ToString(comboDepartamento.SelectedValue);
            //LabIdDepartamento.Text = IdDepartamentoSelecionado;

        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            {
                if (textIdFunc.Text == "")
                {
                    MessageBox.Show("Você precisa selecionar alguém!");
                }
                else
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

                        

                        btnSave.Text = "Salvar";

                        textIdFunc.Text = "";
                        textNomeCompleto.Text = "";
                        maskedTextCPF.Text = "";
                        textTelefone.Text = "";
                        textEmail.Text = "";
                        maskTextDataNascimento.Text = "";
                        textDependente1.Text = "";
                        textDependente2.Text = "";

                        //Atualizar os registros do Grid ao carregar o form
                        Funcionario Funcionario = new Funcionario();
                        dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

                        PintarCelulas();

                        MessageBox.Show("Funcionario Deletado com sucesso!");

                    }
                }



                

            }
        }

        private void dataGridViewHome_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.ColumnIndex >= 0)

                {
                    int IdFuncionario = (int)dataGridViewHome.SelectedRows[0].Cells[0].Value;

                    Funcionario buscaFuncPorId = new Funcionario();
                    var dadosFuncionario = buscaFuncPorId.GetFuncionariosRecordById(IdFuncionario);
                    //maskedTextCPF.Text = dadosFuncionario.Rows[0]["CPF"].ToString();
                    //textDataNascimento.Text = dadosFuncionario.Rows[0]["DataNascimento"].ToString();
                    //textEmail.Text = dadosFuncionario.Rows[0]["Email"].ToString();
                    //textNomeCompleto.Text = dadosFuncionario.Rows[0]["Nome"].ToString();


                    textIdDependenteFuncionario.Text = dadosFuncionario.Rows[0]["DependenteFuncionarioId"].ToString();
                    textIdFunc.Text = dadosFuncionario.Rows[0]["Id"].ToString();
                    textNomeCompleto.Text = dadosFuncionario.Rows[0]["Nome"].ToString();
                    maskedTextCPF.Text = dadosFuncionario.Rows[0]["CPF"].ToString();
                    textTelefone.Text = dadosFuncionario.Rows[0]["Telefone"].ToString();
                    textEmail.Text = dadosFuncionario.Rows[0]["Email"].ToString();
                    maskTextDataNascimento.Text = dadosFuncionario.Rows[0]["DataNascimento"].ToString();
                    comboDepartamento.Text = dadosFuncionario.Rows[0]["DepartamentoId"].ToString();
                    textDependente1.Text = dadosFuncionario.Rows[0]["Dependente1"].ToString();
                    textDependente2.Text = dadosFuncionario.Rows[0]["Dependente2"].ToString();

                    btnSave.Text = "Atualizar";
                }

            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnSave.Text = "Salvar";

            textIdFunc.Text = "";
            textNomeCompleto.Text = "";
            maskedTextCPF.Text = "";
            textTelefone.Text = "";
            textEmail.Text = "";
            maskTextDataNascimento.Text = "";
            textDependente1.Text = "";
            textDependente2.Text = "";

            MessageBox.Show("Formulário limpo!");
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            Funcionario Func = new Funcionario();
            Func.GetDepartamentosList();
            comboDepartamento.DataSource = Func.GetDepartamentosList();

            PintarCelulas();
        }

        private void btnPesquisarFuncionario_Click_1(object sender, EventArgs e)
        {            
                //atualizar grid com a pesquisa do funcionario
                Funcionario pesquisaFun = new Funcionario();
                dataGridViewHome.DataSource = pesquisaFun.PesquisarFuncionarios(textPesquisaFuncionario.Text);
        }

        private void btnLimparPesquisa_Click_1(object sender, EventArgs e)
        {
                //Atualizar os registros do Grid ao carregar o form
                Funcionario Funcionario = new Funcionario();
                dataGridViewHome.DataSource = Funcionario.GetFuncionariosRecord();

        }
        //public static Bitmap ConvertTextToImage(string txt, string fontname, int fontsize, Color bgcolor, Color fcolor, int width, int Height)
        //{
        //    try
        //    {
        //        //cria o bitmap
        //        Bitmap bmp = new Bitmap(width, Height);
        //        using (Graphics graphics = Graphics.FromImage(bmp))
        //        {
        //            //define a fonte e escreve o texto
        //            Font font = new Font(fontname, fontsize);
        //            graphics.FillRectangle(new SolidBrush(bgcolor), 0, 0, bmp.Width, bmp.Height);
        //            graphics.DrawString(txt, font, new SolidBrush(fcolor), 0, 0);
        //            graphics.Flush();
        //            font.Dispose();
        //            graphics.Dispose();
        //        }
        //        return bmp;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        private void btnExportarTxt_Click_1(object sender, EventArgs e)
        {

                if (Directory.Exists(@"C:\folder\") && File.Exists("Text.txt"))
                {
                    ExportarDadosGridView();

                }
                else
                {
                    Directory.CreateDirectory(@"C:\folder\");
                    File.Create("Text.txt");

                    ExportarDadosGridView();
                }
        }



        public void ExportarDadosGridView()
        {
            TextWriter writer = new StreamWriter(@"C:\folder\Text.txt");

            

            

            //CABEÇALHO DAS TABELAS DO GRID QUE SERÃO EXPORTADOS
            //writer.Write(dataGridViewHome.Columns[0].HeaderText = "Id");
            writer.Write((dataGridViewHome.Columns[0].DataPropertyName = "Id") + ";");

            //writer.Write(dataGridViewHome.Columns[1].HeaderText = "Nome");
            writer.Write((dataGridViewHome.Columns[1].DataPropertyName = "Nome") + ";");

            //writer.Write(dataGridViewHome.Columns[2].HeaderText = "CPF");
            writer.Write((dataGridViewHome.Columns[2].DataPropertyName = "CPF") + ";");

            //writer.Write(dataGridViewHome.Columns[3].HeaderText = "Telefone");
            writer.Write((dataGridViewHome.Columns[3].DataPropertyName = "Telefone") + ";" + "\n");


            for (int i = 0; i < dataGridViewHome.Rows.Count - 1; i++)
            {
                for (int c = 0; c < dataGridViewHome.Columns.Count; c++)

                {
                    writer.Write(dataGridViewHome.Rows[i].Cells[c].Value.ToString() + ";");
                    
                    //ConvertTextToImage("teste", "12", 12, Color.Red, Color.Green, 1024, 768);


                }

                writer.WriteLine("");

            }
            writer.Close();
            MessageBox.Show(@"Tabela exportada com sucesso para C:\folder\Text.txt");
        }
    }
}
