using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryMethods
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
            
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Ram",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priya",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Bhaskar",
                Gender = "Male",
                Salary = 40000
            };
            
            Dictionary<int, Employee> dictionaryEmployees = new Dictionary<int, Employee>();
           
            dictionaryEmployees.Add(emp1.ID, emp1);
            dictionaryEmployees.Add(emp2.ID, emp2);
            dictionaryEmployees.Add(emp3.ID, emp3);
            
           
            Console.WriteLine("Total  Employee in Dictionary = {0}", dictionaryEmployees.Count());
            
            Console.WriteLine();
            
            Console.WriteLine("Male Employee are = {0}:",dictionaryEmployees.Count(x => x.Value.Gender == "Male"));
            Console.WriteLine();
            Console.WriteLine("Female Employee are = {0}:", dictionaryEmployees.Count((x => x.Value.Gender == "Female")));
            dictionaryEmployees.Remove(101);
            
            dictionaryEmployees.Clear();
            
            Employee[] arrayEmployees = new Employee[3];
            arrayEmployees[0] = emp1;
            arrayEmployees[1] = emp2;
            arrayEmployees[2] = emp3;
            
            Dictionary<int, Employee> dict = arrayEmployees.ToDictionary(employee => employee.ID, employee => employee);
            
            foreach (KeyValuePair<int, Employee> kvp in dict)
            {                
                Console.WriteLine("Key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }

        }
    }
    
}
