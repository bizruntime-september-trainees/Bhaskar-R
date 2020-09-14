using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace QueryingJsonWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
           string json = @"{
                      'channel': {
                        'title': 'James Newton-King',
                        'link': 'http://james.newtonking.com',
                        'description': 'James Newton-King\'s blog.',
                        'item': [
                          {
                            'title': 'Json.NET 1.3 + New license + Now on CodePlex',
                            'description': 'Announcing the release of Json.NET 1.3, the MIT license and the source on CodePlex',
                            'link': 'http://james.newtonking.com/projects/json-net.aspx',
                            'categories': [
                              'Json.NET',
                              'CodePlex'
                            ]
                          },
                          {
                            'title': 'LINQ to JSON beta',
                            'description': 'Announcing LINQ to JSON',
                            'link': 'http://james.newtonking.com/projects/json-net.aspx',
                            'categories': [
                              'Json.NET',
                              'LINQ'
                            ]
                          }
                        ]
                      }
                    }";

            JObject rss = JObject.Parse(json);
            var postTitles = from p in rss["channel"]["item"]
                             select (string)p["title"];

            foreach (var item in postTitles)
            {
                Console.WriteLine(item);
            }
            string rssTitle = (string)rss["channel"]["title"];
            Console.WriteLine(rssTitle);

            string itemTitle = (string)rss["channel"]["item"][0]["title"];
            Console.WriteLine(itemTitle);

            JArray categories = (JArray)rss["channel"]["item"][0]["categories"];
            Console.WriteLine(categories);
        }
    }
}
