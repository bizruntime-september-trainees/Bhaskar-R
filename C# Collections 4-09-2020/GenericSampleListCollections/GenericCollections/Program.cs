using System;
using System.Collections.Generic;



    class Program1
    {
        static void Main(string[] args)
        {
            List<String> list = new List<string>();
            list.Add("Bhaskar");
            list.Add("Aman");
            list.Add("Rakhesh");
            list.Add("Utkarsh");
            foreach(String name in list)
            {
                Console.WriteLine("list elements are:" + name);
            }
            
        }
    }
    class Program2
    {
        public static void main(String[] args)
        {
            List<String> list1 = new List<string> { "Bhaskar", "Sandeep", "Suneel", "vishnu" };

            foreach (String names in list1)
            {
                Console.WriteLine(names);

            }
        }
    }
