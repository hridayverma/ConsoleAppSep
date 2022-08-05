using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.DelegateEvents
{
    //public delegate void MyDel();
    public delegate int MyDel(int num);
    internal class DelegateDemo3
    {
        public static void Main()
        {
            /*
            MyDel myDel = delegate () {
                                      Console.WriteLine("this is anonymous block");
                                      };
            myDel();*/
            /*
            MyDel square = delegate (int n) { 
                          //some logic
                          return n * n;
            };
            Console.WriteLine(square(8));
            //Lambda Expression
            MyDel cube = (int num) => { return num * num * num; };
            Console.WriteLine(cube(10));*/

            //Using Built-in delegates
            //using Func Deleagte

            /*Func with Anonymous Method*/
            /*
            Func<int,int,int> GetRandom = delegate (int min,int max)
            {
                Random random = new Random();
                //return random.Next(50, 1000);
                return random.Next(min, max);
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GetRandom(50,2000));
            }*/
            /*Func with Lambda Expression*/
            // Func<int, int> Square = (int num) => { return num * num; };
            // Func<int, int> Square = (num) => { return num * num; };
            //Func<int, int> Square = num => { return num * num; };
            /*
            Func<int, int> Square = num => num * num;
            Console.WriteLine(Square(5));
            */
            /*Func with Normal Method*/
            /*
            Func<int, int> myCube =DelegateDemo3.Cube;
            Console.WriteLine(myCube(5));
            */
            //Using Action Delegate
            /*
            Action<int, int> myAction = (int num1,int num2) =>
            {
                int result = num1 + num2;
                Console.WriteLine($"Sum is:{result}");
            };
            myAction(30, 20);//calling
            myAction += new Calc1().Addition;
            myAction += Calc1.Subtract;
            myAction += Calc2.Division;
            myAction += new Calc2().Multiply;
            Console.WriteLine("___________________________");
            myAction(500, 10);//calling
            */
            //using Predicate delegate

            Predicate<string> isLower = (str) => str.Equals(str.ToLower());
            Console.WriteLine(isLower("astric"));//astric    astric     T
            Console.WriteLine(isLower("Astric123")); //Astric123   astric123  F
            Console.WriteLine(isLower("astric1234"));//astric1234  astric1234 T
        }
        static int Cube(int num) {
            return num * num * num;
        }

    }
}
