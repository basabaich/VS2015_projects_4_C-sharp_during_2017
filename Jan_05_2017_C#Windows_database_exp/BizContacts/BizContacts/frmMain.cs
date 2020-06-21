using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BizContacts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Julydata' table. You can move, or remove it, as needed.
            this.julydataTableAdapter.Fill(this.dataSet1.Julydata);
            // TODO: This line of code loads data into the 'dataSet1.Julydata' table. You can move, or remove it, as needed.
            this.julydataTableAdapter.Fill(this.dataSet1.Julydata);

        }
    }
}
