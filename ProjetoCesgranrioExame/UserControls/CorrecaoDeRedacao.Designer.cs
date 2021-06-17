
namespace ProjetoCesgranrioExame
{
    partial class CorrecaoDeRedacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRevisarProximo = new System.Windows.Forms.Button();
            this.btnSalvarNotaRevisada = new System.Windows.Forms.Button();
            this.textNotaRevisada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIdAlunoValor = new System.Windows.Forms.Label();
            this.IdAluno = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblNomeAlunoValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cesgranrioTestDBDataSet1 = new ProjetoCesgranrioExame.CesgranrioTestDBDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(524, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagem da Redação do Aluno";
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(6, 19);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(510, 480);
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRevisarProximo);
            this.groupBox2.Controls.Add(this.btnSalvarNotaRevisada);
            this.groupBox2.Controls.Add(this.textNotaRevisada);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblIdAlunoValor);
            this.groupBox2.Controls.Add(this.IdAluno);
            this.groupBox2.Controls.Add(this.lblNomeAluno);
            this.groupBox2.Controls.Add(this.lblNomeAlunoValor);
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(142, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Correção - Dados do Aluno";
            // 
            // btnRevisarProximo
            // 
            this.btnRevisarProximo.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRevisarProximo.Location = new System.Drawing.Point(9, 222);
            this.btnRevisarProximo.Name = "btnRevisarProximo";
            this.btnRevisarProximo.Size = new System.Drawing.Size(130, 23);
            this.btnRevisarProximo.TabIndex = 4;
            this.btnRevisarProximo.Text = "Revisar Próximo Aluno";
            this.btnRevisarProximo.UseVisualStyleBackColor = true;
            this.btnRevisarProximo.Click += new System.EventHandler(this.btnRevisarProximo_Click);
            // 
            // btnSalvarNotaRevisada
            // 
            this.btnSalvarNotaRevisada.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalvarNotaRevisada.Location = new System.Drawing.Point(9, 176);
            this.btnSalvarNotaRevisada.Name = "btnSalvarNotaRevisada";
            this.btnSalvarNotaRevisada.Size = new System.Drawing.Size(130, 23);
            this.btnSalvarNotaRevisada.TabIndex = 4;
            this.btnSalvarNotaRevisada.Text = "Salvar";
            this.btnSalvarNotaRevisada.UseVisualStyleBackColor = true;
            this.btnSalvarNotaRevisada.Click += new System.EventHandler(this.btnSalvarNotaRevisada_Click);
            // 
            // textNotaRevisada
            // 
            this.textNotaRevisada.Location = new System.Drawing.Point(9, 131);
            this.textNotaRevisada.Name = "textNotaRevisada";
            this.textNotaRevisada.Size = new System.Drawing.Size(130, 20);
            this.textNotaRevisada.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(8, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Corrigir Nota";
            // 
            // lblIdAlunoValor
            // 
            this.lblIdAlunoValor.AutoSize = true;
            this.lblIdAlunoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAlunoValor.ForeColor = System.Drawing.Color.Cyan;
            this.lblIdAlunoValor.Location = new System.Drawing.Point(74, 25);
            this.lblIdAlunoValor.Name = "lblIdAlunoValor";
            this.lblIdAlunoValor.Size = new System.Drawing.Size(0, 20);
            this.lblIdAlunoValor.TabIndex = 1;
            // 
            // IdAluno
            // 
            this.IdAluno.AutoSize = true;
            this.IdAluno.BackColor = System.Drawing.SystemColors.Highlight;
            this.IdAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAluno.ForeColor = System.Drawing.Color.Cornsilk;
            this.IdAluno.Location = new System.Drawing.Point(6, 30);
            this.IdAluno.Name = "IdAluno";
            this.IdAluno.Size = new System.Drawing.Size(76, 13);
            this.IdAluno.TabIndex = 1;
            this.IdAluno.Text = "Id do Aluno:";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblNomeAluno.Location = new System.Drawing.Point(6, 58);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(97, 13);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome do Aluno:";
            // 
            // lblNomeAlunoValor
            // 
            this.lblNomeAlunoValor.AutoSize = true;
            this.lblNomeAlunoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAlunoValor.ForeColor = System.Drawing.Color.Cyan;
            this.lblNomeAlunoValor.Location = new System.Drawing.Point(100, 56);
            this.lblNomeAlunoValor.Name = "lblNomeAlunoValor";
            this.lblNomeAlunoValor.Size = new System.Drawing.Size(211, 17);
            this.lblNomeAlunoValor.TabIndex = 0;
            this.lblNomeAlunoValor.Text = "Nenhum Aluno para Revisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(358, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correção de Redação";
            // 
            // cesgranrioTestDBDataSet1
            // 
            this.cesgranrioTestDBDataSet1.DataSetName = "CesgranrioTestDBDataSet";
            this.cesgranrioTestDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CorrecaoDeRedacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CorrecaoDeRedacao";
            this.Size = new System.Drawing.Size(1249, 656);
            this.Load += new System.EventHandler(this.CorrecaoDeRedacao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cesgranrioTestDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdAluno;
        private System.Windows.Forms.Label lblNomeAlunoValor;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblIdAlunoValor;
        private System.Windows.Forms.Label label8;
        private CesgranrioTestDBDataSet cesgranrioTestDBDataSet1;
        private System.Windows.Forms.Button btnSalvarNotaRevisada;
        private System.Windows.Forms.TextBox textNotaRevisada;
        private System.Windows.Forms.Button btnRevisarProximo;
    }
}
