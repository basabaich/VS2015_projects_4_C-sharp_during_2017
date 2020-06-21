using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataExp5
{
    public partial class Form1 : Form
    {
        //my code : change this code
         OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\basab\Desktop\Database files\vehicle_list_2.accdb");
        // change thsi code
        
        DataSet ds = new DataSet();       
        // my code
        

        /*====================================================================================================================*/


        public Form1()
        {
            InitializeComponent();
           
        }

        DataTable DATA;

        /*====================================================================================================================*/


        private void Form1_Load(object sender, EventArgs e)
        {
            view();
        }

        /*====================================================================================================================*/


        public void view()
        {
            //////////////////////////////////////////////////////////////////////////
            //                    M O S T - I M P O R T A N T                       //       
            //              Please see the note in making this code here            //
            /////////////////////////////////////////////////////////////////////////

            /*  Note - it is important that we define a new & different 'DataAdapter' */
            /*  a new & different 'DataTable' and then fill data with this. Such      */
            /*  variables must not be used anywhere else in our code. Moreover we     */
            /*  should use a single function where the 'Data' 'Fill' activity should  */
            /*  be called. Otherwise 'Data' 'Fill' corruption in table will occur     */

            con.Open();

            // If we want to show every thing from the table - even the ID numbers also 
            // SqlDataAdapter SDA = new SqlDataAdapter(@"SELECT * FROM fourwheels", con);

            // If we want to show only few columns in the datagrid box.
            OleDbDataAdapter SDA = new OleDbDataAdapter(@"SELECT RegNo,Model,Make FROM fourwheels2", con);
            //DataTable 
            DATA = new DataTable();
            SDA.Fill(DATA);
            dataGridView1.DataSource = DATA;
            con.Close();

        }


        /*====================================================================================================================*/



        private void btnInsertData_Click(object sender, EventArgs e)
        {                        
           // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\datasource\vehicle_list_1.mdf;Integrated Security=True;Connect Timeout=30");
            
            try
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(@"INSERT INTO fourwheels2(RegNo, Model, Make) VALUES ('" + txtRegNo.Text + "','" + txtCarModel.Text + "','" + txtCarMake.Text + "')", con);
                da.SelectCommand.ExecuteNonQuery();                
                MessageBox.Show("inserted new data");
                con.Close();
                view();                              
            }

            catch (Exception x)
            {
                MessageBox.Show("error - exception loop :"+ x.Message);
            }
            finally
            {
               con.Close();
            }

        }


        /*====================================================================================================================*/

        private void btnUpdateData_Click(object sender, EventArgs e)
        {

          //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\datasource\vehicle_list_1.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter (@"UPDATE fourwheels2 SET Model='" + txtCarModel.Text + "', Make='" + txtCarMake.Text + "' WHERE RegNo='" + txtRegNo.Text + "' ", con);
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Updated changed data against Reg No..");
                con.Close();
                view();
          
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

        /*====================================================================================================================*/



        private void btnDeleteData_Click(object sender, EventArgs e)
        {

          //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\datasource\vehicle_list_1.mdf;Integrated Security=True;Connect Timeout=30");
                
            try
            {

                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(@"DELETE FROM fourwheels2 WHERE RegNo='" + txtRegNo.Text + "' ", con);
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully against Reg No..");
                con.Close();
                view();

            }
            catch (Exception x)
            {
                MessageBox.Show("Not deleted due to some errors - exception loop.." + x.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /*====================================================================================================================*/


        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtRegNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtCarModel.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtCarMake.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }



        /*====================================================================================================================*/



        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(DATA);
            dv.RowFilter = string.Format("Model LIKE '%{0}%'", textBoxSearch.Text);
            dataGridView1.DataSource = dv;
        }


        /*====================================================================================================================*/



    }
}
