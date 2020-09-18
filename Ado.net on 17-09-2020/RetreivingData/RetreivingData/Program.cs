﻿using System.Data.SqlClient;
using System.Data;
using System;
namespace RetrieveData
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Customer;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Retrieve_Record_Procedure11", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", "SSD DRIVE"));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Product Name : " + dr["Name"]);
                    Console.WriteLine("Price : " + dr["price"]);
                    Console.WriteLine("Date : " + dr["Date"]);
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