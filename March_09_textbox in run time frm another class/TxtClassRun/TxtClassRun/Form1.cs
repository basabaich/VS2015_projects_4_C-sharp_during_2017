using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TxtClassRun
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SplBox Sa = new SplBox(this);
            // show the dynamic text box in Form1 
            Sa.settxtbox();
                  
        }

       
    }

   

    public partial class SplBox :Form
    {
        //Global declarations 
        TextBox t2 = new TextBox();
        private Form TempOwnerForm;


        public SplBox(Form TempOwnerForm)
        {
            this.TempOwnerForm = TempOwnerForm;
        }

        public Form OwnerForm
        {
            get
            {
                return TempOwnerForm;
            }

            set
            {
                this.TempOwnerForm = value;
            }
        }

        public void settxtbox()
        {
            t2.Text = "Hello World";
            TempOwnerForm.Controls.Add(t2);
        }

    }

}
