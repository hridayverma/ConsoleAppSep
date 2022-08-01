using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day7
{
    internal class StringDemo1
    {
        public static void Main()
        {
            /*
            string str1 = string.Empty;
            string str2 = "";
            string str3 = null;
            Console.WriteLine(str1.Length);//0
            Console.WriteLine(str2.Length);///0
            Console.WriteLine(str3.Length);//invalid,exception
            */
            string s1 = "cdac";
            string s2 = "cdac";
            StringBuilder sb1 = new StringBuilder("cdac");
            StringBuilder sb2 = new StringBuilder("cdac");

            Console.WriteLine(s1==s2);//True
            Console.WriteLine(sb1==sb2);//false
            Console.WriteLine(s1.Equals(s2));//True
            Console.WriteLine(sb1.Equals(sb2));//True

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(sb1.GetHashCode());
            Console.WriteLine(sb2.GetHashCode());



            /*
            Product p1 = new Product();
            //Product p2 = new Product();
            Product p2 = p1;
            Console.WriteLine(p1.Equals(p2));//
            */

            string s3=  string.Format("value of x:{0}\tvalue of y:{1}", 20, 30);
            Console.WriteLine(s3);





        }
    }
}
