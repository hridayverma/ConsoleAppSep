using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.CollectionsDemo
{
    class A { } //Base Type
    class B :A{ }//Derive Type
    class C : A { }//Derive Type
    class GenericTest2<T> where T:A  //base class constraint
    {
        public void Display(T t1)
        {
            Console.WriteLine(t1);
        }
    }
    internal class GenericDemo2
    {
        public static void Main()
        {
           // GenericTest2<string> obj1 = new GenericTest2<string>();
           // obj1.Display("astric");
            //GenericTest2<int> obj2 = new GenericTest2<int>();
            //obj2.Display(2022);
            GenericTest2<A> obj3 = new GenericTest2<A>();
            obj3.Display(new A());
            GenericTest2<C> obj4 = new GenericTest2<C>();
            obj3.Display(new C());
        }
    }
}
