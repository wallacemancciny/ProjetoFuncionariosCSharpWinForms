using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private Task ProcessData(List<string> list, IProgress<Redacao> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new Redacao();
            return Task.Run(() => {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    
                    Thread.Sleep(10);//usado para simular o tamanho da operação
                }
            });
         }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());
            lblStatus.Text = "Working...";
            var progress = new Progress<Redacao>();
           

            progress.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = string.Format("Processing...{0}%", report.PercentComplete);
                progressBar.Value = report.PercentComplete;
                progressBar.Update();
            };
            await ProcessData(list, progress);
            lblStatus.Text = "Done !";
            
        }
        


    }
}
