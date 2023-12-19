using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private int countSeconds;
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public Form2()
        {
            InitializeComponent();
            //int pid = Environment.CurrentManagedThreadId;

            countSeconds = 10;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(Closee);
        }

        private void Closee(object? sender, EventArgs e)
        {
            if (countSeconds == 0)
            {
                timer1.Stop();
                this.Close();

            }
            else
            {
                countSeconds--;
                textBox1.Text = "还剩下：" + countSeconds.ToString() + "秒";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox1.Text = "还剩下：" + countSeconds.ToString() + "秒";
        }
    }
}
