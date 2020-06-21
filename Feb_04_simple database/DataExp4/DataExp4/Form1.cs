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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\vehicle_list_1.mdf;Integrated Security=True;Connect Timeout=30");

        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();       
        // my code
        int pos = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;

        int InitialRowCount = 0;
        int ChangedRowCount = 0;
        int CorrectRowCount = 0;
        int MaxRowNum = 0;

        int FillDataBtnPressed = -1;
        int FillDataCount = 0;
        int LastDataBtnClickCounter = 0;

        bool IsBtnInsertPressed = false;
        bool IsBtnUpdatePressed = false;
        bool IsBtnDeletePressed = false;


        public Form1()
        {
            InitializeComponent();
           
            // Set Initial Row number  only once when the form is initialised
            // for the first time

            //InitialRowCount = dt.Rows.Count;
            //MessageBox.Show("row numbers now_0 :", InitialRowCount.ToString());
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loading form details for the first time only
            FillDataInRows();
            ShowData(pos);
          //  MessageBox.Show("Update table sequence called : ", pos.ToString());
            
            //// Set Initial Row number  only once when the form is getting loaded
            //// for the first time
            //InitialRowCount = dt.Rows.Count - 1;

          //  MessageBox.Show("row numbers now_Load_1 :", InitialRowCount.ToString());
        }

  
        public void FillDataInRows()
        {
            //InitialRowCount = dt.Rows.Count;
            //MessageBox.Show("row numbers now_Fill_0(a) :", InitialRowCount.ToString());

            da = new SqlDataAdapter("SELECT * FROM fourwheels", con);
            da.Fill(dt); // Data fill cycle executed here

            if (FillDataCount == 0)
            {
                // Initial row numbers set here
                InitialRowCount = dt.Rows.Count;
                MessageBox.Show("row numbers now_Fill_0(a) :", InitialRowCount.ToString());
                FillDataCount++;
                MessageBox.Show("row numbers now_Fill_0(b) :", FillDataCount.ToString());
            }
            else
            {
                ChangedRowCount = dt.Rows.Count; // Changed row numbers defined here now
                MessageBox.Show("row numbers now_Fill_1(a) :", ChangedRowCount.ToString());
                FillDataCount++;
                MessageBox.Show("row numbers now_Fill_1(b) :", FillDataCount.ToString());
            }


            FillDataBtnPressed++;
            MessageBox.Show("row numbers now_Fill_2 :", FillDataBtnPressed.ToString());

            // CorrectRowCount = ChangedRowCount - (InitialRowCount * FillDataBtnPressed);
            CurrRowNum();
            //MessageBox.Show("row numbers now_Fill_3 :", CorrectRowCount.ToString());
        }


        //// Corrected Row number is calculated here
        //public void CurrRowNum()
        //{
        //    MaxRowNum = ChangedRowCount - (InitialRowCount * (FillDataBtnPressed-1));
        //    if (MaxRowNum == 0)
        //    {
        //        CorrectRowCount = InitialRowCount;
        //        MessageBox.Show("row numbers now_curr_1 :", InitialRowCount.ToString());
        //        MessageBox.Show("row numbers now_curr_2 :", ChangedRowCount.ToString());
        //        MessageBox.Show("row numbers now_curr_3 :", FillDataBtnPressed.ToString());
        //        MessageBox.Show("row numbers now_curr_4 :", MaxRowNum.ToString());
        //    }
        //    else
        //    {
        //        CorrectRowCount = MaxRowNum;
        //        MessageBox.Show("row numbers now_curr_5 :", InitialRowCount.ToString());
        //        MessageBox.Show("row numbers now_curr_6 :", ChangedRowCount.ToString());
        //        MessageBox.Show("row numbers now_curr_7 :", FillDataBtnPressed.ToString());
        //        MessageBox.Show("row numbers now_curr_8 :", MaxRowNum.ToString());
        //    }
        //}



        // Corrected Row number is calculated here
        public void CurrRowNum()
        {
            CorrectRowCount = InitialRowCount+FillDataBtnPressed;
            MessageBox.Show("row numbers now_curr_1 :", InitialRowCount.ToString());
            MessageBox.Show("row numbers now_curr_2 :", CorrectRowCount.ToString());
            MessageBox.Show("row numbers now_curr_3 :", FillDataBtnPressed.ToString());
           // MessageBox.Show("row numbers now_curr_4 :", MaxRowNum.ToString())


            //MaxRowNum = ChangedRowCount - (InitialRowCount * (FillDataBtnPressed - 1));
            //if (MaxRowNum == 0)
            //{
            //    CorrectRowCount = InitialRowCount;
            //    MessageBox.Show("row numbers now_curr_1 :", InitialRowCount.ToString());
            //    MessageBox.Show("row numbers now_curr_2 :", ChangedRowCount.ToString());
            //    MessageBox.Show("row numbers now_curr_3 :", FillDataBtnPressed.ToString());
            //    MessageBox.Show("row numbers now_curr_4 :", MaxRowNum.ToString());
            //}
            //else
            //{
            //    CorrectRowCount = MaxRowNum;
            //    MessageBox.Show("row numbers now_curr_5 :", InitialRowCount.ToString());
            //    MessageBox.Show("row numbers now_curr_6 :", ChangedRowCount.ToString());
            //    MessageBox.Show("row numbers now_curr_7 :", FillDataBtnPressed.ToString());
            //    MessageBox.Show("row numbers now_curr_8 :", MaxRowNum.ToString());
            //}
        }


        // These details get updated every time there is a change in data
        private void Referesh_Changed_Data_In_Table()
        {
            da = new SqlDataAdapter("SELECT * FROM fourwheels", con);
            da.Fill(dt);
            da.Update(dt);
            ShowData(pos);
            MessageBox.Show("Update table sequence called : ", pos.ToString());
        }



        private void ShowData(int index)
        {
           
            //this.txtRegNo.Update();
            //this.txtCarModel.Update();
            //this.txtCarMake.Update();


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

            //ShowData(InitialRowCount);

        }

        private void btnLastData_Click(object sender, EventArgs e)
        {
            
            if (IsBtnInsertPressed==false)
            {
                
                MessageBox.Show("show row count_Last data_1:", CorrectRowCount.ToString());
                ShowData(CorrectRowCount - 1);
                MessageBox.Show("show row count_Last data_2:", CorrectRowCount.ToString());
                LastDataBtnClickCounter++;
                this.Update();
            }
            else
            {
                MessageBox.Show("in last button click, going to 'FillDataInRows()'...");
                FillDataInRows();

                MessageBox.Show("show row count_Last data_3:", CorrectRowCount.ToString());
                ShowData(CorrectRowCount - 1);
                MessageBox.Show("show row count_Last data_4:", CorrectRowCount.ToString());
                LastDataBtnClickCounter++;
                this.Update();
            }
           
        }

        private void btnPrevData_Click(object sender, EventArgs e)
        {
            //pos--;
            if (pos > 0)
            {
                MessageBox.Show("Previous pos_1 : ", pos.ToString());
                //ShowData(pos);
                if (pos > 0)
                {
                    MessageBox.Show("previous pos_2 : ", pos.ToString());
                    pos--;
                    ShowData(pos);
                    MessageBox.Show("previous pos_3 : ", pos.ToString());
                }
                else
                {
                    //do no addition is pos = 0
                    pos = 0;
                    MessageBox.Show("previous else pos_4 : ", pos.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("end of data - pos_5 :", pos.ToString());
            }
        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
            
            //pos++;
            if (pos < dt.Rows.Count-1)
            {
                MessageBox.Show("Counting in Next Loop_1 : ",pos.ToString());
                //ShowData(pos);
                if (pos < dt.Rows.Count)
                {
                    pos++;
                    ShowData(pos);
                    MessageBox.Show("counting in Next Loop_2 :", pos.ToString());
                }
                else
                {
                    //do no addition is pos = dt.rows.count
                    pos=dt.Rows.Count;
                    MessageBox.Show("Counting in Next Loop_3 : ", pos.ToString());
                }
            }
            else
            {
                MessageBox.Show("end of Next data as pos is : ", pos.ToString());
            }
        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {

            IsBtnInsertPressed = true;


            try
            {

                //SqlDataAdapter da2 = new SqlDataAdapter();

                con.Open();
                cmd = new SqlCommand(@"INSERT INTO fourwheels(RegNo, Model, Make) VALUES(@RegNo, @Model, @Make)", con);
                cmd.Parameters.Add("@RegNo", SqlDbType.Int);
                cmd.Parameters.Add("@Model", SqlDbType.Char);
                cmd.Parameters.Add("@Make", SqlDbType.Char);

                cmd.Parameters["@RegNo"].Value = txtRegNo.Text;
                cmd.Parameters["@Model"].Value = txtCarModel.Text;
                cmd.Parameters["@Make"].Value = txtCarMake.Text;

                
                cmd.ExecuteNonQuery();
                //this.txtRegNo.Update();
                //this.txtCarModel.Update();
                //this.txtCarMake.Update();


                // A VERY IMPORTANT CODE. ALWAYS MAKE THIS CODE AS A SEPERATE FUNCTION TO WORK CORRECTLY
                //Referesh_Changed_Data_In_Table();
                // END OF A VERY IMPORTANT CODE.

                // Disconnect the dataconnection here before filling the table thorugh data adapter
                // con.Close();

                // /////////////////////////////////
                // da2 = new SqlDataAdapter("SELECT * FROM car_detail", con);
                // MessageBox.Show("pos val before fill:", pos.ToString());
                // a = dt.Rows.Count;
                // MessageBox.Show("row count_1: ", a.ToString());

                // da2.AcceptChangesDuringFill.ToString();
                // //da2.Fill(dt);
                // //da.Update(dt);
                // MessageBox.Show("pos val after fill :", pos.ToString());

                // b = dt.Rows.Count;
                // d = b - a;
                //// dt.Rows.Count();

                // //(b - a);
                // MessageBox.Show("row count_2:", b.ToString());
                // ShowData(pos);
                // c = dt.Rows.Count;
                // MessageBox.Show("Update 'ShowData()':", pos.ToString());
                // MessageBox.Show("row count_3 :", c.ToString());
                // ///////////////////////////////////

                ///////////////////////////////////
                // This code actually loads the form for a second time with new data updated condoition
                //Form1 fr = new Form1(); // Calls a new instance of the same form so that it can be loaded
                //fr.Show(); // calls the new form to show / display itself
                //this.Hide(); // calls the old form to hide itself. Note : we found that Close() & Dispose()
                //             // commands are actually exiting the application itself.
                // End of new form loading code
                //////////////////////////////////////

                //MessageBox.Show("pos val_1 :", pos.ToString());
                //string quaryString = "SELECT RegNo, Model, Make FROM car_detail";
                //MessageBox.Show("pos val_2 :", pos.ToString());

                //SqlDataAdapter da1 = new SqlDataAdapter(quaryString, con);
                //MessageBox.Show("pos val_3 :", pos.ToString());
                //DataSet ds1 = new DataSet();

                //MessageBox.Show("pos val before fill :", pos.ToString());
                //da1.Fill(ds1);
                //MessageBox.Show("pos val after fill :", pos.ToString());
                ////da =(quaryString, con);


                //a = dt.Rows.Count;
                //MessageBox.Show("row count_1: ", a.ToString());
                //MessageBox.Show("value of pos_1: ", pos.ToString());

                //da = new SqlDataAdapter("SELECT * FROM car_detail", con);

                //MessageBox.Show("row count_2: ", a.ToString());
                //MessageBox.Show("value of pos_2: ", pos.ToString());


                //da.Fill(ds);

                //MessageBox.Show("row count_3: ", a.ToString());
                //MessageBox.Show("value of pos_3: ", pos.ToString());


                //MessageBox.Show("inserted data clicked.\n Going to 'FillDataInRows()' loop..");
                //FillDataInRows();
               
                MessageBox.Show("inserted new data");
   
            }
            catch(Exception x)
            {
                MessageBox.Show("error - exception loop :"+ x.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
 
            con.Open();
            cmd = new SqlCommand(@"UPDATE fourwheels SET Model='" + txtCarModel.Text + "', Make='" + txtCarMake.Text + "' WHERE RegNo=" + txtRegNo.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();

                // A VERY IMPORTANT CODE. ALWAYS MAKE THIS CODE AS A SEPERATE FUNCTION TO WORK CORRECTLY
                Referesh_Changed_Data_In_Table();
                // END OF A VERY IMPORTANT CODE.

                MessageBox.Show("Updated");

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

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
           // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\Student.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            cmd = new SqlCommand(" delete from fourwheels where RegNo = " + txtRegNo.Text + " ", con);

            try
            {

                cmd.ExecuteNonQuery();

                // A VERY IMPORTANT CODE. ALWAYS MAKE THIS CODE AS A SEPERATE FUNCTION TO WORK CORRECTLY
                Referesh_Changed_Data_In_Table();
                // END OF A VERY IMPORTANT CODE.

                MessageBox.Show("Deleted data successfully..", "Status");

                //textBox1.Clear();
                //textBox2.Clear();
                //textBox3.Clear();
                //textBox4.Clear();
                //textBox1.Focus();

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
    }
}
