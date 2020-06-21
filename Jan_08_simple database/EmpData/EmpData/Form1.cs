using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// My data binding codes start here
using System.Data.Sql;
using System.Data.SqlClient;
// My data binding codes end here

namespace EmpData
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

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\basab\Desktop\Database files\TestSqlInsert.mdf; Integrated Security = True; Connect Timeout = 30");

            con.Open();
            cmd = new SqlCommand("INSERT INTO  EmpData(Name, Eid, Gender) VALUES (@Name, @Eid, @Gender)", con);

            cmd.Parameters.Add("@Name", SqlDbType.Char);
            cmd.Parameters["@Name"].Value = textBox1.Text;

            cmd.Parameters.Add("@Eid", SqlDbType.Char);
            cmd.Parameters["@Eid"].Value = textBox2.Text;

            cmd.Parameters.Add("@Gender", SqlDbType.Char);
            cmd.Parameters["@Gender"].Value = comboBox1.SelectedItem.ToString();
                
            cmd.ExecuteNonQuery();

        }
    }
}
