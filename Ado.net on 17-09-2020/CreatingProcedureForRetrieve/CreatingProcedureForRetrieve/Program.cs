using System;
using System.Data.SqlClient;

namespace CreatingProcedureForRetrieve
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Customer;Integrated Security=True");
            string query =
              @"
               CREATE PROCEDURE Retrieve_Record_Procedure11
                (
                @Name VARCHAR(100)
                )
                AS
                SELECT * FROM Products1 where @Name=@name;
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