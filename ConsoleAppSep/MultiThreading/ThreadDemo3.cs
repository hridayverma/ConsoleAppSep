using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppSep.MultiThreading
{
	class Test4	{  //Inter-thread Communication
		public void Display()		{

            lock (this) { 
			for (int i = 0; i <= 10; i++)			{
				Console.WriteLine($"Current Running Thread:{Thread.CurrentThread.Name}\t Value of I:{i}");
				Thread.Sleep(500);
			}
			this.RandomNum = new Random().Next(30, 70);//assigning a random value
			Monitor.Pulse(this);//notifies the thread that is in waiting state/queue
		  }
		}
		public int RandomNum { get; set; }		
	}
	internal class ThreadDemo3    {
		public static void Main() {
			Test4 test = new Test4();
			Thread t1 = new Thread(test.Display);
			t1.Name = "Th-1";
			t1.Start();

			Thread t2 = Thread.CurrentThread;
			t2.Name = "Main-TH";

            lock (test) { 
				Console.WriteLine("In Main:");
				Monitor.Wait(test);//wait for resource to be free
				for (int i = 0; i < test.RandomNum; i++)
				{
					Console.WriteLine($"Current Running Thread:{Thread.CurrentThread.Name}\t Value of I:{i}");
				}
			}
			Console.WriteLine("Main ended");
        }
    }
}
