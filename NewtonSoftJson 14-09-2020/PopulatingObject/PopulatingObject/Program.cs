using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PopulatingObject
{
    public class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> Roles { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Email = "bhaskar1998@gmail.com",
                Active = true,
                CreatedDate = new DateTime(2020, 10, 22),
                Roles = new List<string>
                                    {
                                        "User",
                                        "Admin"
                                    }
                                            };

            String json = JsonConvert.SerializeObject(account); 

            JsonConvert.PopulateObject(json, account);

            Console.WriteLine(account.Email);
           
            Console.WriteLine(account.Active);
           
            Console.WriteLine(string.Join(", ", account.Roles.ToArray()));
          
        }
    }
}
