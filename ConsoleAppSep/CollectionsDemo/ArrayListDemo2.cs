using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppSep.CollectionsDemo
{
    internal class ArrayListDemo2
    {
        public static void Main()
        {
            ArrayList list = new ArrayList() { 5, 8, 4, 10, 20, 15, 30, 16 };
            Console.WriteLine("List data using normal loop:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("using foreach:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //using Enumerator
            IEnumerator itr= list.GetEnumerator();
            Console.WriteLine("Using Enumerator:");
            while(itr.MoveNext())
            {
                Console.WriteLine(itr.Current);
            }
            //list.Add()
           // int num =(int) list[2];//unboxing
        }
    }
}
