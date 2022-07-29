using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day5
{
    internal class Product
    {
        private int _ProductId;
        private string _Name;
        private string _Brand;
        //int _Quantity;
        private float _Price;
        //property defns
        public int ProductId
        {
            set {
                //some logic
                _ProductId = value;//write operation
            }
            get {
                //some logic
                return _ProductId;//read operation
            }
        }
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public string Brand
        {
            set { _Brand = value; }
            get { return _Brand; }
        }
        public float Price
        {
            set { _Price = value; }
            get { return _Price; }
        }
        public override string ToString()
        {
            return $"Product:{_ProductId},{_Name},{_Brand},{_Price}";
        }
    }
}
