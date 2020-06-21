using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataCon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C: \Users\basab\Desktop\Database files\db_dat2.mdb; Persist Security Info=False");

            InitializeComponent();
        }
        private OleDbConnection mycon;
       // Provider=Microsoft.Jet.OLEDB.4.0;Data Source = "C:\Users\basab\Desktop\Database files\db_dat2.mdb"

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'db_dat2DataSet.SellingHistory' table. You can move, or remove it, as needed.
           this.sellingHistoryTableAdapter.Fill(this.db_dat2DataSet.SellingHistory);

        }
    }
}
