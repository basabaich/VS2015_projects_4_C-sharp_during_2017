using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//System.IO.File.ReadAllText(opentext.FileName);

namespace ReadTxt1
{
    public partial class Form1 : Form
    {

        string aPath= @"help1.txt";

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TextReader reader = new StreamReader("triangle.txt");
            ////TextWriter writer = new StreamWriter("triangle2.txt");
            //for (;;)
            //{
            //    string s = reader.ReadLine();
            //    if (s == null)
            //        break;
            //    s = s.Replace(" ", ", ");
            //    s = "{" + s + "},";
            //  //  writer.WriteLine(s);
            //}

            // ======================*****===================
            //richTextBox1.Text = File.ReadAllText(opentext.FileName);
            //// Globals.notes = richTextBox1.Text;
            //if (opentext.ShowDialog() == DialogResult.OK)
            //{

            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillRichText(@"help1.txt");

        }

        public string FillRichText(string aPath, string bPath)
        {
            string content = File.ReadAllText(aPath);
            richTextBox1.Text = content;

            // do some work to assign a value to isIdentical
            if (isIdentical == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


    }
}
