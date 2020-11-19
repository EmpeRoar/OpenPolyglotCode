using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Play
{
    public class Program
    {
        private static async Task Main(string[] args)
        {

            IEnumerable<string> strList = null;

            strList.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x}");
            });
            Console.ReadLine();
        }
    }
}