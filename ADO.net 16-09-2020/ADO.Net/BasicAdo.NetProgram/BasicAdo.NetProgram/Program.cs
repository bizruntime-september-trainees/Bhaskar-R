using System;
using System.Data.SqlClient;

namespace BasicAdo.NetProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTable();
        }
        public static void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                // con = new SqlConnection("data source=.; database=student; integrated security=true");
                con = new SqlConnection("data source=DESKTOP-PRO60VG; database=student; integrated security=true");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table address1(name varchar(100), email varchar(50), city varchar(50))", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}