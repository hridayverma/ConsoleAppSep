using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Inheritance
{
    class MyBase2
    {
        /*
        public void Display()
        {
            Console.WriteLine("Display from MyBase-2");
        }*/
        public virtual void Display()
        {
            Console.WriteLine("Display from MyBase-2");
        }

    }   
    class Derive3 : MyBase2
    {
        public void Show()
        {
            Console.WriteLine("Show from Derive-3");            
        }
        //Method Hiding
        /*public new void Display()
        {
            Console.WriteLine("Display from Derive-3");
        }*/

        //Method overriding
        public override void Display()
        {
            Console.WriteLine("Display from Derive-3");
        }
    }
    class Derive4 : MyBase2
    {
        public void Show()
        {
            Console.WriteLine("Show from Derive-4");
        }
       /* public new void Display()
        {
            Console.WriteLine("Display from Derive-4");
        }*/

        //Method overriding
        public override void Display()
        {
            Console.WriteLine("Display from Derive-4");
        }
    }
    //Factory Method Implementation 
    enum ChildType
    {
        Derive3,Derive4
    }
    class BaseFactory {
        public static MyBase2 GetObject(MyBase2 myBase) {

            return myBase;
        }
        public static MyBase2 GetObject(ChildType childType)
        {
            MyBase2 myBase2 = null;
            switch (childType)
            {
                case ChildType.Derive3:
                    myBase2 = new Derive3();
                    break;
                case ChildType.Derive4:
                    myBase2 = new Derive4();
                    break;
                default:
                    break;
            }
            return myBase2;
        }
    }

    internal class InheritDemo2
    {
       public static void Main()
        {
            /*
            MyBase2 myBase2 = new MyBase2();
            myBase2.Display();//disp from mybase-2
            Console.WriteLine("_____________________");
            Derive3 derive3 = new Derive3();
            derive3.Display();//disp from derive-3
            derive3.Show();//show from der-3
            Console.WriteLine("_____________________");
            myBase2 = new Derive3();
            myBase2.Display();//disp from derive-3
            //myBase2.Show();
            Console.WriteLine("_____________________");
            myBase2 = new Derive4();
            myBase2.Display();//disp from derive-4
            */
            //Using Factory Class
            MyBase2 myBase =BaseFactory.GetObject(ChildType.Derive3);
            myBase.Display();//der-3 display

            myBase = BaseFactory.GetObject(ChildType.Derive4);
            myBase.Display();//der-4 display


        }
    }
}
