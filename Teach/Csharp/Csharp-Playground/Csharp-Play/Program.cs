using System;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Play
{
    public class Program
    {
        static public int Sum(int x, int y) => x + y;

        static void Play(string[] args)
        {
            if (args.Count() != 0)
            {
                var t = Sum(Int32.Parse(args[0]), Int32.Parse(args[1]));
                Console.WriteLine(t);
            }
            else
            {
                var x1 = Console.ReadLine();
                var newx1 = x1.Split(" ");
                foreach(var n in newx1)
                {
                    Console.WriteLine($"{n}");
                }
                Console.WriteLine(Sum(Int32.Parse(newx1[0]), Int32.Parse(newx1[1])));
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Hello C#!");

        }

        static async Task Main(string[] args)
        {
            Play(args);


            var keyin = Console.ReadLine();

            Console.WriteLine(keyin);

            while(keyin != "exit")
            {
                Play(args);
            }

            Console.ReadLine();


        }

    }
}
