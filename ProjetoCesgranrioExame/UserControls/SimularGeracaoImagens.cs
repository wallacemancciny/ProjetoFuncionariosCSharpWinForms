using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCesgranrioExame
{
    public partial class SimularGeracaoImagens : UserControl
    {
       


        public SimularGeracaoImagens()
        {
            InitializeComponent();
        }

        
        //Gerar notas aleatórias
        public int NotaRandomica()
        {
            int notaGerada = 0;
            Random notaAleatoria = new Random();
            for (int n = 0; n < 11; n++)
            {
                int notarand = notaAleatoria.Next(11);
                
                notaGerada = notarand;
            }
            return notaGerada;
           
        }

        public void MessagemBtnStartClick()
        {
            MessageBox.Show("Está rodando em paralelo!");
        }

        public static Bitmap ConvertTextToImage(string txt, string fontname, int fontsize, Color bgcolor, Color fcolor, int width, int Height)
        {
            try
            {
                //cria o bitmap
                Bitmap bmp = new Bitmap(width, Height);
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    //define a fonte e escreve o texto
                    Font font = new Font(fontname, fontsize);
                    graphics.FillRectangle(new SolidBrush(bgcolor), 0, 0, bmp.Width, bmp.Height);
                    graphics.DrawString(txt, font, new SolidBrush(fcolor), 0, 0);
                    graphics.Flush();
                    font.Dispose();
                    graphics.Dispose();
                }
                return bmp;
            }
            catch
            {
                throw;
            }
        }

        private Task ProcessData(List<string> list, IProgress<Redacao> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new Redacao();
            int alunoIndex = 0;

            return Task.Run(() => {

                

                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);

                    Redacao geraAluno = new Redacao();
                    
                    geraAluno.GerarAlunos("Aluno" + alunoIndex++, false);
                    ConvertTextToImage("Nome do Aluno:" + "\n" + "Id do Aluno:" + "\n" + "Nota do Aluno:" + "\n", "32", 24, Color.White, Color.Black, 1024, 768).Save(Path.Combine(@"C:\folder\", alunoIndex.ToString() + ".jpg" ));

                    //IMPRIME A MENSAGEM NA TELA PARA CADA ALUNO CRIADO
                    //MessageBox.Show("Aluno " + alunoIndex);
                    //Thread.Sleep(10);//usado para simular o tamanho da operação
                }
             

            });

        }

        public void MensagemEmParalelo()
        {
            Informativo FormInfo = new Informativo();
            FormInfo.Show();
        }


        public async void btnStart_Click(object sender, EventArgs e)
        {

            String quantAlunosTrim = textQntAlunos.Text.Trim();

            if (quantAlunosTrim == "")
            {
                MessageBox.Show("Você não pode gerar as redações sem digitar nada!");

            } else
            {
                if (Directory.Exists(@"C:\folder\") && File.Exists("Text.txt"))
                {
                    MensagemEmParalelo();
                    List<string> list = new List<string>();


                    for (int i = 0; i < Convert.ToInt32(quantAlunosTrim); i++)

                        list.Add(i.ToString());
                    lblStatus.Text = "Trabalhando...";

                    var progress = new Progress<Redacao>();

                    //Código do progresso mudando
                    progress.ProgressChanged += (o, report) =>
                    {
                        lblStatus.Text = string.Format("Gerando " + textQntAlunos.Text + " Alunos e Redação... {0}%", report.PercentComplete);
                        progressBar.Value = report.PercentComplete;
                        progressBar.Update();
                    };

                    await ProcessData(list, progress);

                    lblStatus.Text = "Finalizado com sucesso!";

                }
                else
                {
                    Directory.CreateDirectory(@"C:\folder\");
                    File.Create("Text.txt");

                    MensagemEmParalelo();
                    List<string> list = new List<string>();


                    for (int i = 0; i < Convert.ToInt32(quantAlunosTrim); i++)

                        list.Add(i.ToString());
                    lblStatus.Text = "Trabalhando...";

                    var progress = new Progress<Redacao>();

                    //Código do progresso mudando
                    progress.ProgressChanged += (o, report) =>
                    {
                        lblStatus.Text = string.Format("Gerando " + textQntAlunos.Text + " Alunos e Redação... {0}%", report.PercentComplete);
                        progressBar.Value = report.PercentComplete;
                        progressBar.Update();
                    };

                    await ProcessData(list, progress);

                    lblStatus.Text = "Finalizado com sucesso!";
                }



            }
            
   

        }

        
        


    }
}
