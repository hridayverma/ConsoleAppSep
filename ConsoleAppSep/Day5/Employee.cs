using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day5
{
    internal class Employee
    {
        int _EmpCode;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Read only Expression Body Defn property ,6.0
        public string FullName => $"{FirstName} {LastName}";
        /*
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }*/
        //Read-Write  Expression Body Defn property ,7.0 or above
        public int EmpCode {
            get => _EmpCode;
            set => _EmpCode = value;
        }
    }
}
