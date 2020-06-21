using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// My data binding codes start here
using System.Data.Sql;
using System.Data.SqlClient;
// My data binding codes end here
using System.Windows.Forms;

namespace EmpSalSlab
{
    public partial class Form1 : Form
    {
        // My code here
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        // My code ends here

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\basab\Documents\sqlDataSalSlab.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            cmd = new SqlCommand("INSERT INTO  EmpTable(Name, Age, SalSlab) VALUES (@Name, @Age, @SalSlab)", con);

            cmd.Parameters.Add("@Name", SqlDbType.Char);
            cmd.Parameters["@Name"].Value = textBox1.Text;

            cmd.Parameters.Add("@Age", SqlDbType.Int);
            cmd.Parameters["@Age"].Value = textBox2.Text;

            cmd.Parameters.Add("@SalSlab", SqlDbType.Char);
            cmd.Parameters["@SalSlab"].Value = comboBox1.SelectedItem.ToString();

            cmd.ExecuteNonQuery();




        }
    }
}
