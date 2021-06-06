
namespace ProjetoCesgranrioExame
{
    partial class FormDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDepartamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textGestor = new System.Windows.Forms.TextBox();
            this.btnDeletarDepartamento = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.BtnTestar = new System.Windows.Forms.Button();
            this.textIdDepartamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartamento
            // 
            this.dataGridViewDepartamento.AllowUserToOrderColumns = true;
            this.dataGridViewDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamento.Location = new System.Drawing.Point(420, 12);
            this.dataGridViewDepartamento.Name = "dataGridViewDepartamento";
            this.dataGridViewDepartamento.Size = new System.Drawing.Size(554, 426);
            this.dataGridViewDepartamento.TabIndex = 5;
            this.dataGridViewDepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartamento_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(88, 135);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(258, 20);
            this.textName.TabIndex = 1;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(88, 218);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(258, 96);
            this.textDescricao.TabIndex = 3;
            this.textDescricao.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadastro de Departamento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(88, 338);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gestor";
            // 
            // textGestor
            // 
            this.textGestor.Location = new System.Drawing.Point(88, 177);
            this.textGestor.Name = "textGestor";
            this.textGestor.Size = new System.Drawing.Size(258, 20);
            this.textGestor.TabIndex = 2;
            // 
            // btnDeletarDepartamento
            // 
            this.btnDeletarDepartamento.Location = new System.Drawing.Point(179, 338);
            this.btnDeletarDepartamento.Name = "btnDeletarDepartamento";
            this.btnDeletarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarDepartamento.TabIndex = 6;
            this.btnDeletarDepartamento.Text = "Deletar";
            this.btnDeletarDepartamento.UseVisualStyleBackColor = true;
            this.btnDeletarDepartamento.Click += new System.EventHandler(this.btnDeletarDepartamento_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(271, 338);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // BtnTestar
            // 
            this.BtnTestar.Location = new System.Drawing.Point(88, 386);
            this.BtnTestar.Name = "BtnTestar";
            this.BtnTestar.Size = new System.Drawing.Size(75, 23);
            this.BtnTestar.TabIndex = 9;
            this.BtnTestar.Text = "Testar";
            this.BtnTestar.UseVisualStyleBackColor = true;
            this.BtnTestar.Click += new System.EventHandler(this.BtnTestar_Click);
            // 
            // textIdDepartamento
            // 
            this.textIdDepartamento.Location = new System.Drawing.Point(88, 100);
            this.textIdDepartamento.Name = "textIdDepartamento";
            this.textIdDepartamento.Size = new System.Drawing.Size(100, 20);
            this.textIdDepartamento.TabIndex = 10;
            // 
            // FormDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.textIdDepartamento);
            this.Controls.Add(this.BtnTestar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletarDepartamento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.textGestor);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDepartamento);
            this.Name = "FormDepartamento";
            this.Text = "FormDepartamento";
            this.Load += new System.EventHandler(this.FormDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.RichTextBox textDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textGestor;
        private System.Windows.Forms.Button btnDeletarDepartamento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button BtnTestar;
        private System.Windows.Forms.TextBox textIdDepartamento;
    }
}