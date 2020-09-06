using System;
using System.Collections.Generic;

namespace SortedListWithDelegates
{
    public delegate int Comparison<in T>(T x, T y);
    public class Program
    {
        public static void Main()
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };

            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };

            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 4500
            };

            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };

            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Hina",
                Gender = "Female",
                Salary = 7500
            };

            Employee emp6 = new Employee()
            {
                ID = 106,
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

            //Apprach2
            //Using Anonymous methid
            //listEmployees.Sort(delegate (Employee e1, Employee e2)
            //                {
            //                    return e1.Gender.CompareTo(e2.Gender);
            //                });

            //Approach3
            //using Lambda Expression
            listEmployees.Sort((x, y) => x.Gender.CompareTo(y.Gender));

            Console.WriteLine("Employees After sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }

            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}