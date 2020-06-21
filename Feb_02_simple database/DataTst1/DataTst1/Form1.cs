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

        //my code
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataSet dset;
        // SqlDataReader sdr;
        // my code
        int pos = 0;
        

        public Form1()
        {
            InitializeComponent();

        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
           
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\MobileSets.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("SELECT * FROM mobile_table2", con);
           // con.Open();
            // cmd = new SqlCommand("DISPLAY FROM mobile_table(FirstName, LastName) VALUES(@FirstName, @LastName)", con);
            da.Fill(dt);
            ShowData(pos);
                 
        }

        private void ShowData(int index)
        {
            Update();
            Refresh();
            // WE WILL NOT PUT [index][0] STRING AS THIS WILL SHOW 'ID' COLUMN
            // OF THE TABLE - WHICH WE DO NOT NEED.
            txtRollNo.Text = dt.Rows[index][1].ToString();
            txtFirstName.Text = dt.Rows[index][2].ToString();
            txtLastName.Text = dt.Rows[index][3].ToString();
        }
     
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowData(pos);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = dt.Rows.Count - 1;
            ShowData(pos);
      
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                pos--;
                if (pos >= 0)
                {
                    ShowData(pos);
                }
                else
                {
                    MessageBox.Show("end of data...");
                }
            }
            catch
            {
                MessageBox.Show("some error occurred...");
            }
            
   
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                pos++;
                if (pos < dt.Rows.Count)
                {
                    ShowData(pos);
                }
                else
                {
                    MessageBox.Show("end of data...");
                    pos = dt.Rows.Count - 1;
                }
            }
            catch
            {
                MessageBox.Show("some error occurred...");
                
            }
  
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"UPDATE mobile_table2 SET FirstName='" + txtFirstName.Text + "'LastName='" + txtLastName.Text + "' WHERE RollNo='" + txtRollNo.Text + "';", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
            catch
            {
                MessageBox.Show("Not updated. exception Loop !");

            }
            finally
            {
                Update();
                con.Close();
            }
            
        }
    }
}
