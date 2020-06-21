using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TxtBxForm
{
    
    public partial class Form1 : Form
    {
        // globally declared variables>
        /// //////////////////////
        
        int a=33, b=85, c;

        string str1;

        SpecialBox sb = new SpecialBox();
        TextBox t1box = new TextBox();
        // globally declared variables


        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {
            txtb1.Text = "Hello world";
        }

        private void btn2_Click(object sender, EventArgs e)
        {            
           txtb2.Text = "value of a is : "+a +";  "+" value of b is : "+b +"; "+ " total value is c=a+b ="+(a+b);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int a;
            a = 22;
           // txtb3.Font=new Font("Gorgia", 14);
            txtb3.Text = "value of b is : "+b;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            str1 = txtb4.Text;
            MessageBox.Show(str1);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // text box cration in run time            
            t1box.Location = new Point(20, 310);
            t1box.BackColor = Color.Red;
            t1box.ForeColor = Color.Yellow;
            t1box.Height = 40;
            t1box.Width = 300;
            t1box.Font = new Font("Gorgia", 16);
            t1box.Text = "value of A is : " + b;
            Controls.Add(t1box);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtb1.Clear();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtb5.Text = "Hello World, this is a continuous line \r\n& \r\nthis is a new line";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtb4.Text = "this is automatic";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtb3.Clear();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            t1box.Clear();
        }
    }

    public partial class SpecialBox : Form
    {
        // globally declared variables>
        /// //////////////////////
        int b = 85;
        
        // globally declared variables

        public void CreateBox()
        {
            // text box cration in run time
            TextBox t1box = new TextBox();
            t1box.Location = new Point(20, 310);
            t1box.BackColor = Color.Red;
            t1box.ForeColor = Color.Yellow;
            t1box.Height = 40;
            t1box.Width = 300;
            t1box.Font = new Font("Gorgia", 16);
            t1box.Text = "value of A is : " + b;
            Controls.Add(t1box);
        }

        public void ClearBox()
        {
            // text box made clean in run time
            TextBox t1box = new TextBox();
            t1box.Clear();
        }


    }
}
