using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.MultiThreading
{
    internal class TaskUsingParallelForLoop    {
        public static void Main() {
            /*
            DateTime startTime = DateTime.Now;
            Console.WriteLine($"Parellel Execution started at:{startTime.ToLongTimeString()}");
            //Parallel.For()
            //for (int i = 0; i < 15; i++)
            var option = new ParallelOptions() { 
                    MaxDegreeOfParallelism=3
            };

            Parallel.For(0, 50, option, (i) =>{
                long result = AddNumbers();
                Console.WriteLine($"{i}:{result}");
            });           
            DateTime endTime = DateTime.Now;
            Console.WriteLine($"Execution ended at:{endTime.ToLongTimeString()}");
            TimeSpan span = endTime - startTime;
            Console.WriteLine($"Total time consumed in execution:{span.Milliseconds}");
            */
            //using Parallel ForEach
            string[] cities = {
                             "Noida","Delhi","Mumbai","Kolkata",
                             "Patna","Agra","Mohali","Chandigarh",
                             "Bhopal","Gwalior","Jabalpur","Lucknow"
                            };
            Console.WriteLine("Cities are:");
            Parallel.ForEach(cities, (city) => {
                Console.WriteLine(city);
            });
            List<int>list=Enumerable.Range(20, 30).ToList();//20-49
            Console.WriteLine("List Data using foreach");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List Data using Parallel foreach");
            Parallel.ForEach(list, (item)=>{
                 Console.WriteLine(item);
            });



        }
        static long AddNumbers()     {
            long sum = 0;
            for (int i = 0; i < 10000000; i++)  {
                sum += i;
            }
            return sum;
        }

    }
    
}
