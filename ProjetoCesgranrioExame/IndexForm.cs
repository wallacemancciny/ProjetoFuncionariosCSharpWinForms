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
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenciarFuncionario.Hide();
            wellcomeIndexControl1.Show();
            
        }

    }
}
