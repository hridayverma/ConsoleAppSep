using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day5
{
    internal class Student
    {
        private int _RollNo;
        private string _Name;
        private static string _CollegeName;
        private float _Mark;
        static Student() {
            _CollegeName = "C-DAC";
        }

        //static & read-only
        public static string CollegeName {
            get {return  _CollegeName; }
        }
        public int RollNo
        {
            set {
                  if(value>0)
                     _RollNo = value;
                  else
                     {
                       Console.WriteLine("Only +ve value allowed for rollno");
                     }
                }
            get { return _RollNo; }
        }
        //Read-write property
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }

        //auto implemented property
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }







        //write-only property
        public float SetMark
        {
            set { _Mark = value; }        
        }
        //read-only property
        public float GetMark
        {
            get { return _Mark; }
        }




    }
}
