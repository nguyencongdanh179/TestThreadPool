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

namespace TestThreadPool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateThread(object sender, EventArgs e)
        {
            WaitCallback callback = new WaitCallback(Dowork);
            ThreadPool.QueueUserWorkItem(callback, "haha");
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            rtbStatus.Text += value;
        }
        private void Dowork(Object obj)
        {
            Thread currentThread = Thread.CurrentThread;
            string checkThreadPoolStatus = currentThread.IsThreadPoolThread.ToString();
            string threadID = currentThread.ManagedThreadId.ToString();
            for (int i = 0; i < 5; i++)
            {
                AppendTextBox("Count: "+ i + " -- ThreadID: " + threadID + "\n");
                Thread.Sleep(2000);
            }
        }
        private void MainJob(object sender, EventArgs e)
        {
            rtbStatus.Text = rtbStatus.Text + "OK \n \n";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(CreateThread);
            timer.Enabled = true;

            System.Windows.Forms.Timer timerMain = new System.Windows.Forms.Timer();
            timerMain.Interval = 2000;
            timerMain.Tick += new EventHandler(MainJob);
            timerMain.Enabled = true;
        }

        private void rtbStatus_TextChanged(object sender, EventArgs e)
        {
            rtbStatus.SelectionStart = rtbStatus.TextLength;
            rtbStatus.ScrollToCaret();
        }
    }
}
