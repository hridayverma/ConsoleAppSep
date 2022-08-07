using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleAppSep.MultiThreading
{
    class Test3 {

        // public static void Display(object obj)
        public static void Display(object obj)
        {
            Console.WriteLine($"Current Running Thread:{Thread.CurrentThread.Name},\t Is Thread Pooled:{Thread.CurrentThread.IsThreadPoolThread}");
        }
        public static void ProcessWithThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                //Normal Thread Creation
                Thread th = new Thread(Test3.Display);
                th.Name = "Th-" + i;
                th.Start("Th-" + i);
                //th.Start();
            }
        }
        public static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                //Thread cration and adding the thread in ThreadPool
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test3.Display));
            }
        }
    }
    internal class ThreadDemo2
    {
        public static void Main(){
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Normal Thread Execution:");
            stopwatch.Start();
            Test3.ProcessWithThreadMethod();
            stopwatch.Stop();
            Console.WriteLine("Total time Taken:"+stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Total time Taken:" + stopwatch.ElapsedTicks);

            Console.WriteLine("ThreadPool Execution:");
            stopwatch.Start();
            Test3.ProcessWithThreadPoolMethod();
            stopwatch.Stop();
            Console.WriteLine("Total time Taken:" + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Total time Taken:" + stopwatch.ElapsedTicks);
        }
    }
}
