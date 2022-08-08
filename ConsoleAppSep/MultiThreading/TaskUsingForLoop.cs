using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.MultiThreading
{
    internal class TaskUsingForLoop
    {
        public static void Main()
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine($"Execution started at:{startTime.ToLongTimeString()}");
            for (int i = 0; i < 15; i++)
            {
                long result = AddNumbers();
                Console.WriteLine($"{i}:{result}");
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine($"Execution ended at:{endTime.ToLongTimeString()}");
            TimeSpan span= endTime - startTime;
            Console.WriteLine($"Total time consumed in execution:{span.Milliseconds}");
        }

        static long AddNumbers() {
            long sum = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
