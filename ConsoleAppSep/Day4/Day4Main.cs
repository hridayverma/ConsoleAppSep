using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day4
{
    internal class Day4Main
    {
        static void Display() {

            Employee emp = new Employee();
            Console.WriteLine("Display");
            Employee.DisplayCount();
            emp = null;
            GC.Collect(0);
        }

        static void Main(string[] args)
        {
            /*
            OverloadTest overloadTest = new OverloadTest();

            int num1 = 50, num2 = 40;
            Console.WriteLine($"num1:{num1}\tnum2:{num2}");//50,40
            overloadTest.Swap(ref num1,ref num2);
            Console.WriteLine($"num1:{num1}\tnum2:{num2}");//40,50

            string s1 = "cdac", s2 = "india";
            Console.WriteLine($"s1:{s1}\ts2:{s2}");//cdac india
            overloadTest.Swap(ref s1, ref s2);
            Console.WriteLine($"s1:{s1}\ts2:{s2}");//india cdac

            StringBuilder sb1 = new StringBuilder("CDAC");
            StringBuilder sb2 = new StringBuilder("INDIA");
            Console.WriteLine($"sb1:{sb1}\tsb2:{sb2}");//CDAC INDIA
            overloadTest.Swap(sb1,sb2);
            Console.WriteLine($"sb1:{sb1}\tsb2:{sb2}");//INDIA CDAC
            */

            /*
            Employee employee = new Employee();
            //employee.DisplayEmployee();
            //Console.WriteLine(employee);
            //employee.DisplayCount();//1  //invalid
            Employee.DisplayCount();//1

            Employee employee2 = new Employee(2000,"Deepti",25500);
            // Console.WriteLine(employee2);
            // employee2.DisplayCount();//2,1
            Employee.DisplayCount();//2
            Employee employee3 = new Employee(3000, "Sumit");
            //Console.WriteLine(employee3);
            //employee3.DisplayCount();//3,1
            Employee.DisplayCount();//3
            Employee employee4 = new Employee(4000,_EmpSalary:50000);
            //Console.WriteLine(employee4);
            //employee4.DisplayCount();//4,1

            //employee.DisplayCount();//4,1
            Employee.DisplayCount();//4

            Display();//5
            Employee employee5 = new Employee(5000, _EmpSalary: 50000);
            Employee.DisplayCount();//5 or 6
            */
            //Operator overloading

            Point p1 = new Point();//20,30 default
            Console.WriteLine(p1);
            Point p2 = new Point(x: 50, y: 60);
            Console.WriteLine(p2);
            Point p3=p1+p2;//compile time polymorphism,early or static binding
            Console.WriteLine(p3);//70,90
            Point p4 = p1 - p2;
            Console.WriteLine(p4);//-30,-30

            //Console.
            //Math.
        }
    }
}
