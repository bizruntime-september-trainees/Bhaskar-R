using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsLinq
{
    public class Customer
    {
        public int customerId { set; get; }
        public String customerName { set; get; }
        public String gender { set; get; }

        public static List<Customer> GetCustomers()
        {
            List<Customer> listCust = new List<Customer>();
            Customer cust1 = new Customer()
            {
                customerId = 101,
                customerName = "Bhaskar",
                gender = "Male"
            };
            listCust.Add(cust1);
            Customer cust2 = new Customer()
            {
                customerId = 102,
                customerName = "Ramesh",
                gender = "Male"
            };
            listCust.Add(cust2);
            Customer cust3 = new Customer()
            {
                customerId = 103,
                customerName = "Sridhar",
                gender = "Male"
            };
            listCust.Add(cust3);
            Customer cust4 = new Customer()
            {
                customerId = 104,
                customerName = "Neha",
                gender = "Female"
            };
            listCust.Add(cust4);
            return listCust;
        }
    }
        public class Program1
        { 
        static void Main(string[] args)
        {
            var query = from Customer cust in Customer.GetCustomers()
                        where cust.gender == "Male"
                        select cust;

            Console.WriteLine("male candidates are:");

            foreach(var gen in query)
            {
                Console.WriteLine(gen.customerId + "\t" + gen.customerName);
            }
        }
    }
}
