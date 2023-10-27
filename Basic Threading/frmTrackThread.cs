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

namespace Basic_Threading
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
            label1.Text = "-Before starting thread-";
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(label1.Text.ToString());

            Thread ThreadA = new Thread(MyThreadClass.thread1);                    

            Thread ThreadB = new Thread(MyThreadClass.thread2);                   

            Thread ThreadC = new Thread(MyThreadClass.thread1);                    

            Thread ThreadD = new Thread(MyThreadClass.thread2);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            label1.Text = "-End of thread-";
            Console.WriteLine(label1.Text.ToString());
        }

        private void frmBasicThreading_Load(object sender, EventArgs e)
        {

        }
    }
}
