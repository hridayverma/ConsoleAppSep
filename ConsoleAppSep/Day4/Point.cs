using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Day4
{
    internal class Point
    {
        int x;
        int y;
        public Point(int x=20,int y=30){
            this.x = x;
            this.y = y;
        }
        public override string ToString() {
            return $"Point({x},{y})";
        }
        //overloading of + operator
        public static Point operator+(Point p1,Point p2) {
            int x = p1.x + p2.x;
            int y = p1.y + p2.y;
            return new Point(x, y);
        }
        //overloading of - operator
        public static Point operator -(Point p1, Point p2) {
            int x = p1.x - p2.x;
            int y = p1.y - p2.y;
            return new Point(x, y);
        }
    }
}
