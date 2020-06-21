using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLib1;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        calculation cal = new calculation();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();

            }

            catch(Exception ex)
            {
                MessageBox.Show("error in add button event..." + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = cal.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show("error in add button event..." + ex);
            }
        }
    }
}
