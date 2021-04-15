using PRN292_Project.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PRN292_Project
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            backgroundWorkerLoad.WorkerReportsProgress = true;
            backgroundWorkerLoad.WorkerSupportsCancellation = true;
        }

        private void FrmLoad_Load(object sender, EventArgs e)
        {
            backgroundWorkerLoad.RunWorkerAsync();
        }

        private void backgroundWorkerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(10);
                    worker.ReportProgress(i);
                }
            }
        }

        private void backgroundWorkerLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
