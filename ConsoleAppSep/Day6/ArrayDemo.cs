using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day6
{
    internal class ArrayDemo
    {
        static void Main(string[] args)
        {
            // int[] score;//Array decln

            // score = new int[5];////Array initialization

            //int[,] score = new int[5,6];
            /*
            int[,,] score = new int[4,5, 6];

            Console.WriteLine($"ArrayLength:{score.Length}");//90
            Console.WriteLine($"Array Rank:{score.Rank}");//Rank returns Array Diemension
            */
            /*
             Form Rank 1    dimension index will be  0
             Form Rank 2    dimension index will be  0 , 1
             Form Rank 3    dimension index will be  0 ,1,2
             */
            /*
            Console.WriteLine($"dimension-1 Array Length :{score.GetLength(0)}");//4
            Console.WriteLine($"dimension-2 Array Length :{score.GetLength(1)}");//5
            Console.WriteLine($"dimension-3 Array Length :{score.GetLength(2)}");//6
            Console.WriteLine($"dimension-1 upperbound:{score.GetUpperBound(0)}");//
            Console.WriteLine($"dimension-2 upperbound:{score.GetUpperBound(1)}");//
            Console.WriteLine($"dimension-3 upperbound:{score.GetUpperBound(2)}");//
            */
            /*
            //int[] score = new int[5];//way-1 initilized with default value
            //int[] score = new int[5] { 1,2,3,4,5};//Way-2
            //int[] score = new int[] { 1, 2, 3, 4, 5,6,7 };//way-3
            int[] score = { 1, 2, 3, 4, 5, 6, 7 };//way-4

            Console.WriteLine("Array Data:");
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write($"{score[i]} ");//
            }
            Console.WriteLine();
            //Assigning user input value
            Console.WriteLine("Input array values:");
            for (int i = 0; i < score.GetLength(0); i++)
            {
                Console.WriteLine($"Enter array element {i+1} value:");
                score[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Updated Array Data:");
            for (int i = 0; i <= score.GetUpperBound(0); i++)
            {
                Console.Write($"{score[i]} ");//
            }
            */

            var states = new string[5] {"UP","MP","Punjab","Maharastra","Bihar" };
            Console.WriteLine("States are:");
            foreach (var state in states)
            {
                Console.WriteLine(state);
            }
            Array.Sort(states);
           // Array.Reverse(states);
            Console.WriteLine("Sorted States are:");
            foreach (var state in states)
            {
                Console.WriteLine(state);
            }
            Console.WriteLine("====================");
            Console.WriteLine(states.Min());
            Console.WriteLine(states.Max());







        }
    }
}
