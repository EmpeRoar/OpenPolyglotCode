using System;
using System.Linq;

namespace CoderByte
{
    internal class Program
    {
        /**
                            = 1
                            = 2
                2,3,4       = 3
                  3,4,6     = 4
                    4,6,7   = 6
                      6,7,1 = 6
        **/

        private static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3, 4, 6, 7, 1 };

            int slidingWindow = arr[0];

            var startEl = arr.Min();
            var ir = new int[slidingWindow - startEl];
            var ip = 0;
            var ic = startEl;
            while (ic < slidingWindow)
            {
                ir[ip] = ic;
                ic++;
                ip++;
            }
            var rx = new int[arr.Length - 1];
            for (int i = 1; i < (arr.Length - 2); i++)
            {
                rx[i - 1] = GetMedian(arr, i, slidingWindow);
            }
            var final = ir.ToList();
            final.AddRange(rx.ToList());
            Console.WriteLine(string.Join(",", final.ToArray()));
        }

        private static int GetMedian(int[] arr, int currentIndex, int slidingWindow)
        {
            var windowArr = new int[slidingWindow];
            for (int i = 0; i < slidingWindow; i++)
            {
                windowArr[i] = arr[currentIndex + i];
            }
            Array.Sort(windowArr);
            var midVal = 0;
            if (slidingWindow % 2 == 0)
            {
                var m1 = windowArr[(slidingWindow / 2) - 1];
                var m2 = windowArr[(slidingWindow / 2)];
                midVal = (m1 + m2) / 2;
            }
            else
            {
                midVal = windowArr[(slidingWindow / 2)];
            }

            return midVal;
        }
    }
}