using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataCon1
{

    class Program
    {

        SqlConnection conn = new SqlConnection("Server=[myServerAddress];Database=[myDataBase];User Id=myUsername");
         
        
        
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=[myServerAddress];Database=[myDataBase];User Id=myUsername";
                conn.Open();

                // use the connection here
                // Create the command
                SqlCommand command = new SqlCommand("SELECT * FROM TableName WHERE FirstColumn = @firstColumnValue", conn);
                // Add the parameters.
                command.Parameters.Add(new SqlParameter("firstColumnValue", 1));

                // Create new SqlDataReader object and read data from the command.
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // while there is another record present
                    while (reader.Read())
                    {
                        // write the data on to the screen
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}",
                        // call the objects from their index
                        reader[0], reader[1], reader[2], reader[3]));
                    }
                }


            }






        }


    }


}
