using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataExp3
{
    public partial class Form1 : Form
    {
        //my code
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt = new DataTable();        
        // my code
        int pos = 0;

        // special code
      //  SqlCommandBuilder cb = new SqlCommandBuilder();
        // special code



        public Form1()
        {

            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\CarModels.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            da = new SqlDataAdapter("SELECT * FROM car_detail", con);
            da.Fill(dt);
            ShowData(pos);
           
        }

        // This will update / refresh the data in the table in run time
        private void Refresh_Data_In_Table_In_Run_Time(int index)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\CarModels.mdf;Integrated Security=True;Connect Timeout=30");
            da = new SqlDataAdapter("SELECT * FROM car_detail", con);
            da.Fill(dt);
         //   ShowData(pos);

        }


        private void ShowData(int index)
        {
          
            // WE WILL NOT PUT [index][0] STRING AS THIS WILL SHOW 'ID' COLUMN
            // OF THE TABLE - WHICH WE DO NOT NEED.
            txtRegNo.Text = dt.Rows[index][1].ToString();
            txtCarModel.Text = dt.Rows[index][2].ToString();
            txtCarMake.Text = dt.Rows[index][3].ToString();
           
        }

        private void btnFirstData_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowData(pos);
        }

        private void btnLastData_Click(object sender, EventArgs e)
        {
            pos = dt.Rows.Count - 1;
            ShowData(pos);
        }

        private void btnPrevData_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                ShowData(pos);
            }
            else
            {
                MessageBox.Show("end of data");
            }
        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < dt.Rows.Count)
            {
                ShowData(pos);
               // MessageBox.Show("rows count :" % d"" dt.Rows.Count());
            }
            else
            {
                MessageBox.Show("end of data");
            }
        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO car_detail(RegNo, Model, Make) VALUES(@RegNo, @Model, @Make)", con);
                cmd.Parameters.Add("@RegNo", SqlDbType.Int);
                cmd.Parameters.Add("@Model", SqlDbType.Char);
                cmd.Parameters.Add("@Make", SqlDbType.Char);

                cmd.Parameters["@RegNo"].Value = txtRegNo.Text;
                cmd.Parameters["@Model"].Value = txtCarModel.Text;
                cmd.Parameters["@Make"].Value = txtCarMake.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted new data");
                Refresh_Data_In_Table_In_Run_Time(pos);
               // ShowData(pos);
   
            }
            catch
            {
                MessageBox.Show("error in inserting data - exception loop");
            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            // special code
            //SqlCommandBuilder cb = new SqlCommandBuilder();
            // special code

            con.Open();
            cmd = new SqlCommand(@"UPDATE car_detail SET Model='" + txtCarModel.Text + "', Make='" + txtCarMake.Text + "' WHERE RegNo=" + txtRegNo.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                // Refresh_Data_In_Table_In_Run_Time(pos);
                //ShowData(pos);
                //da.Update(dt);

                /////////////////////
               // da.UpdateCommand = cb.GetUpdateCommand(true);
                /////////////////////

            }
            catch(Exception x)
            {
                MessageBox.Show("Not updated. exception Loop !" + x.Message);

            }
            finally
            {
               con.Close();
            }
        }
    }
}
