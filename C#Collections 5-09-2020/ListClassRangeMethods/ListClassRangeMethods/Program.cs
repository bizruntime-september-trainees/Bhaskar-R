using System;
using System.Collections.Generic;
namespace ListCollectionrangeMethodDemo
{
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
                Salary = 5500
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
                Salary = 8500
            };
            List<Employee> listEmployees = new List<Employee>();
            Console.WriteLine("Add and AddRange Method");
            //Use Add() method to add one item at a time to the end of the list
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            //Create another list
            List<Employee> AnotherlistEmployees = new List<Employee>();
            AnotherlistEmployees.Add(emp4);
            AnotherlistEmployees.Add(emp5);
            AnotherlistEmployees.Add(emp6);

            //Use AddRange() method to add another list of items
            listEmployees.AddRange(AnotherlistEmployees);
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("GetRange Method");
            //Use GetRange() method to returns a range of items from the list.
            List<Employee> ListOfNewEmployees = listEmployees.GetRange(3, 3);
            foreach (Employee employee in ListOfNewEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("Remove RemoveAt and RemoveAll");
            //Use Remove() method to removes only the first matching item from the list.
            listEmployees.Remove(emp1);
            //Use RemoveAt() method to remove an item from a specified index.
            // listEmployees.RemoveAt(0);
            //Use RemoveAll() methid to removes all the items from a collection
            // that matches the specified condition.
            listEmployees.RemoveAll(x => x.Gender == "Female");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("RemoveRange Method");
            // Use RemoveRange() method to removes a range of elements from the list. 
            listEmployees.RemoveRange(0, 2);
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("Insert and InsertRange Method");
            //Use Insert() method to insert a single item at a specfic position 
            listEmployees.Insert(0, emp1);
            listEmployees.Insert(1, emp2);
            //Use InsertRange() method to insert another list of items at a specified position
            listEmployees.InsertRange(0, AnotherlistEmployees);
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("Clear Method");
            // Use Clear method to remove all the items from the list collection
            listEmployees.Clear();
            Console.WriteLine("Total Items in the List After Clear function = " + listEmployees.Count);
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
