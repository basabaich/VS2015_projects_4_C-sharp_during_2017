using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataExp1
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dat2DataSet.SellingHistory' table. You can move, or remove it, as needed.
            this.sellingHistoryTableAdapter.Fill(this.db_dat2DataSet.SellingHistory);
            // TODO: This line of code loads data into the 'dataSet1.Julydata' table. You can move, or remove it, as needed.
            //  this.julydataTableAdapter.Fill(this.dataSet1.Julydata);

        }
    }
}
