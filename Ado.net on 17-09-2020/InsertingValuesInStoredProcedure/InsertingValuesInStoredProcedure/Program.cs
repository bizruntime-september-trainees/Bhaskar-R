using System;
using System.Data.SqlClient;
using System.Data;

namespace Create_Store_Procedure
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Customer;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert_Record_Procedure", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", "SSD DRIVE"));
                cmd.Parameters.Add(new SqlParameter("@Price", "300"));
                cmd.Parameters.Add(new SqlParameter("@Date", "25 september 2020"));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Records Inserted Successfully.");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}