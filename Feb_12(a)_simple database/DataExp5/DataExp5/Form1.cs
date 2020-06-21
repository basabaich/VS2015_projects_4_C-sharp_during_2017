using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataExp3
{
    public partial class Form1 : Form
    {
        //my code : change this code
         OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Database_files\QuoteStatus2.accdb");
        // change this code as per MS Access database or SQL database
        DataSet ds = new DataSet();
        // my code
        OleDbCommand ocmd = new OleDbCommand();
        OleDbDataReader dbr;
        DataTable DATA;

        // Defining this string is very important
        String Quoted;
        /*====================================================================================================================*/



        public Form1()
        {
            InitializeComponent();
           
        }

       
       
       

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
            // OleDbDataAdapter SDA = new OleDbDataAdapter(@"SELECT * FROM Quotes", con);

            // If we want to show only few columns in the datagrid box.
            OleDbDataAdapter SDA = new OleDbDataAdapter(@"SELECT SlNo, CustomerName, Dates2, QuoteRef, Items_In_Quote, Total_Quote_Value, Quoted_If, Quoted, Offer_Pending_From_HO, Enq_Revised_By_Cust, Quote_Revised_By_Us, PO_Recvd, Negotiation_On,Enq_Dropped, Status FROM Quotes", con);

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

                OleDbDataAdapter da = new OleDbDataAdapter(@"INSERT INTO Quotes( SlNo, CustomerName, Dates2, QuoteRef, Items_In_Quote, Total_Quote_Value, Quoted, Status ) VALUES (  " + txtSLNo.Text + " ,' " + txtCustName.Text + " ' , ' " + dateTimePicker1.Text + " ' , ' " + txtQouteRef.Text + " ' , ' " + txtItemInQuote.Text + " ', " + txtTotalQuoteVal.Text + "  , ' " + Quoted + " ' , ' " + txtStatusOfQuote.Text + " ') ", con);
                //Quoted, Offer_Pending_From_HO, Enq_Revised_By_Cust, Quote_Revised_By_Us, PO_Recvd, Negotiation_On, Enq_Dropped, 

                //if (checkBox1.Checked)
                //{
                //    da = new OleDbDataAdapter(@"INSERT INTO (Quoted) VALUES (@true)", con);
                //}
                    

                da.SelectCommand.ExecuteNonQuery();
               // ocmd.ExecuteNonQuery(query, con);
               //if(System.Windows.Forms.CheckBox.CheckBoxAccessibleObject=true)
                MessageBox.Show("inserted new data");
               
                con.Close();
                view();

                ////////////////////////////////////////////////
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Database files\QuoteStatus2.accdb");
                //con.Open();
                //String query = (@"INSERT INTO Quotes( SlNo, CustomerName, Dates2, QuoteRef, Items_In_Quote, Total_Quote_Value, Status ) VALUES (  " + txtSLNo.Text + " ,' " + txtCustName.Text + " ' , ' " + dateTimePicker1.Text + " ' , ' " + txtQouteRef.Text + " ' , ' " + txtItemInQuote.Text + " ', " + txtTotalQuoteVal.Text + "  , ' " + txtStatusOfQuote.Text + " ') ");
                //OleDbCommand ocmd = new OleDbCommand(query, con);
                //dbr = ocmd.ExecuteReader();
                //MessageBox.Show("inserted new data");
                //while (dbr.Read())
                //{

                //}
                //con.Close();
                //view();
                /////////////////////////////////////////////

            }

            catch (Exception x)
            {
                MessageBox.Show("error - exception loop :" + x.Message);
            }
            finally
            {
                con.Close();
            }

        }


        /*====================================================================================================================*/

        //private void btnUpdateData_Click(object sender, EventArgs e)
        //{

        //  //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\datasource\vehicle_list_1.mdf;Integrated Security=True;Connect Timeout=30");

        //    try
        //    {
        //        con.Open();
        //        OleDbDataAdapter da = new OleDbDataAdapter (@"UPDATE Quotes SET Model='" + txtCustName.Text + "', Make='" + txtQouteRef.Text + "' WHERE RegNo=" + txtSlNo.Text + " ", con);
        //        da.SelectCommand.ExecuteNonQuery();
        //        MessageBox.Show("Updated changed data against Reg No..");
        //        con.Close();
        //        view();
          
        //    }

        //    catch(Exception x)
        //    {
        //        MessageBox.Show("Not updated. exception Loop !" + x.Message);

        //    }
        //    finally
        //    {
        //       con.Close();
        //    }
        //}

        /*====================================================================================================================*/



        private void btnDeleteData_Click(object sender, EventArgs e)
        {

          //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\datasource\vehicle_list_1.mdf;Integrated Security=True;Connect Timeout=30");
                
            //try
            //{

            //    con.Open();
            //    OleDbDataAdapter da = new OleDbDataAdapter(@" DELETE FROM Quotes WHERE Sl no= " + txtSLNo.Text + " ", con);
            //    da.SelectCommand.ExecuteNonQuery();
            //    MessageBox.Show("Deleted successfully against ID No..");
            //    con.Close();
            //    view();

            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show("Not deleted due to some errors - exception loop.." + x.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Quoted = "1";
            }
            else
                Quoted = "0";

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  MessageBox.Show("Want to exit program ? ");
            Application.Exit();
        }

        /*====================================================================================================================*/


        //private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    txtSlNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        //    txtCustName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //    txtQouteRef.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        //}



        /*====================================================================================================================*/



        //private void textBoxSearch_TextChanged(object sender, EventArgs e)
        //{
        //    DataView dv = new DataView(DATA);
        //    dv.RowFilter = string.Format("Model LIKE '%{0}%'", textBoxSearch.Text);
        //    dataGridView1.DataSource = dv;
        //}



        /*====================================================================================================================*/



    }
}
