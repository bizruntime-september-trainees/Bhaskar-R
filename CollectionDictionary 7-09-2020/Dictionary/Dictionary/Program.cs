using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<int, Employee> dictionaryEmployees = new Dictionary<int, Employee>()
            {
                { 101, new Employee {ID=101, Name="Pranaya", Gender="Male", Salary = 20000}},
                { 102, new Employee {ID=101, Name="Priyanka", Gender="Female", Salary = 30000}},
                { 103, new Employee {ID=101, Name="Anurag", Gender="Male", Salary = 40000}}
            };

          
            Console.WriteLine("All employees objects are:");
            foreach (Employee emp in dictionaryEmployees.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            
        }
    }
   
}