
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textPesquisaFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textDependente1 = new System.Windows.Forms.TextBox();
            this.textDependente2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textIdDependenteFuncionario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.funcionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cesgranrioTestDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo *";
            this.label1.UseWaitCursor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textNomeCompleto
            // 
            this.textNomeCompleto.Location = new System.Drawing.Point(30, 81);
            this.textNomeCompleto.Name = "textNomeCompleto";
            this.textNomeCompleto.Size = new System.Drawing.Size(253, 20);
            this.textNomeCompleto.TabIndex = 1;
            // 
            // dataGridViewHome
            // 
            this.dataGridViewHome.AllowUserToAddRows = false;
            this.dataGridViewHome.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHome.Location = new System.Drawing.Point(452, 71);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.ReadOnly = true;
            this.dataGridViewHome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewHome.RowHeadersVisible = false;
            this.dataGridViewHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHome.Size = new System.Drawing.Size(571, 452);
            this.dataGridViewHome.TabIndex = 17;
            this.dataGridViewHome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHome_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(205, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone";
            this.label2.UseWaitCursor = true;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(208, 127);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(165, 20);
            this.textTelefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(27, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            this.label3.UseWaitCursor = true;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(30, 173);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(253, 20);
            this.textEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(284, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data de Nascimento";
            this.label4.UseWaitCursor = true;
            // 
            // textDataNascimento
            // 
            this.textDataNascimento.Location = new System.Drawing.Point(287, 173);
            this.textDataNascimento.Name = "textDataNascimento";
            this.textDataNascimento.Size = new System.Drawing.Size(86, 20);
            this.textDataNascimento.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
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
            this.BtnDepartamento.Location = new System.Drawing.Point(29, 351);
            this.BtnDepartamento.Name = "BtnDepartamento";
            this.BtnDepartamento.Size = new System.Drawing.Size(254, 23);
            this.BtnDepartamento.TabIndex = 13;
            this.BtnDepartamento.Text = "Gerenciar Departamento";
            this.BtnDepartamento.UseVisualStyleBackColor = true;
            this.BtnDepartamento.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(28, 218);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(253, 21);
            this.comboDepartamento.TabIndex = 6;
            this.comboDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboDepartamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(25, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Departamento";
            this.label6.UseWaitCursor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(287, 216);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // textIdFunc
            // 
            this.textIdFunc.Location = new System.Drawing.Point(287, 81);
            this.textIdFunc.Name = "textIdFunc";
            this.textIdFunc.Size = new System.Drawing.Size(86, 20);
            this.textIdFunc.TabIndex = 18;
            // 
            // textPesquisaFuncionario
            // 
            this.textPesquisaFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textPesquisaFuncionario.Location = new System.Drawing.Point(452, 28);
            this.textPesquisaFuncionario.Name = "textPesquisaFuncionario";
            this.textPesquisaFuncionario.Size = new System.Drawing.Size(331, 20);
            this.textPesquisaFuncionario.TabIndex = 14;
            this.textPesquisaFuncionario.Text = "Digite um CPF";
            this.textPesquisaFuncionario.TextChanged += new System.EventHandler(this.textPesquisaFuncionario_TextChanged);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(798, 26);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarFuncionario.TabIndex = 15;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(25, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CPF *";
            this.label8.UseWaitCursor = true;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(28, 127);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(174, 20);
            this.textCPF.TabIndex = 2;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(893, 26);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(130, 23);
            this.btnLimparPesquisa.TabIndex = 16;
            this.btnLimparPesquisa.Text = "Limpar Pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(27, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dependente 1";
            this.label9.UseWaitCursor = true;
            // 
            // textDependente1
            // 
            this.textDependente1.Location = new System.Drawing.Point(30, 267);
            this.textDependente1.Name = "textDependente1";
            this.textDependente1.Size = new System.Drawing.Size(172, 20);
            this.textDependente1.TabIndex = 8;
            // 
            // textDependente2
            // 
            this.textDependente2.Location = new System.Drawing.Point(208, 267);
            this.textDependente2.Name = "textDependente2";
            this.textDependente2.Size = new System.Drawing.Size(165, 20);
            this.textDependente2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(206, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Dependente 2";
            this.label10.UseWaitCursor = true;
            // 
            // textIdDependenteFuncionario
            // 
            this.textIdDependenteFuncionario.Location = new System.Drawing.Point(380, 267);
            this.textIdDependenteFuncionario.Name = "textIdDependenteFuncionario";
            this.textIdDependenteFuncionario.Size = new System.Drawing.Size(66, 20);
            this.textIdDependenteFuncionario.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Khaki;
            this.label11.Location = new System.Drawing.Point(452, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 18;
            // 
            // funcionariosBindingSource1
            // 
            this.funcionariosBindingSource1.DataMember = "Funcionarios";
            this.funcionariosBindingSource1.DataSource = this.cesgranrioTestDBDataSet;
            // 
            // cesgranrioTestDBDataSetBindingSource
            // 
            this.cesgranrioTestDBDataSetBindingSource.DataSource = this.cesgranrioTestDBDataSet;
            this.cesgranrioTestDBDataSetBindingSource.Position = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormHomeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textIdDependenteFuncionario);
            this.Controls.Add(this.textDependente2);
            this.Controls.Add(this.textDependente1);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.label1);
            this.Name = "FormHomeFuncionarios";
            this.Text = "Home - Gerenciamento de Funcionarios";
            this.Load += new System.EventHandler(this.FormHomeFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textPesquisaFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDependente1;
        private System.Windows.Forms.TextBox textDependente2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textIdDependenteFuncionario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource funcionariosBindingSource1;
        private System.Windows.Forms.BindingSource cesgranrioTestDBDataSetBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

