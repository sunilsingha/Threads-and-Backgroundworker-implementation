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

namespace BackgroupVsThreads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "BACKGROUND WORKDER"
        private void btnBackGroundworker_Click(object sender, EventArgs e)
        {
            btnBackGroundworker.Enabled = false;
            if (!BW.IsBusy)
            {
                BW.RunWorkerAsync();
            }
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            object myUpdate;
            for (int i = 1; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
                if (BW.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                if (i == 100)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 200)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 300)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 400)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 500)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 600)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 700)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 800)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 900)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);
                }
                if (i == 1000)
                {
                    myUpdate = DateTime.Now;
                    BW.ReportProgress(i, myUpdate);

                }
            }
        }

        private void BW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = e.ProgressPercentage + " - " + e.UserState.ToString();
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "USER CANCELLED!";
            }
            else
            {
                label1.Text = "Backgroundworker completed";
            }
            btnBackGroundworker.Enabled = true;
        }

        private void btnStopworker_Click(object sender, EventArgs e)
        {
            if (BW.IsBusy)
            {
                BW.CancelAsync();
            }
        }
        #endregion

        
        #region "THREAD WORKER"
        foo fooo;
        private void btnThread_Click(object sender, EventArgs e)
        {
            this.btnThread.Enabled = false;
            fooo = new foo();
            fooo.cancelUpdate = false;
            fooo.UpdateProgress += new EventHandler<ProgressArgs>(UpdateProgress);
            fooo.Completed += new EventHandler(CompletedThread);
            Thread t = new Thread(fooo.UpdateTime);
            t.Start();
        }


        public delegate void paramDelegate(object sender, ProgressArgs e);

        public void UpdateProgress(object sender, ProgressArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new paramDelegate(UpdateProgress), sender, e);
            }
            else
            {
                label2.Text = e.Status;
            }
        }

        public delegate void BlankDelegate(object sender, EventArgs e);

        public void CompletedThread(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new BlankDelegate(CompletedThread), sender, e);
            }
            else
            {
                btnThread.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fooo != null)
            {
                fooo.cancelUpdate = true;
            }
        }
        #endregion

    }
}

public class foo
{
    public event EventHandler<ProgressArgs> UpdateProgress;

    public event EventHandler Completed;

    public bool cancelUpdate;

    public void UpdateTime()
    {
        string myUpdate = string.Empty;
        for (int i = 1; i < 1000; i++)
        {

            if (cancelUpdate)
            {
                myUpdate = "USER CANCELLED";
                if (UpdateProgress != null)
                {
                    UpdateProgress(this, new ProgressArgs(0, myUpdate));

                    if (Completed != null)
                    {
                        Completed(this, null);
                    }

                }
                return;
            }

            System.Threading.Thread.Sleep(10);

          
            if (i == 100)
            {
                myUpdate = i + " - " + DateTime.Now;      
                
            }
            if (i == 200)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 300)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 400)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 500)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 600)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 700)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 800)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 900)
            {
                myUpdate = i + " - " + DateTime.Now;
            }
            if (i == 1000)
            {
                myUpdate = i + " - " + DateTime.Now;

            }

            if (UpdateProgress != null)
            {               
                UpdateProgress(this, new ProgressArgs(i, myUpdate));

            }

          
        }

        if (UpdateProgress != null)
        {
            UpdateProgress(this, new ProgressArgs(1000, "THREAD COMPLETED"));

        }

        if (Completed != null)
        {
            Completed(this, null);
        }

    }

    

}

public class ProgressArgs : EventArgs
{
    int _PercentageCompleted;
    string _status;

    public ProgressArgs(int PercentageCompleted, string status)
    {
        _PercentageCompleted = PercentageCompleted;
        _status = status;
    }

    public int PercentageCompleted { get { return _PercentageCompleted; } }
    public string Status { get { return _status; } }

}
