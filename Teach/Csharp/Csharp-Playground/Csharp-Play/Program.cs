using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Play
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class Program
    {
        private static async Task Main(string[] args)
        {
            var json = "{\"Name\":\"JBX\"}";
            dynamic x = JsonConvert.DeserializeObject(json);
            // var x = JsonConvert.DeserializeObject<Person>(json);
            try
            {
                Console.WriteLine(x.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

    }
}