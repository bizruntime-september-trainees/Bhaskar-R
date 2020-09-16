using System;
using System.Data.SqlClient;

namespace ReadingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            String query = "select * from student";
            try
            {
                con = new SqlConnection("data source= DESKTOP-PRO60VG;database=Student; integrated security=true");
                SqlCommand command = new SqlCommand(query, con);
                con.Open();

                SqlDataReader read = command.ExecuteReader();
                while(read.Read())
                {
                    Console.WriteLine(read["id"] + " " + read["name"] + " " + read["email"] + " " + read["join_date"] );
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
