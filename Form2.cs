﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //int pid = Environment.CurrentManagedThreadId;
            int pid = Thread.CurrentThread.ManagedThreadId;
            this.textBox1.Text = pid.ToString();
        }
    }
}
