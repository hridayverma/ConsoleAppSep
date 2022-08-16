using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppSep.LinqExamples
{
    internal class LinqDemo1
    {
        public static void Main() {

            /*
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //Deferred Execution
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Even Numbers:");
            foreach(var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            //Immediate Execution
            var count = (from num in numbers
                              where num % 2 == 0
                              select num).Count();
            Console.WriteLine("Total even numbers in list:"+count);
            */

            /*
            ArrayList list = new ArrayList() {

            10,"Mumbai","Delhi",30,40,"Patna",50,"Bhopal",60,70,
            new ConsoleAppSep.Day8.Employee(),
            new ConsoleAppSep.Day8.Employee()

            };
            //using OfType operator
            var numbers = from num in list.OfType<int>()
                          where num>50
                          select num;
            Console.WriteLine("List is:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }*/

            //using orderby

            IList<string> list = new List<string>() {
                "Yogeeta","Sonal Pandey","Sumit Kumar","Vishal Mittal",
                "Deepti Kumari","Sumit Singh","Vishal Singh"
            };

            /* var names = from name in list
                         orderby name descending
                         select name;*/

            var names = from name in list
                        where name.StartsWith("S")
                        orderby name descending
                        select name;
            Console.WriteLine("Names in sorted order:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


















        }
    }
}
