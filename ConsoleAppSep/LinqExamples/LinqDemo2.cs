using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.LinqExamples
{
    class State    {
        public int Id { get; set; }
        public string StateName { get; set; }
    }
    class City    {
        public int Id { get; set; }
        public int CityStateId { get; set; }
        public string CityName { get; set; }
    }
    internal class LinqDemo2
    {
        public static void Main()
        {
            //Create states list 
            IList<State> states = new List<State>() { 
                new State(){ Id=1,StateName="Bihar"},
                new State(){ Id=2,StateName="MP"},
                new State(){ Id=3,StateName="UP"},
                new State(){ Id=4,StateName="Maharastra"}
            };
            //Create cities list
            IList<City> cities = new List<City>() {
                new City(){ Id=1,CityStateId=1,CityName="Patna"},
                new City(){ Id=4,CityStateId=1,CityName="Gaya"},
                new City(){ Id=2,CityStateId=2,CityName="Bhopal"},
                new City(){ Id=6,CityStateId=2,CityName="Jabalpur"},
                new City(){ Id=10,CityStateId=2,CityName="Indore"},
                new City(){ Id=3,CityStateId=3,CityName="Lucknow"},
                new City(){ Id=5,CityStateId=3,CityName="Noida"},
                new City(){ Id=7,CityStateId=4,CityName="Mumbai"},
                new City(){ Id=15,CityStateId=4,CityName="Pune"}
            };

            /* var citylist =from city in cities
                           select city;*/

            /*
            var citylist = from city in cities
                           where city.CityStateId==3
                           select city;
            */
            /*
            //var citylist = cities.Where(city=>city.CityStateId==3).ToList();
            var citylist = from city in cities
                           //where city.CityStateId == 3
                           orderby city.Id ascending
                           select new {city.Id,city.CityName };
                                  //anonymous type
            Console.WriteLine("City List:");
            foreach (var c in citylist)
            {
                //Console.WriteLine($"{c.Id}\t{c.CityStateId}\t{c.CityName}");
                Console.WriteLine($"{c.Id}\t{c.CityName}");
            }*/
            /*
            //using group by clause
            var stategroup = from city in cities
                             group city by city.CityStateId;

            foreach (var state in stategroup)
            {
                Console.WriteLine("For state key:"+state.Key);

                foreach (var city in state)
                {
                    Console.WriteLine($"{city.Id}\t{city.CityStateId}\t{city.CityName}");
                }

            }*/
            /*
            //Join operation
            var citylist = from state in states
                           join city in cities
                           on state.Id equals city.CityStateId
                           //where city.CityStateId==2
                           //select new {city.Id,city.CityName,state.StateName };
                           select new { city.Id, city.CityName,SID=state.Id, state.StateName };
                                                               //alias

            Console.WriteLine("City List");
            foreach (var city in citylist)
            {
                // Console.WriteLine($"{city.Id}\t{city.StateName}\t\t{city.CityName}");
                Console.WriteLine($"{city.Id}\t{city.SID}\t{city.StateName}\t\t{city.CityName}");
            }
            */
            //using partison operator methods
            //var citylist = cities.Skip(5);
            //var citylist = cities.Take(5);
            //var citylist = cities.TakeWhile(city=>city.Id<5);
            var citylist = cities.SkipWhile(city => city.Id < 5);
            Console.WriteLine("City List:");
            foreach (var item in citylist)
            {
                Console.WriteLine($"{item.Id}\t{item.CityName}");
            }











        }
    }
}
