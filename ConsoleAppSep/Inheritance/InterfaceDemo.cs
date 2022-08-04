using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppSep.Inheritance
{
   interface ICalc1 {
           //int x = 20;//not valid
           int Add(int x, int y);
           int Subtract(int x, int y);
    }
    interface ICalc2 {        
        int Multiply(int x, int y);
        int Divide(int x, int y);       
        int Subtract(int x, int y);
    }
    //Interface Implementation
    public  class Calculator :ICalc1, ICalc2  //Multiple Inheritance like
    {
        public int Add(int x, int y)
        {
            return x + y;
        } 
        /*
        public int Subtract(int x, int y)
        {
            Console.WriteLine("Implicit Subtract version");
            return x - y;
        }*/
        //Explicit Interface Implementation
        int ICalc1.Subtract(int x, int y)
        {
            Console.WriteLine("ICalc1 Explicit Subtract version");
            return x+(~y+1);
        }
        int ICalc2.Subtract(int x, int y)
        {
            Console.WriteLine("ICalc2 Explicit Subtract version");
            return (~y + 1)+x;
        }
        public int Divide(int x, int y)
        {
            return x * y;
        }
        public int Multiply(int x, int y)
        {
            return x / y;
        }

    }

    class MyCalc :Calculator {
       
    }
    internal class InterfaceDemo
    {
        public static void Main() {
            Calculator calc = new Calculator();
            // Console.WriteLine(calc.Add(40,20));
            //Console.WriteLine(calc.Subtract(50,10));
            //Console.WriteLine(calc.Multiply(10,10));
            
            //we can create reference of interface type,but we can't instantiate it
            ICalc1 icalc1 = calc;
            Console.WriteLine(icalc1.Subtract(50,30));
            //Console.WriteLine(icalc1.Multiply(10,20)); //invalid

            ICalc2 icalc2 = calc;
            //Console.WriteLine(icalc2.Multiply(20,10));
            Console.WriteLine(icalc2.Subtract(50, 20));//valid
        }
    }
}
