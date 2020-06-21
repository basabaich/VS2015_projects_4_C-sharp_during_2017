using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgBarFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int i;

            progressBar1.Maximum = 50000000;
            progressBar1.Minimum = 0;

            for(i=0; i <= 50000000; i++)
            {
                progressBar1.Value = i;
            }



        }
    }
}
