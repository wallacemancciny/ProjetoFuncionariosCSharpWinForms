using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCesgranrioExame
{
    public partial class CorrecaoDeRedacao : UserControl
    {
        String pegaIdAluno = "";
        public CorrecaoDeRedacao()
        {
            InitializeComponent();
        }

        public void atualizaAlunoRandomico()
        {
            //atualiza aluno aleatorio na tela (metodo instanciado lá em cima)
            //traz aluno randomico
            Redacao alunoRand = new Redacao();

            DataTable dtAlunoRand = alunoRand.BuscaAlunoRandon();
            
            foreach (DataRow dr in dtAlunoRand.Rows)
            {
                lblIdAlunoValor.Text  = dr["Id"].ToString();
                pegaIdAluno = dr["Id"].ToString();

                lblNomeAlunoValor.Text = dr["Nome"].ToString();
                imageBox.BackgroundImage = Image.FromFile(@"C:\folder\" + pegaIdAluno + ".jpg");
            }
        }

        public void CorrecaoDeRedacao_Load(object sender, EventArgs e)
        {
            atualizaAlunoRandomico();
            
        }



        private void btnSalvarNotaRevisada_Click(object sender, EventArgs e)
        {

            Redacao atualizaNota = new Redacao();

            atualizaNota.SalvaNotaRevisadaAlunoAleatorio(Convert.ToInt32(lblIdAlunoValor.Text), Convert.ToInt32(textNotaRevisada.Text));

            MessageBox.Show(atualizaNota.mensagem);
            textNotaRevisada.Text = "";

            //traz aluno randomico após salvar nota do anterior
            atualizaAlunoRandomico();


        }

        private void btnRevisarProximo_Click(object sender, EventArgs e)
        {
            //traz aluno randomico
            atualizaAlunoRandomico();
        }


    }
}
