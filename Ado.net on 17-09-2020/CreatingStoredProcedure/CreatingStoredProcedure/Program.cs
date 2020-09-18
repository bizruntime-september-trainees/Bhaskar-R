using System;
using System.Data.SqlClient;

namespace CreatingStoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PRO60VG;Initial Catalog=Customer;Integrated Security=True");
            string query =
              @"
                CREATE PROCEDURE Insert_Record_Procedure
                (
                @Name VARCHAR(50),
                @Price VARCHAR(50),
                @Date DATETIME
                )
              AS
                INSERT INTO Products1(Name,Price,Date) Values(@Name,@Price,@Date)
            ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Store Procedure Created Successfully");
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