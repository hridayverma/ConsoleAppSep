using System;

using output= System.Console;

using sys=MyConsole;

namespace MyConsole
{
    class Console
    {
        public static void Print(string msg)
        {
            System.Console.WriteLine(msg);
            output.WriteLine(msg);
        }
    }
}

namespace ConsoleAppSep.DelegateEvents
{    
    internal class NameSpaceDemo    {
        public static void Main()        {
            MyConsole.Console.Print("using namespace");
            sys.Console.Print("using namespace");
            output.WriteLine("using console alias");
            Console.WriteLine("fsgfdsgdfgs");
        }
    }
}
