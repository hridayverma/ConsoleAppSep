using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day6
{
    internal class ArrayDemo3
    {
        static void Main(string[] args)
        {
            /*
            //creating an array using Array class
             Array array = Array.CreateInstance(typeof(int), 5);
            //Array array = Array.CreateInstance(typeof(int), 5,4);
            //Array array = Array.CreateInstance(typeof(int), 5,4,4);
            Console.WriteLine(array.Length);//20
            Console.WriteLine(array.Rank);//2
            //array[0] = 30;//invalid
            //Console.WriteLine(array[0]);//invalid
            array.SetValue(30, 0);//boxing
            array.SetValue(40, 1);
            array.SetValue(50, 2);
            array.SetValue(60, 3);
            array.SetValue(70, 4);
            //array.SetValue(80, 5);
            Console.WriteLine("Data using for loop");
            for (int i = 0; i < array.Length; i++)
            {
                // int a =(int) array.GetValue(i);//unboxing
                Console.WriteLine(array.GetValue(i));
            }
            */
           int[]arr=  Enumerable.Range(1000, 50)
                      .Where(num => num % 2 != 0)
                      .ToArray();
            Console.WriteLine($"Array Values :{string.Join(",",arr)}");//




        }
    }
}
