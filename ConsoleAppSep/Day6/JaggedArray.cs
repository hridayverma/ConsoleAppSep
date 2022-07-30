using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day6
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            //decln syntax for jagged array
            /*
            string[][] courses = new string[5][];            
            courses[0] = new string[5] { "C","C++","java","PHP","Python"};//
            courses[1] = new string[3] {  "java", "PHP", "Python" };//
            courses[2] = new string[6] { "C", "C++", "java", "PHP", "Python","C#" };//
            courses[3] = new string[4] { "C", "C++", "C#", "Python" };//
            courses[4] = new string[]  {  "PHP", "Python" };//
            */
            /*
            string[][] courses = new string[5][] {
                                                  new string[5]{ "C","C++","java","PHP","Python"},
                                                  new string[3]{ "Java", "PHP", "Python" },
                                                  new string[6]{ "C", "C++", "java", "PHP", "Python","C#" },
                                                  new string[4]{ "C", "C++", "C#", "Python" },
                                                  new string[2]{  "PHP", "Python" }
                                                 };*/
            var courses = new string[5][] {
                                                  new string[5]{ "C","C++","java","PHP","Python"},
                                                  new string[3]{ "Java", "PHP", "Python" },
                                                  new string[6]{ "C", "C++", "java", "PHP", "Python","C#" },
                                                  new string[4]{ "C", "C++", "C#", "Python" },
                                                  new string[2]{  "PHP", "Python" }
                                           };

            //Console.WriteLine(courses.Length);//5
            //Console.WriteLine(courses[2].Length);//6
            for (int i = 0; i < courses.Length; i++)
            {
                for (int j = 0; j < courses[i].Length; j++)
                {
                    Console.Write($"{courses[i][j]}  ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Courses using ForEach Loop:");
            foreach (var dataArr in courses)
            {
                //Console.WriteLine(item.Length);
                foreach (var item in dataArr)
                {
                    Console.Write(item+"  ");
                }
                Console.WriteLine();
            }





        }
    }
}
