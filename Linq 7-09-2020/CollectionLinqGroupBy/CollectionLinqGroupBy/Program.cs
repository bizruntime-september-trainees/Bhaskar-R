using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
    }
    class Programme2
    {
        static void Main(string[] args)
        {             
            List<Student> objStudent = new List<Student>()    
                    {
                    new Student() { Name = "Ak Tyagi", Gender = "Male",Location="Chennai" },
                    new Student() { Name = "Rohini", Gender = "Female", Location="Chennai" },
                    new Student() { Name = "Praveen", Gender = "Male",Location="Bangalore" },
                    new Student() { Name = "Sateesh", Gender = "Male", Location ="Vizag"},
                    new Student() { Name = "Madhav", Gender = "Male", Location="Nagpur"}
                    };

            var query = from std in objStudent
                        group std by std.Location;
               
            foreach (var sitem in query)
            {
                 
                Console.WriteLine(sitem.Key);
                Console.WriteLine();
                foreach (var stud in sitem)
                {
                   Console.WriteLine(stud.Name);
                }

                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }   
    
}