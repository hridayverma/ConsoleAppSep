using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day4
{
    //
    internal static class StaticClassDemo
    {
       // int x;//not allowed
        static int y;
        /*
        public StaticClassDemo()        {

        }*///normal constr not allowed 
        static StaticClassDemo()        {

        }
      public  static void Show() { }
      //public  void Display() { } //not allowed
      

    }
}
