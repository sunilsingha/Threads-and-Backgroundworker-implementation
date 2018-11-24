namespace BackgroupVsThreads
{
    partial class Form1
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
            this.btnBackGroundworker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopworker = new System.Windows.Forms.Button();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackGroundworker
            // 
            this.btnBackGroundworker.Location = new System.Drawing.Point(472, 49);
            this.btnBackGroundworker.Name = "btnBackGroundworker";
            this.btnBackGroundworker.Size = new System.Drawing.Size(132, 57);
            this.btnBackGroundworker.TabIndex = 0;
            this.btnBackGroundworker.Text = "BackgroundWorker";
            this.btnBackGroundworker.UseVisualStyleBackColor = true;
            this.btnBackGroundworker.Click += new System.EventHandler(this.btnBackGroundworker_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backgroundworkder Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStopworker
            // 
            this.btnStopworker.Location = new System.Drawing.Point(621, 49);
            this.btnStopworker.Name = "btnStopworker";
            this.btnStopworker.Size = new System.Drawing.Size(132, 57);
            this.btnStopworker.TabIndex = 0;
            this.btnStopworker.Text = "Stop Worker";
            this.btnStopworker.UseVisualStyleBackColor = true;
            this.btnStopworker.Click += new System.EventHandler(this.btnStopworker_Click);
            // 
            // BW
            // 
            this.BW.WorkerReportsProgress = true;
            this.BW.WorkerSupportsCancellation = true;
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork);
            this.BW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_ProgressChanged);
            this.BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thread Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stop Thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(471, 202);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(132, 57);
            this.btnThread.TabIndex = 3;
            this.btnThread.Text = "Thread Worker";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopworker);
            this.Controls.Add(this.btnBackGroundworker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackGroundworker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopworker;
        private System.ComponentModel.BackgroundWorker BW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThread;
    }
}

