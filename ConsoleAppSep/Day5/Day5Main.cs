using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day5
{
    internal class Day5Main
    {
        static void Main(string[] args)
        {
            /*
            Product product = new Product();
            //writing data with property name
            product.ProductId = 1000;
            product.Name = "soap";
            product.Brand = "Santoor";
            product.Price = 35;//write operation,set accessor will be called
            //reading data with property name
            int pid = product.ProductId;
            Console.WriteLine($"PID:{pid}");
            Console.WriteLine($"Name:{product.Name}");
            Console.WriteLine($"Brand:{product.Brand}");
            Console.WriteLine($"Price:{product.Price}");//write operation,get accessor will be called
            Console.WriteLine("========================");
            Console.WriteLine(product);
            //object initializer block
            //.net 4.0 or above
            Product p2 = new Product() 
            {
                ProductId=101,
                Name="biscuit",
                Brand="ParleG",
                Price=5
            };
            Product p3 = new Product()
            {
                ProductId = 101,
                Name = "biscuit"               
            };
            Product p4 = new Product()
            {
                ProductId = 101,
                Name = "biscuit",
                Price = 5
            };

            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            */
            /*
            Student student = new Student();
            //Student.CollegeName = "ASTRIC";//invalid ,not allowed
            student.RollNo = 100;
            Console.WriteLine($"CollegeName:{Student.CollegeName}");//valid
            Console.WriteLine($"RollNo:{student.RollNo}");//valid
            student.Name = "Nayan";
            Console.WriteLine($"Name:{student.Name}");//valid
            student.SetMark = 85;//valid
            //Console.WriteLine($"Mark:{student.SetMark}");//invalid bcz it's write- only
            // student.GetMark = 75;//invalid ,bcz it's read-only
            Console.WriteLine($"Mark:{student.GetMark}");//valid

            student.State = "Bihar";
            student.City = "Patna";
            student.Address = "BSNL Compound,Raja Bajar,800014";
            Console.WriteLine($"Address:{student.Address},{student.City},{student.State}");
            */
            Employee employee = new Employee()
            {
                FirstName = "Narendra",
                LastName = "Patil",               
                EmpCode = 101
            };
            Console.WriteLine(employee.EmpCode);
            Console.WriteLine(employee.FullName);
            employee.DisplayEmployee();


            string str = "this is string text";

            Console.WriteLine(str.ConvertToUpperCase(str));
            


















        }
    }
}
