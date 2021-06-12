
namespace ProjetoCesgranrioExame
{
    partial class WellcomeIndexControl
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
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeSistema
            // 
            this.lblNomeSistema.AutoSize = true;
            this.lblNomeSistema.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSistema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeSistema.Location = new System.Drawing.Point(290, 235);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new System.Drawing.Size(653, 51);
            this.lblNomeSistema.TabIndex = 0;
            this.lblNomeSistema.Text = "Bem vindo ao SGW -  WALLACE";
            // 
            // WellcomeIndexControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.lblNomeSistema);
            this.Name = "WellcomeIndexControl";
            this.Size = new System.Drawing.Size(1196, 616);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeSistema;
    }
}
