using System;
using System.Threading;

namespace CS.Tima
{
    class Program
    {
        static int flag = 0;
        static void Main(string[] args)
        {
            var timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnElapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            Console.ReadLine();
        }

        private static void OnElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (flag == 0)
            {
                Console.WriteLine("Tik");
                flag = 1;
            }
            else
            {
                flag = 0;
                Console.WriteLine("Tok");
            }

        }
    }
}
