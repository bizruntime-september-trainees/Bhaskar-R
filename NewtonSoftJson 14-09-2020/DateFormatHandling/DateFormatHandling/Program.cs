using Newtonsoft.Json;
using System;

namespace DateFormatHandling1    
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime mayanEndOfTheWorld = new DateTime(2012, 12, 21);

            string jsonIsoDate = JsonConvert.SerializeObject(mayanEndOfTheWorld);

            Console.WriteLine(jsonIsoDate);
           

            string jsonMsDate = JsonConvert.SerializeObject(mayanEndOfTheWorld, new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            });

            Console.WriteLine(jsonMsDate);
            Console.WriteLine("Done!");
        }
    }
}
