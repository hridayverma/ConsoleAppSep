using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppSep.MultiThreading
{
    class Test    {
        public void Display() {
            int i;
            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Current Thread:{Thread.CurrentThread.Name},value of i:{i}");
                Thread.Sleep(1000);
            }
        }
    }

    class Test2
    {
        //This is Power of MULTI threading in C Sharp;
        public void CheckCase(object str) {
            //lock is used here for thread synchroniztaion
            lock (this) { 
                string data = str as string;
                foreach (char ch in data) {
                    Console.Write(ch);
                    int uCode = (int)ch;
                    if (uCode >= 97 && uCode <= 122) {
                        uCode = uCode - 32;
                        Thread.Sleep(500);
                        Console.Write("\b");
                        Console.Write((char)uCode);
                    }                    
                    Thread.Sleep(200);
                }
                Console.WriteLine();
            }
        }          
    }

    internal class ThreadDemo1    {
        public static void Main()        {
            /*
            Console.WriteLine("Main started");
            Test test = new Test();
           // ThreadStart threadStart = new ThreadStart(test.Display);
           // Thread t1 = new Thread(threadStart);
            //Thread t1 = new Thread(new ThreadStart(new Test().Display));
            //Creating Thread-1
            Thread t1 = new Thread(test.Display);
            t1.Name = "Test-Th-1";
            t1.Start();
            Thread t2 = Thread.CurrentThread;
            t2.Name = "MainThread";
            //Creating Thread-2
            Thread t3 = new Thread(test.Display);
            t3.Name = "Test-Th-2";
            t3.Start();
            //Console.WriteLine("Current Thread Name:"+t2.Name);
            Console.WriteLine("main Thread State:" + t2.ThreadState);
            Console.WriteLine("T1 Thread State:" + t1.ThreadState);
            Console.WriteLine("T3 Thread State:" + t3.ThreadState);
            //ThreadState.
            Console.WriteLine("Main ended");
            */
            Test2 test = new Test2();
            Thread t1 = new Thread(new ParameterizedThreadStart(test.CheckCase));
            Thread t2 = new Thread(test.CheckCase);
            t1.Start("This is Power of MULTI threading in C Sharp");

            t2.Start("using SynChronus Nature of Threads");

        }

    }
}
