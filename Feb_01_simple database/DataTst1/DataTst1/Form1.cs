using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataTst1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        int index = 0;
        int last = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");

            dt.Rows.Add("Moto", "Nexus");
            dt.Rows.Add("Apple", "iPhone");
            dt.Rows.Add("Sony", "Vaio");
            dt.Rows.Add("Samsung", "edge");

            index = 0;
            last = dt.Rows.Count - 1;
            PopulateData();

        }

        private void PopulateData()
        {
            DataRow row = dt.Rows[index];
            string firstName = row["FirstName"].ToString();
            string lastName = row["LastName"].ToString();
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            PopulateData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = last - 1;
            PopulateData();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            index--;
            index =index < 0 ? 0 : index;
            PopulateData();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            index = index > last ? last : index;
            PopulateData();

        }
    }
}
