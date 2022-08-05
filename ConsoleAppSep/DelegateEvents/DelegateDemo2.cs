using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.DelegateEvents
{
    //delegate decln
    public delegate int MyDelegate2(int x, int y);
    class Calc3
    {
        public int Addition(int a, int b)
        {           
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            //Console.WriteLine($"Difference is:{a - b}");
            return a - b;
        }
    }
    class Calc4
    {
        public int Multiply(int a, int b)
        {
            //Console.WriteLine($"Multiplication is:{a * b}");
            return a * b;
        }
        public static int Division(int a, int b)
        {
            //Console.WriteLine($"Division is:{a / b}");
            return a / b;
        }
    }

    internal class DelegateDemo2
    {
       public static void Main()
        {
            Calc3 calc3 = new Calc3();
            Calc4 calc4 = new Calc4();

            MyDelegate2 myDelegate2 = new MyDelegate2(calc3.Addition);

            int result= myDelegate2.Invoke(30,20);
            Console.WriteLine($"Result:{result}");//50
            myDelegate2 += Calc3.Subtract;
            myDelegate2 += calc4.Multiply;
            myDelegate2 += Calc4.Division;
            result = myDelegate2.Invoke(500, 50);
            Console.WriteLine($"Result:{result}");//10
            myDelegate2-= Calc4.Division;
            result = myDelegate2.Invoke(500, 50);
            Console.WriteLine($"Result:{result}");//



        }
    }
}
