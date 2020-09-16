using System;
using System.Data.SqlClient;

namespace InsertingvaluesToTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {

                con = new SqlConnection("data source = DESKTOP-PRO60VG;database = Student;Integrated Security=true");

                String query = "insert into student(id,name,email,join_date) values(103,'Root','Root123@gmail.com',GETDATE())";

                SqlCommand command = new SqlCommand(query, con);

                con.Open();

                command.ExecuteNonQuery();
               
                Console.WriteLine("data inserted.");
            }
            catch(SqlException ex)
            {
                Console.WriteLine("data not inserted" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
