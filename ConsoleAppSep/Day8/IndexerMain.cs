using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day8
{
    class Employee    {
        private long[] _ContactNo;
        public Employee()  {
            _ContactNo = new long[5];
        }
        //Indexer
        public long this[int index]        {
            get { return _ContactNo[index]; }
            set { _ContactNo[index] = value; }
        }
        /*
        public long this[int row,int col]        {
            get { return _ContactNo[index]; }
            set { _ContactNo[index] = value; }
        }*/
        //ReadOnly property to get ContactNo length
        public long ContactNoLength        {
            get => _ContactNo.Length;
        }
    }
    internal class IndexerMain
    {
       public static void Main()
        {
            Employee employee = new Employee();
            employee[0] = 9876543234;//write operation,set accessor
            long contactNo = employee[0];//read operation,get accessor
            Console.WriteLine($"{contactNo}");
            //string str = "gdshgdsh";
            //Console.WriteLine(str[3]);
            for (int i = 0; i < employee.ContactNoLength; i++)
            {
                Console.WriteLine($"Input contact no {i+1}:");
                employee[i] = Int64.Parse(Console.ReadLine());
            }
            Console.WriteLine("Employee Contact details are:");
            for (int i = 0; i < employee.ContactNoLength; i++)
            {
                Console.WriteLine(employee[i]);                
            }
        }
    }
}
