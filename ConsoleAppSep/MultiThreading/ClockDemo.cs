using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//use thread to update current time after each second  on console
namespace ConsoleAppSep.MultiThreading
{
    internal class ClockDemo
    {
        static void PrintTime()
        {
            //In
            Console.WriteLine($"Current Time:{DateTime.Now.ToLongTimeString()}");
        }
        public static void Main(){
            //PrintTime();
            Thread thread = new Thread(PrintTime);
            thread.Start();
        }
    }
}
