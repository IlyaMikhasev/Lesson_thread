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
    public partial class Form1 : Form
    {
       
        int n = 1;
        List<Thread> arrTh = new List<Thread>();
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }
        public void ThreadForm() {
            form2 = new Form2();
            form2.Text = "Поток N:"+n.ToString();
            n++;
            form2.ShowDialog();
        }
        private void b_call_form2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ThreadForm);
            thread.Name = "Поток N:"+n;
            thread.Start();
            arrTh.Add(thread);
            chb_list.Items.Add(thread.Name,true);
        }
        [Obsolete]
        private void b_ThreadStop_Click(object sender, EventArgs e)
        {
            foreach (var ch in chb_list.CheckedItems) {
                foreach (Thread thread in arrTh)
                    if (thread.Name == ch.ToString())
                        thread.Suspend();                
            }
        }
        [Obsolete]
        private void b_resume_Click(object sender, EventArgs e)
        {
            foreach (var ch in chb_list.CheckedItems)
            {
                foreach (Thread thread in arrTh)
                    if (thread.Name == ch.ToString())
                        thread.Resume();
            }
        }
    }
}
