using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day8
{
    internal class DateTimeDemo
    {
       public static void Main()
        {
            //DateTime date = new DateTime(2022, 07, 25);
            DateTime date = DateTime.Now;
            Console.WriteLine("Cuurent date & time:"+date);
            /*
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.DayOfYear);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);
            Console.WriteLine(date.Second);
            Console.WriteLine(date.Millisecond);*/
            //DateTime newdate= date.AddMonths(5);
            DateTime newdate = date.AddMinutes(15);
            Console.WriteLine("Updated Date:"+newdate);
            Console.WriteLine("Date Formatting");
            Console.WriteLine("LongDate:"+date.ToLongDateString());
            Console.WriteLine("ShortDate:" + date.ToShortDateString());
            Console.WriteLine("LongTime:" + date.ToLongTimeString());
            Console.WriteLine("ShortDate:" + date.ToShortTimeString());
            //date.ToString()
            /*
             d->day               M->month
             y-->year             h,H->hour
             m->minute            s->second
             t->am/pm             K->timezone
             f->decimal fraction of second(millisecond)
             */
            Console.WriteLine(date.ToString("MM-dd-yy,H:m:s t"));
            Console.WriteLine(date.ToString("dd-MM-yy,H:m:ss tt"));//<10  05
            Console.WriteLine(date.ToString("dd-MM-yy,H:m:ss.fffffff tt"));//<10  05
            Console.WriteLine(date.ToString("MMMM,yyyy "));
            Console.WriteLine(date.ToString("dddd,dd-MM-yyyy"));
            //reading date vaule from console
            Console.WriteLine("Input date value:");
            DateTime mydate;
            if (DateTime.TryParse(Console.ReadLine(), out mydate))
            {
                Console.WriteLine("date is:"+mydate);
                Console.WriteLine(mydate.ToString("MMMM,dd-MM-yyyy"));
            }
            else
                Console.WriteLine("Input a valid date....");















        }
    }
}
