using System;
using Day = System.DayOfWeek;

namespace SampleIndexers
{
    public class Employee
    {
        //Declare the properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        //Initialize the properties through constructor
        public Employee(int ID, string Name, string Job, int Salary, string Location,
                        string Department, string Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }
        public object this[string Name]
        {
           
            get
            {
                if (Name == "ID")
                    return ID;
                else if (Name == "Name")
                    return Name;
                else if (Name == "Job")
                    return Job;
                else if (Name == "Salary")
                    return Salary;
                else if (Name == "Location")
                    return Location;
                else if (Name == "Department")
                    return Department;
                else if (Name == "Gender")
                    return Gender;
                else
                    return null;
            }            
            set
            {
                if (Name == "ID")
                    ID = Convert.ToInt32(value);
                else if (Name == "Name")
                    Name = value.ToString();
                else if (Name == "Job")
                    Job = value.ToString();
                else if (Name == "Salary")
                    Salary = Convert.ToDouble(value);
                else if (Name == "Location")
                    Location = value.ToString();
                else if (Name == "Department")
                    Department = value.ToString();
                else if (Name == "Gender")
                    Gender = value.ToString();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Pranaya", "SSE", 10000, "Mumbai", "IT", "Male");
            Console.WriteLine("EID = " + emp["ID"]);
            Console.WriteLine("Name = " + emp["Name"]);
            Console.WriteLine("Job = " + emp["Job"]);
            Console.WriteLine("Salary = " + emp["Salary"]);
            Console.WriteLine("Location = " + emp["Location"]);
            Console.WriteLine("Department = " + emp["Department"]);
            Console.WriteLine("Gender = " + emp["Gender"]);
            emp["Name"] = "Kumar";
            emp["salary"] = 65000;
            emp["Location"] = "BBSR";
            Console.WriteLine("After changing index values:");
            Console.WriteLine("EID = " + emp["ID"]);
            Console.WriteLine("Name = " + emp["Name"]);
            Console.WriteLine("Job = " + emp["Job"]);
            Console.WriteLine("Salary = " + emp["Salary"]);
            Console.WriteLine("Location = " + emp["Location"]);
            Console.WriteLine("Department = " + emp["Department"]);
            Console.WriteLine("Gender = " + emp["Gender"]);            
        }
    }
}
