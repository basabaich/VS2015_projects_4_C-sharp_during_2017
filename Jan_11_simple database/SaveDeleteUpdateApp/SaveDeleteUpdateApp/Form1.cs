using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaveDeleteUpdateApp
{
    public partial class Form1 : Form
    {

        // Initialize components
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\Student.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adapter;
        // Binding data with form & data table so that any changes are shown automatically
        DataTable table = new DataTable();
        BindingSource bs = new BindingSource();
        DataSet dset;
        
         int pos = 0;

        SqlCommand comm;
        SqlDataReader dreader;
       
   
        public Form1()
        {
            InitializeComponent();
            
            
        }

        

        private void Form1_Load(object sender, EventArgs e) // On form load in operating system
        {
            adapter = new SqlDataAdapter("SELECT * FROM student_detail", conn);
            adapter.Fill(table);
            showData(pos);
            this.Invalidate();
            this.Update();
            this.Refresh();
                    
        }

        // New Class 'showData()' defined here
        public void showData(int index)
        {
            textBox1.Text = table.Rows[index][1].ToString();
            textBox2.Text = table.Rows[index][2].ToString();
            textBox3.Text = table.Rows[index][3].ToString();
            textBox4.Text = table.Rows[index][4].ToString();
            this.Invalidate();
            this.Update();
            this.Refresh();
        }
        // New Class definition ends here


        private void Update_Data_In_Table_In_Run_Time(int index)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\Student.mdf;Integrated Security=True;Connect Timeout=30");
            adapter = new SqlDataAdapter("SELECT * FROM student_detail", conn);
            adapter.Fill(table);
            showData(pos);
        }


        private void Update_Delete_In_Table(int index)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\Student.mdf;Integrated Security=True;Connect Timeout=30");
            adapter.Update(table);
            showData(pos);
        }

        private void btnSave_Click(object sender, EventArgs e) // Button to save new data
        {

            conn.Open();
            comm = new SqlCommand("INSERT INTO student_detail(roll_no, s_name, age, course) VALUES (@roll_no, @s_name, @age, @course)", conn);

            comm.Parameters.Add("@roll_no", SqlDbType.Int);
            comm.Parameters["@roll_no"].Value = textBox1.Text;

            comm.Parameters.Add("@s_name", SqlDbType.Char);
            comm.Parameters["@s_name"].Value = textBox2.Text;

            comm.Parameters.Add("@age", SqlDbType.Int);
            comm.Parameters["@age"].Value = textBox3.Text;

            comm.Parameters.Add("@course", SqlDbType.Char);
            comm.Parameters["@course"].Value = textBox4.Text;

            try
            {
                comm.ExecuteNonQuery();
        
                MessageBox.Show("Saved","Status of your inputs",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                Update_Data_In_Table_In_Run_Time(pos);


                // Clear the text boxes now from old inputs
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                // Focus & put the cursor on the first box now
                textBox1.Focus();
            }
            catch(Exception)
            {
                MessageBox.Show("Not Saved !!");
            }
            finally
            {
                conn.Close();
            }

        }


        private void btnClear_Click(object sender, EventArgs e) // Clear Button event
        {
            // Clear the text boxes now from old inputs
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Focus & put the cursor on the first box now
            textBox1.Focus();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
             conn.Open();

            comm = new SqlCommand("select * from student_detail where roll_no ="+textBox1.Text+"", conn);

            try
            {
                dreader = comm.ExecuteReader();
                if(dreader.Read())
                {
                    textBox2.Text = dreader[2].ToString(); // It will start with dreader[2] instead of dreader[1]
                    textBox3.Text = dreader[3].ToString(); // as dreader[1] represents the roll_no field
                    textBox4.Text = dreader[4].ToString(); // and we are searching data against roll_no field
                   

                }
                else
                {
                    MessageBox.Show("No Records available here !!");
                }
                dreader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Record - (exception loop) !!");
            }
            finally
            {
                conn.Close();
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)// Delete data button
        {
            conn.Open();
            comm = new SqlCommand(@"UPDATE student_detail SET s_name='" + this.textBox2.Text + "', age='" + this.textBox3.Text+ "', course='" + this.textBox4.Text + "' where roll_no ='"+ this.textBox1.Text + "'; ", conn);
            //SqlDataAdapter adapter;
            // Note the above command will change data against roll numbers
            // If there are multiple roll numbers which are same then 
            // if against this roll number if we click 'Update' - it will change
            // all records same against this same roll number details. 
            // So it is always good to change teh daa based on the ID & not on roll number or on name 
            try
            {
                comm.ExecuteNonQuery();
                
                MessageBox.Show("Data Updated...");
                Update_Data_In_Table_In_Run_Time(pos);

                // Clears all the text boxes in the form as data is already updated
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                // Now that the text boxes are all clear, keep the cursor in the first box
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Not updated - (exception loop) !!");
            }
            finally
            {
                
                conn.Close();
            }

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\Student.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            comm = new SqlCommand(" delete from student_detail where roll_no = " + textBox1.Text + " ", conn);

            try
            {
               
                comm.ExecuteNonQuery();
                // conn.Dispose();
                //  conn.Close();
                //  SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\Student.mdf;Integrated Security=True;Connect Timeout=30");
                //  conn.Open();
                //  comm = new SqlCommand(" delete from student_detail where roll_no = " + textBox1.Text + " ", conn);

                /////////////////////////
                //adapter = new SqlDataAdapter("SELECT * FROM student_detail", conn);
                //adapter.Fill(table);
                
               // adapter.
                //showData(pos);
                ///////////////////
                //this.Invalidate();
                //this.Update();

                MessageBox.Show("Deleted data successfully !!", "Status of your inputs", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();

                // Update_Data_In_Table_In_Run_Time(pos);
                //while (dreader.Read())
                //{

                //}
                //conn.Close();


                //// Clear the text boxes now from old inputs
                
                //// Focus & put the cursor on the first box now
                //textBox1.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("Not deleted due to some errors - exception loop.." + x.Message);
            }
            finally
            {
                //adapter.Update(dset);
                conn.Close();
            }
        }



        private void btnFirstData_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);    
        }

        private void btnPrevData_Click(object sender, EventArgs e)
        {
  
            pos--;
            if(pos >=0)
            {
               // adapter.Update(dset);
                showData(pos);
            }
            else
            {
                MessageBox.Show("Reached begining of record");
            }

        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
 
            pos++;
            if(pos<table.Rows.Count)
            {
                //adapter.RowUpdated();
                showData(pos);
            }
            else
            {
                MessageBox.Show("Reached end of record");
                //pos = table.Rows.Count - 1;
            }

        }

        private void btnLastData_Click(object sender, EventArgs e)
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
