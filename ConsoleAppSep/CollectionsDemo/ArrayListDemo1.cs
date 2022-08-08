using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppSep.CollectionsDemo
{
    internal class ArrayListDemo1
    {
        public static void Main()
        {
            //ArrayList list = new ArrayList();
            //ArrayList list = new ArrayList(3);
            //ArrayList list = new ArrayList() {15,12 };
            ArrayList list = new ArrayList(3) { 15, 12,10,25 };
            Console.WriteLine("Size:"+list.Count);//4
            Console.WriteLine("Capacity:"+list.Capacity);//6
            list.Add(20);
            Console.WriteLine("Updated Size:" + list.Count);//5
            Console.WriteLine("Updated Capacity:" + list.Capacity);//6

            list.Add(20);
            list.Add(20);
            list.Add(20);
            list.Add(20);
            list.Add(20);
            list.Add(20);
            Console.WriteLine("Updated Size:" + list.Count);//11
            Console.WriteLine("Updated Capacity:" + list.Capacity);//12
                                                                   //default,0=>4=>8=>16=>32....
                                                                   //initial cap 3, 3=>6=>12=>24....
            //list.

        }
    }
}
