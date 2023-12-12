using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lesson_thread
{
    public partial class Form2 : Form
    {
        public Thread ChildThread;
        public Form2()
        {
            InitializeComponent();
            ChildThread = new Thread(AddProgres);
            ChildThread.Start();
        }
        public  void AddProgres()
        {
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j < 200000000; j++) { }
                pgbar.Value = i;
                l_procent.Text = i.ToString();

            }
            //this.Close();
        }
    }
}
