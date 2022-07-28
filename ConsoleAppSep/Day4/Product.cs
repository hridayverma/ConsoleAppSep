using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1-By making all data fields public  X
 2-Constructor   X
 3-Methods
 
 */
namespace ConsoleAppSep.Day4
{
    internal class Product
    {
        int _ProductId;
        string _Name;
        string _Brand;
        int _Quantity;
        float _Price;
        //setter
        public void SetProductId(int _ProductId) {
            this._ProductId = _ProductId;
        }

        //getter
        public int GetProductId()
        {
            return this._ProductId;
        }

        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.SetProductId(20);
            p1.GetProductId();//Properties
        }

    }
}
