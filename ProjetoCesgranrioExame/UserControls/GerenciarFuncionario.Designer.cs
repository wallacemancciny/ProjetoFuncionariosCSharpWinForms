
namespace ProjetoCesgranrioExame
{
    partial class GerenciarFuncionario
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.maskedTextCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskTextDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btnExportarTxt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textIdDependenteFuncionario = new System.Windows.Forms.TextBox();
            this.textDependente2 = new System.Windows.Forms.TextBox();
            this.textDependente1 = new System.Windows.Forms.TextBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.textPesquisaFuncionario = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.BtnDepartamento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdFunc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNomeCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextCPF
            // 
            this.maskedTextCPF.Location = new System.Drawing.Point(120, 204);
            this.maskedTextCPF.Mask = "000,000,000-00";
            this.maskedTextCPF.Name = "maskedTextCPF";
            this.maskedTextCPF.Size = new System.Drawing.Size(172, 20);
            this.maskedTextCPF.TabIndex = 30;
            // 
            // maskTextDataNascimento
            // 
            this.maskTextDataNascimento.Location = new System.Drawing.Point(379, 250);
            this.maskTextDataNascimento.Mask = "00/00/0000";
            this.maskTextDataNascimento.Name = "maskTextDataNascimento";
            this.maskTextDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.maskTextDataNascimento.TabIndex = 34;
            this.maskTextDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // btnExportarTxt
            // 
            this.btnExportarTxt.Location = new System.Drawing.Point(542, 559);
            this.btnExportarTxt.Name = "btnExportarTxt";
            this.btnExportarTxt.Size = new System.Drawing.Size(123, 23);
            this.btnExportarTxt.TabIndex = 50;
            this.btnExportarTxt.Text = "Exportar";
            this.btnExportarTxt.UseVisualStyleBackColor = true;
            this.btnExportarTxt.Click += new System.EventHandler(this.btnExportarTxt_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Khaki;
            this.label11.Location = new System.Drawing.Point(542, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 49;
            // 
            // textIdDependenteFuncionario
            // 
            this.textIdDependenteFuncionario.Location = new System.Drawing.Point(470, 344);
            this.textIdDependenteFuncionario.Name = "textIdDependenteFuncionario";
            this.textIdDependenteFuncionario.Size = new System.Drawing.Size(66, 20);
            this.textIdDependenteFuncionario.TabIndex = 46;
            // 
            // textDependente2
            // 
            this.textDependente2.Location = new System.Drawing.Point(298, 344);
            this.textDependente2.Name = "textDependente2";
            this.textDependente2.Size = new System.Drawing.Size(165, 20);
            this.textDependente2.TabIndex = 38;
            // 
            // textDependente1
            // 
            this.textDependente1.Location = new System.Drawing.Point(120, 344);
            this.textDependente1.Name = "textDependente1";
            this.textDependente1.Size = new System.Drawing.Size(172, 20);
            this.textDependente1.TabIndex = 37;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(983, 103);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(130, 23);
            this.btnLimparPesquisa.TabIndex = 45;
            this.btnLimparPesquisa.Text = "Limpar Pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click_1);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(888, 103);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarFuncionario.TabIndex = 44;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click_1);
            // 
            // textPesquisaFuncionario
            // 
            this.textPesquisaFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textPesquisaFuncionario.Location = new System.Drawing.Point(542, 105);
            this.textPesquisaFuncionario.Name = "textPesquisaFuncionario";
            this.textPesquisaFuncionario.Size = new System.Drawing.Size(331, 20);
            this.textPesquisaFuncionario.TabIndex = 43;
            this.textPesquisaFuncionario.Text = "Digite um CPF";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(377, 293);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 23);
            this.btnAtualizar.TabIndex = 36;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(118, 295);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(253, 21);
            this.comboDepartamento.TabIndex = 35;
            // 
            // BtnDepartamento
            // 
            this.BtnDepartamento.Location = new System.Drawing.Point(119, 428);
            this.BtnDepartamento.Name = "BtnDepartamento";
            this.BtnDepartamento.Size = new System.Drawing.Size(254, 23);
            this.BtnDepartamento.TabIndex = 42;
            this.BtnDepartamento.Text = "Gerenciar Departamento";
            this.BtnDepartamento.UseVisualStyleBackColor = true;
            this.BtnDepartamento.Click += new System.EventHandler(this.BtnDepartamento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(113, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Gerenciamento de Funcionarios";
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
            this.dataGridViewHome.Location = new System.Drawing.Point(542, 148);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.ReadOnly = true;
            this.dataGridViewHome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewHome.RowHeadersVisible = false;
            this.dataGridViewHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHome.Size = new System.Drawing.Size(571, 396);
            this.dataGridViewHome.TabIndex = 47;
            this.dataGridViewHome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHome_CellContentClick_1);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(120, 250);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(253, 20);
            this.textEmail.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(296, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Dependente 2";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(117, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Dependente 1";
            this.label9.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(115, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Departamento";
            this.label6.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(374, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Data de Nascimento";
            this.label4.UseWaitCursor = true;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(298, 204);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(165, 20);
            this.textTelefone.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(117, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            this.label3.UseWaitCursor = true;
            // 
            // textIdFunc
            // 
            this.textIdFunc.Location = new System.Drawing.Point(377, 158);
            this.textIdFunc.Name = "textIdFunc";
            this.textIdFunc.Size = new System.Drawing.Size(86, 20);
            this.textIdFunc.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(115, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "CPF *";
            this.label8.UseWaitCursor = true;
            // 
            // textNomeCompleto
            // 
            this.textNomeCompleto.Location = new System.Drawing.Point(120, 158);
            this.textNomeCompleto.Name = "textNomeCompleto";
            this.textNomeCompleto.Size = new System.Drawing.Size(253, 20);
            this.textNomeCompleto.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(295, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Telefone";
            this.label2.UseWaitCursor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Limpar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(209, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(119, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(115, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome Completo *";
            this.label1.UseWaitCursor = true;
            // 
            // GerenciarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.maskedTextCPF);
            this.Controls.Add(this.maskTextDataNascimento);
            this.Controls.Add(this.btnExportarTxt);
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
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
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
            this.Name = "GerenciarFuncionario";
            this.Size = new System.Drawing.Size(1226, 679);
            this.Load += new System.EventHandler(this.GerenciarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextCPF;
        private System.Windows.Forms.MaskedTextBox maskTextDataNascimento;
        private System.Windows.Forms.Button btnExportarTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textIdDependenteFuncionario;
        private System.Windows.Forms.TextBox textDependente2;
        private System.Windows.Forms.TextBox textDependente1;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.TextBox textPesquisaFuncionario;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.Button BtnDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewHome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdFunc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNomeCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}
