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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void cadastroDeFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenciarFuncionario.Show();
            wellcomeIndexControl1.Hide();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            gerenciarFuncionario.Hide();
            gerenciarFuncionario.BringToFront();
            simularGeracaoImagens1.Hide();
            simularGeracaoImagens1.SendToBack();
            correcaoDeRedacao1.Hide();
            correcaoDeRedacao1.SendToBack();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenciarFuncionario.Hide();
            wellcomeIndexControl1.Show();
            
        }

        private void wellcomeIndexControl1_Load(object sender, EventArgs e)
        {

        }

        private void simularGeraçãoDeImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenciarFuncionario.Hide();
            wellcomeIndexControl1.Hide();
            simularGeracaoImagens1.Show();

        }

        private void corrigirRedaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenciarFuncionario.Hide();
            wellcomeIndexControl1.Hide();
            simularGeracaoImagens1.Hide();
            correcaoDeRedacao1.Show();
        }
    }
}
