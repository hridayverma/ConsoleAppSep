using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day7
{
    internal class Product //:IComparable<Product>
    {
        int _PId;
        string _PName;
        float _Price;
        string _Brand;//Data Fields
        public int PId { get => _PId; set => _PId = value; }
        public string PName { get => _PName; set => _PName = value; }
        public float Price { get => _Price; set => _Price = value; }
        public string Brand { get => _Brand; set => _Brand = value; }//Properties

        public override string ToString()//method to display data
        {
            return $"PID:{_PId }\tName:{_PName}\tBrand:{_Brand}\tPrice:{_Price}";
        }
       //Overriding CompareTo method of IComparable Interface for Product object Comparison
      /* public int CompareTo(Product other)
        {
            //return this._PId > other._PId ? 1 : -1;
            // return 0;
            //return this._PId.CompareTo(other._PId);//1,-1,0,ASC
            return other._PId.CompareTo(this._PId);//1,-1,0,DESC
        }*/
    }

    //IComparer interface we use to create custom comparators
    class SortByNameComparer : IComparer<Product>
    {
        //Overriding Compare method of IComparer Interface for Product object Comparison
        public int Compare(Product obj1, Product obj2)
        {
            return obj1.PName.CompareTo(obj2.PName);
        }
    }
    //Enum Type for sorting Field Type
    enum SortBy {
        ID,
        Name,
        Brand,
        Price,
        Quantity
    };

    //Custom Comparer Class
    class MyCustomComparer : IComparer<Product> {
        private bool _IsAsc; //for orderirng in Ascending or descending 
        private SortBy _SortBy;//for Sorting field
        public MyCustomComparer(SortBy _SortBy=SortBy.ID,bool _IsAsc=true)
        {
            this._SortBy = _SortBy;
            this._IsAsc = _IsAsc;
        }
        public int Compare(Product obj1, Product obj2)
        {
            int comResult = 0;
            switch (_SortBy)
            {
                case SortBy.ID:
                    if (_IsAsc)  {
                        comResult = obj1.PId.CompareTo(obj2.PId);
                    }
                    else
                        comResult = obj2.PId.CompareTo(obj1.PId);
                    break;
                case SortBy.Name:
                    if (_IsAsc)
                    {
                        comResult = obj1.PName.CompareTo(obj2.PName);
                    }
                    else
                        comResult = obj2.PName.CompareTo(obj1.PName);
                    break;
                case SortBy.Brand:
                    if (_IsAsc)
                    {
                        comResult = obj1.Brand.CompareTo(obj2.Brand);
                    }
                    else
                        comResult = obj2.Brand.CompareTo(obj1.Brand);
                    break;
                case SortBy.Price:
                    if (_IsAsc)
                    {
                        comResult = obj1.Price.CompareTo(obj2.Price);
                    }
                    else
                        comResult = obj2.Price.CompareTo(obj1.Price);
                    break;
                default:

                    break;
            }
            return comResult;
        }
    }






}
