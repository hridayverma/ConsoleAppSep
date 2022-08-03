using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Constructor and Destructor in Inheritance
namespace ConsoleAppSep.Inheritance
{
    class MyBase3
    {
        static MyBase3() {
            Console.WriteLine("Static from MyBase-3");
        }
        public MyBase3()
        {
            Console.WriteLine("Default from MyBase-3");
        }
        ~MyBase3()
        {
            Console.WriteLine("Destructor from MyBase-3");
        }
    }
    class Derive5:MyBase3
    {
        static Derive5()
        {
            Console.WriteLine("Static from Derive-5");
        }
        public Derive5():base()
        {
            Console.WriteLine("Default from Derive-5");
        }
        ~Derive5()
        {
            Console.WriteLine("Destructor from Derive-5");
        }
    }

    class Derive6 : Derive5
    {
        static Derive6()
        {
            Console.WriteLine("Static from Derive-6");
        }
        public Derive6():base()
        {
            //super()
            Console.WriteLine("Default from Derive-6");
        }
        ~Derive6()
        {
            Console.WriteLine("Destructor from Derive-6");
        }
    }
    internal class InheritDemo3
    {
        public static void Main() {
            Derive6 derive6 = new Derive6();  //  
            //some task

        }
    }
}
