using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//use of base keyword

namespace ConsoleAppSep.Inheritance
{
    class Employee {

        protected int _EmpCode;
        public Employee(int _EmpCode)
        {
            this._EmpCode = _EmpCode;
            Console.WriteLine("Employee constr called");
        }
        public void Show() {
            Console.Write("Code:"+_EmpCode);
        }
    }
    class Manager : Employee
    {
        protected int _Did;
        public Manager(int _Did,int _EmpCode):base(_EmpCode)
        {
            this._Did = _Did;
            Console.WriteLine("Manager constr called");
            //Employee employee = new Employee(3000);
            base.Show();//101
            this.Show();//10
        }
        public void Show()
        {
            Console.Write("DID"+_Did);
        }
    }

    class Superviser : Manager
    {
        string _Name;
        public Superviser(string _Name,int _Did,int _EmpCode):base(_Did,_EmpCode)
        {
            this._Name = _Name;
            Console.WriteLine("Superviser constr called");
        }
        public override string ToString()
        {
            return $"{_EmpCode}\t{_Did}\t{_Name}";
        }
    } 

    internal class InheritDemo4
    {
        public static void Main() {
            Superviser sb = new Superviser(_EmpCode: 101, _Did: 10, _Name : "Swapnil");

            Console.WriteLine(sb);
        }
    }
}
