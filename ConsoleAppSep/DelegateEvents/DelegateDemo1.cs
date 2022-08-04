using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.DelegateEvents
{
    //delegate decln
    public delegate void MyDelegate(int x, int y);
    class Calc1 {
        public void Addition(int a, int b) {
            Console.WriteLine($"Sum is:{a+b}");
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference is:{a - b}");
        }
    }
    class Calc2
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication is:{a * b}");
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine($"Division is:{a / b}");
        }
    }
    internal class DelegateDemo1
    {
        public static void Main()
        {
            Calc1 calc1 = new Calc1();
           
            MyDelegate myDelegate = new MyDelegate(calc1.Addition);//Instatitaion of delegate
            myDelegate += Calc1.Subtract;//assigning subtract method reference

            //Invocation
            myDelegate(30, 20);//calling

            myDelegate += new Calc2().Multiply;
            myDelegate += Calc2.Division;

            myDelegate(50, 10);//calling

        }
    }
}
