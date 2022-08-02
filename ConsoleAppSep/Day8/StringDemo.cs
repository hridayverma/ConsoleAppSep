using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleAppSep.Day8
{
    internal class StringDemo
    {
       public static void Main()
        {
            string str = "abcd123efgh456ijk789lmn11opq556rstu76vwxy6655z";
            //123,456,789,11,556,76,6655
            //For Regular Expression
            /*
               Regex
               Match
               MatchCollection
             */
            bool result= Regex.IsMatch(str,"\\d");
            Console.WriteLine(result);

            result = Regex.IsMatch(str, @"\d{2}");
            Console.WriteLine(result);
            Console.WriteLine(str);
            Console.WriteLine("______________________________");
            if (result) {
                /*
                //Match match=Regex.Match(str, @"\d{2}");
                Match match = Regex.Match(str, @"\d{2,}");
                Console.WriteLine(match.Success);
                Console.WriteLine(match.Name);
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Length);
                match=match.NextMatch();
                Console.WriteLine("______________________________");
                Console.WriteLine(match.Name);
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Length);
                */
                MatchCollection matches=Regex.Matches(str, @"[0-9]{2,}");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
                Console.WriteLine("______________________________");

                string[]data= Regex.Split(str, @"\d{2,}");
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("______________________________");
                string newdata = Regex.Replace(str, @"\d{2,}","@");
                Console.WriteLine(newdata);
                //Random class is used to generate randam values
                Random random = new Random();
                Console.WriteLine("_____________________________");
                for (int i = 0; i < 10; i++)
                {
                    int num = random.Next(100000, 999999);                              
                    Console.WriteLine(num);
                }
                



            }




        }
    }
}
