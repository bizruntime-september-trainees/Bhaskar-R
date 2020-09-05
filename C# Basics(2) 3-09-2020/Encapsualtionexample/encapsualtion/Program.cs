using System;
using System.Runtime.InteropServices;

namespace encapsualtion
{
    class Employee
    {
        private int e_id;
        private String name;
        private String city;
        private long salary;

        public int id
        {
            set {
                if (value<0)
                {
                    throw new Exception("Id should not  be negative.");
                }
                this.e_id = value;
            }
            get {     

                 return this.e_id;
            }
        }
        public String Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("name should not be null or empty");
                }
                this.name = value;
            }
            get
             {
                return this.name;
            }
        }
        public String City
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("name should not be null or empty");
                }
                this.city = value;
            }
            get
            {
                return this.city;
            }
        }
        public long Salary
        {
            get
            {
                return this.salary;
            }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.e_id= 101;
            e.name = "vishnu";
            e.city = "Bangalore";
            e.salary = 30000;           

            Console.WriteLine("emp id ={0} ", e.e_id);
            Console.WriteLine($"emp Name ={e.name}");
            Console.WriteLine($"emp city ={e.city}");
            Console.WriteLine($"emp salary = {e.Salary}");
        }
    }
}
