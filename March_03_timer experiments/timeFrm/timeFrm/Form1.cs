using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timeFrm
{
    public partial class Form1 : Form
    {
        int n1=0, n2;
        bool bCheck1 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval > 10)
            {
                n1++;                
            }

            if (n1 == 2)
            {
                textBox1.Text = "20 ticks counted";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnableTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
