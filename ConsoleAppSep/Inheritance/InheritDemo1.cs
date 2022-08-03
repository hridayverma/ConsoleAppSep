using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Inheritance {
    class MyBase    {
        public void Display()
        {
            Console.WriteLine("Display from MyBase");
        }
        /*
        protected void Display()        {
            Console.WriteLine("Display from MyBase");
        }*/
    }
    //Inheritance
    class Derive1 :MyBase{ 
        public void Show()        {
            Console.WriteLine("Show from Derive-1");
            //this.Display();
        }
    }
    class Derive2 : MyBase
    {
        public void Show()
        {
            Console.WriteLine("Show from Derive-2");
            //this.Display();
        }
    }
    internal class InheritDemo1
    {
       public static void Main()
        {
            MyBase myBase = new MyBase();
            Derive1 derive1 = new Derive1();
            Derive2 derive2 = new Derive2();

           // myBase.Display();
            Console.WriteLine("______________________");
            //myBase.Show();//invalid bcz its not a member of mybase 
           // derive1.Display();
            derive1.Show();
            Console.WriteLine("______________________");
           // derive2.Display();
            derive2.Show();



        }
    }
}
