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
            Departamento Dep = new Departamento();
            Dep.CadastrarDepartamento(textName.Text, textDescricao.Text);
            MessageBox.Show(Dep.mensagem);

            //instanciando departamento pra carregar a gridview após salvar um dado
            
            dataGridViewDep.DataSource = Depart.GetDepartamentosRecord();


            
        }

        private void FormDepartamento_Load(object sender, EventArgs e)
        {
            dataGridViewDep.DataSource = Depart.GetDepartamentosRecord();
        }
    }
}
