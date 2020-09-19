using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace AdoconfigurationFile
{
    class Program
    {
        static void Main(string[] args)
        {
            String conString = ConfigurationManager.ConnectionStrings["AdoconfigurationFile.Properties.Settings.Setting"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                String Query = @"
                     Create procedure spGetPrice
                     @Name varchar(50)
                     As
                     SELECT price FROM Products1 where @Name=@name;
                ";
                SqlCommand command = new SqlCommand(Query, con);

                command.ExecuteNonQuery();
                Console.WriteLine("query creatd successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
