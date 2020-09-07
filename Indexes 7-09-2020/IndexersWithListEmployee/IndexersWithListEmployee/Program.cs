using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexersWithListEmployee
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }

    public class Company
    {        
        private List<Employee> listEmployees;        
        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee
            { EmployeeId = 101, Name = "Pranaya", Gender = "Male", Salary = 1000 });
            listEmployees.Add(new Employee
            { EmployeeId = 102, Name = "Preety", Gender = "Female", Salary = 2000 });
            listEmployees.Add(new Employee
            { EmployeeId = 103, Name = "Anurag", Gender = "Male", Salary = 5000 });
            listEmployees.Add(new Employee
            { EmployeeId = 104, Name = "Priyanka", Gender = "Female", Salary = 4000 });
            listEmployees.Add(new Employee
            { EmployeeId = 105, Name = "Hina", Gender = "Female", Salary = 3000 });
            listEmployees.Add(new Employee
            { EmployeeId = 106, Name = "Sambit", Gender = "Male", Salary = 6000 });
            listEmployees.Add(new Employee
            { EmployeeId = 107, Name = "Tarun", Gender = "Male", Salary = 8000 });
            listEmployees.Add(new Employee
            { EmployeeId = 108, Name = "Santosh", Gender = "Male", Salary = 7000 });
            listEmployees.Add(new Employee
            { EmployeeId = 109, Name = "Trupti", Gender = "Female", Salary = 5000 });
        }
       
        public string this[int employeeId]
        {
            get
            {
                return listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Name of Employee with Id = 101: " + company[101]);
            Console.WriteLine();
            Console.WriteLine("Name of Employee with Id = 105: " + company[105]);
            Console.WriteLine();
            Console.WriteLine("Name of Employee with Id = 107: " + company[107]);
            Console.WriteLine();

        }
    }
}
