
namespace ProjetoCesgranrioExame
{
    partial class FormHomeFuncionarios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textNomeCompleto = new System.Windows.Forms.TextBox();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDataNascimento = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cesgranrioTestDBDataSet = new ProjetoCesgranrioExame.CesgranrioTestDBDataSet();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new ProjetoCesgranrioExame.CesgranrioTestDBDataSetTableAdapters.FuncionariosTableAdapter();
            this.BtnDepartamento = new System.Windows.Forms.Button();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.textIdFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPesquisaFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo *";
            this.label1.UseWaitCursor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textNomeCompleto
            // 
            this.textNomeCompleto.Location = new System.Drawing.Point(30, 108);
            this.textNomeCompleto.Name = "textNomeCompleto";
            this.textNomeCompleto.Size = new System.Drawing.Size(253, 20);
            this.textNomeCompleto.TabIndex = 1;
            // 
            // dataGridViewHome
            // 
            this.dataGridViewHome.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHome.Location = new System.Drawing.Point(500, 71);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.ReadOnly = true;
            this.dataGridViewHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewHome.Size = new System.Drawing.Size(523, 452);
            this.dataGridViewHome.TabIndex = 10;
            this.dataGridViewHome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHome_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone";
            this.label2.UseWaitCursor = true;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(28, 199);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(253, 20);
            this.textTelefone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(25, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            this.label3.UseWaitCursor = true;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(28, 244);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(253, 20);
            this.textEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(25, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data de Nascimento";
            this.label4.UseWaitCursor = true;
            // 
            // textDataNascimento
            // 
            this.textDataNascimento.Location = new System.Drawing.Point(28, 289);
            this.textDataNascimento.Name = "textDataNascimento";
            this.textDataNascimento.Size = new System.Drawing.Size(253, 20);
            this.textDataNascimento.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(118, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Limpar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(23, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gerenciamento de Funcionarios";
            // 
            // cesgranrioTestDBDataSet
            // 
            this.cesgranrioTestDBDataSet.DataSetName = "CesgranrioTestDBDataSet";
            this.cesgranrioTestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.cesgranrioTestDBDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnDepartamento
            // 
            this.BtnDepartamento.Location = new System.Drawing.Point(28, 422);
            this.BtnDepartamento.Name = "BtnDepartamento";
            this.BtnDepartamento.Size = new System.Drawing.Size(254, 23);
            this.BtnDepartamento.TabIndex = 9;
            this.BtnDepartamento.Text = "Cadastrar Departamento";
            this.BtnDepartamento.UseVisualStyleBackColor = true;
            this.BtnDepartamento.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(28, 334);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(253, 21);
            this.comboDepartamento.TabIndex = 5;
            this.comboDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboDepartamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(25, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Departamento";
            this.label6.UseWaitCursor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(287, 334);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // textIdFunc
            // 
            this.textIdFunc.Location = new System.Drawing.Point(287, 108);
            this.textIdFunc.Name = "textIdFunc";
            this.textIdFunc.ReadOnly = true;
            this.textIdFunc.Size = new System.Drawing.Size(75, 20);
            this.textIdFunc.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(284, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Matricula";
            this.label7.UseWaitCursor = true;
            // 
            // textPesquisaFuncionario
            // 
            this.textPesquisaFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textPesquisaFuncionario.Location = new System.Drawing.Point(500, 28);
            this.textPesquisaFuncionario.Name = "textPesquisaFuncionario";
            this.textPesquisaFuncionario.Size = new System.Drawing.Size(283, 20);
            this.textPesquisaFuncionario.TabIndex = 12;
            this.textPesquisaFuncionario.Text = "Digite um CPF";
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(798, 26);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarFuncionario.TabIndex = 13;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(25, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CPF *";
            this.label8.UseWaitCursor = true;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(28, 154);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(253, 20);
            this.textCPF.TabIndex = 2;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(893, 26);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(130, 23);
            this.btnLimparPesquisa.TabIndex = 14;
            this.btnLimparPesquisa.Text = "Limpar Pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // FormHomeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.textPesquisaFuncionario);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.comboDepartamento);
            this.Controls.Add(this.BtnDepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewHome);
            this.Controls.Add(this.textDataNascimento);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textIdFunc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textNomeCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FormHomeFuncionarios";
            this.Text = "Home - Gerenciamento de Funcionarios";
            this.Load += new System.EventHandler(this.FormHomeFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textNomeCompleto;
        private System.Windows.Forms.DataGridView dataGridViewHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDataNascimento;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private CesgranrioTestDBDataSet cesgranrioTestDBDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private CesgranrioTestDBDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.Button BtnDepartamento;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox textIdFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPesquisaFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Button btnLimparPesquisa;
    }
}

