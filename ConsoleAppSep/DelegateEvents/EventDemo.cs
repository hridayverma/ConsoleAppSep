using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.DelegateEvents
{   
    public delegate void MyEventHandler(int num);//delegate decln
    internal class Publisher
    {
        public event MyEventHandler MyEvent;//Event Decln        
        public void Notify(int num) {
            if (MyEvent != null)
                MyEvent.Invoke(num);//Firing of event/event invocation
            else
                Console.WriteLine("No subscriber associated with event");
        }
    }
    class Subscriber {
        //handler method for event
        public void Square(int num)
        {
            Console.WriteLine($"Sqaure of {num} is {num*num}");
        }
        public void Cube(int num)
        {
            Console.WriteLine($"Cube of {num} is {num * num*num}");
        }
        public static void Main()
        {
            Publisher eventDemo = new Publisher();           
            //Event instantiation/subscription
            //eventDemo.MyEvent += new MyEventHandler(eventDemo.Message);
            eventDemo.MyEvent +=new Subscriber().Square;
            eventDemo.MyEvent += new Subscriber().Cube;
            //Invocation logic
            int i = 0;
            int num;
            while (i <= 100) {
                Console.WriteLine("Input any number:");
                num = Int32.Parse(Console.ReadLine());
                //if (num > 0 && num < 10)
                {
                    eventDemo.Notify(num);//Notifying the publisher event
                }
               // else
                   // Console.WriteLine("Not a single digit number");
                i++;
            }
        }
    }
}
