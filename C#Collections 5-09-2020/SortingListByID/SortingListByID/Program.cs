using System;
using System.Collections.Generic;

namespace SortingListByID_IComparable
{
    public class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int CompareTo(Employee obj)
        {
            if (this.ID > obj.ID)
            {
                return 1;
            }
            else if (this.ID < obj.ID)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            Employee emp1 = new Employee()
            {
                ID = 1001,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 1032,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                ID = 1023,
                Name = "Anurag",
                Gender = "Male",
                Salary = 4500
            };
            Employee emp4 = new Employee()
            {
                ID = 1004,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };
            Employee emp5 = new Employee()
            {
                ID = 1015,
                Name = "Hina",
                Gender = "Female",
                Salary = 7500
            };
            Employee emp6 = new Employee()
            {
                ID = 1005,
                Name = "Tarun",
                Gender = "Male",
                Salary = 6000
            };
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);
            listEmployees.Add(emp5);
            listEmployees.Add(emp6);
            Console.WriteLine("Employees before sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }

            listEmployees.Sort();
            Console.WriteLine("Employees After sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.ReadKey();
        }
    }
}
