using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySqlNavigate
{
    public partial class Form1 : Form
    {

        // My entry
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        int pos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM test_db", connection);
            adapter.Fill(table);
            showData(pos);
        }

        public void showData(int index)
        {
            textBoxID.Text = table.Rows[index][0].ToString();
            textBoxFName.Text = table.Rows[index][1].ToString();
            textBoxLName.Text = table.Rows[index][2].ToString();
            textBoxAge.Text = table.Rows[index][3].ToString();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pos++;
            if(pos <table.Rows.Count)
            {
                showData(pos);
            }
            else
            {
                MessageBox.Show("You have reached end of record !");
                pos = table.Rows.Count - 1;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pos--;
            if(pos>=0)
            {
                showData(pos);
            }
            else
            {
                MessageBox.Show("You have reached begining of record !");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = table.Rows.Count - 1;
            showData(pos);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
