using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 default
 parametric 
 static
 */

namespace ConsoleAppSep.Day4
{
    internal class Employee
    {
        int _EmpCode;  //non-static ,instance memmbers,
                       //object dependent,object specific copy is created in memory
        string _EmpName;//non-static ,instance memmbers,object dependent
        float _EmpSalary;//non-static ,instance memmbers,object dependent
        static int _Count;//static ,class memmber,object independent,single copy for all objects
        //public Employee()
        //{
        //    Console.WriteLine("Default Constr called");
        //    _EmpCode = 1000;
        //    _EmpName = "Admin";
        //    _EmpSalary = 250000;
        //}
        public Employee(int _EmpCode=1000,string _EmpName="Admin",float _EmpSalary=250000)
        {
            Console.WriteLine("Parametric Constr called");
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            _Count++;
        }
        //static constructor,used to initialize static data fields
        static Employee() {
            _Count = 0;
            Console.WriteLine("Static constr called");
        }       
        internal void DisplayEmployee() {
            Console.WriteLine($"Employee:{_EmpCode},\t{_EmpName},\t{_EmpSalary}");
        }

        internal static void DisplayCount() {
            Console.WriteLine($"Object available in memory:{_Count}");
        }
        public override string ToString()
        {
            return $"Employee:{_EmpCode},\t{_EmpName},\t{_EmpSalary}";
        }
        //Destructor
        ~Employee() {
            _Count--;
            Console.WriteLine("destr is used to free any resource occupied by current object");
        }
    }
}
