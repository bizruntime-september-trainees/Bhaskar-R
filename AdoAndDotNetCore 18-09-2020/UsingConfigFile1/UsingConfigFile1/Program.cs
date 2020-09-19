using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Internal;

namespace UsingConfigFile1
{
    class Program
    {
       static SqlConnection connect = null;
        static void Main(string[] args)
        {
            //ConnectionStringSettingsCollection con = ConfigurationManager.ConnectionStrings;
            String file = ConfigurationManager.ConnectionStrings["AdoconfigurationFile.Properties.Settings.Setting"].ConnectionString;
            connect = new SqlConnection(file);
            connect.Open();          

            Console.WriteLine("connection successfully established");
            CreateProcedure(connect);
          RetreivePrice(connect);

        }
        public static void CreateProcedure(SqlConnection connect)
        {
            try
            {
                 String Query = @"
                     Create procedure spGetPrice123
                     @Name varchar(100)
                     As
                     select price from Products1 where @Name = name;
                ";
                SqlCommand command = new SqlCommand(Query, connect);
                
                command.ExecuteNonQuery();
                Console.WriteLine("query creatd successfully");                
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }            
        }
        static void RetreivePrice(SqlConnection connect)
        {
            try
            {
                String query1 = @"Execute spGetPrice123 @Name = 'SSD DRIVE'";
                SqlCommand cmd = new SqlCommand(query1, connect);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine(read["price"]);
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
