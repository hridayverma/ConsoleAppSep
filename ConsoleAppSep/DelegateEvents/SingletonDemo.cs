using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.DelegateEvents
{

    class Singleton
    {
        private static Singleton singleton;
        private Singleton()
        {
            Console.WriteLine("Object created");
        }
        public static Singleton GetObject()        {
            if (singleton == null)

                singleton = new Singleton();

            return singleton;
        }
       public void Display()
        {
            Console.WriteLine("Display from singleton");
        }
    }

    internal class SingletonDemo
    {
       public static void Main()
        {
            // Singleton singleton = new Singleton();//invalid
            Singleton singleton=Singleton.GetObject();
            singleton.Display();
            singleton = Singleton.GetObject();
            singleton.Display();
        }
    }
}
