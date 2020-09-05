using System;

namespace Constructors
{
    class Student
    {
        int Sno;
        String name;
        String address;

        public Student(int Sno,String name,String address)
        {
            this.Sno = Sno;
            this.name = name;
            this.address = address;
        }
        static void Main(string[] args)
        {
            Student s1 = new Student(1001, "Bhaskar", "Vizag");
            Student s2 = new Student(1002, "Aman", "UP");
            Student s3 = new Student(1003, "Sandeep", "Jharkhand");

            Console.WriteLine("Student1 details are:" + s1.Sno +" " + s1.name +" " + s1.address);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Student2 details are:" + s2.Sno +" " +  s2.name +" " + s2.address);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Student3 details are:" + s3.Sno +" " + s3.name +" "+ s3.address);
        }
    }
}
