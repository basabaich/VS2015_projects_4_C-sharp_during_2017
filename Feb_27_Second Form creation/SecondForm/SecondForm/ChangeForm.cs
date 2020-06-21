using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecondForm
{
    public partial class ChangeForm : Form
    {
        Form2 fr2 = new Form2();
       
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {            
            this.Hide();
            fr2.ShowDialog();            
        }
    }
}
