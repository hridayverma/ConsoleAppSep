using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day7
{
    internal class ProductMain
    {
        public static void Main()
        {
            //Array of objects of type Product
            Product[] products = new Product[5] 
                                 {
                                 new Product(){ PId=101,PName="Soap",Brand="Dettol",Price=25},
                                 new Product(){ PId=140,PName="Biscuit",Brand="ParleG",Price=5},
                                 new Product(){ PId=130,PName="Toothpaste",Brand="Colgate",Price=75},
                                 new Product(){ PId=115,PName="Shampoo",Brand="Clinic+",Price=120},
                                 new Product(){ PId=124,PName="Pen",Brand="Cello",Price=10},
                                 };
            Console.WriteLine("Product List:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            /*
            Array.Sort(products);

            Console.WriteLine("Sorted Product List by ID:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }


            Array.Sort(products, new SortByNameComparer());
            Console.WriteLine("Sorted Product List by Name:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }*/

            //Array.Sort(products, new MyCustomComparer());//SortBy.ID  asc

            //Array.Sort(products, new MyCustomComparer(_IsAsc:false));//SortBy.ID  desc

            //Array.Sort(products, new MyCustomComparer(SortBy.Brand));//SortBy.Brand  asc
            Array.Sort(products, new MyCustomComparer(SortBy.Price,false));//SortBy.Price  desc
            Console.WriteLine("Sorted Product List:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }













        }
    }
}
