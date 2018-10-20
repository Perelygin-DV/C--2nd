using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex131
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Point a = new Point(){ X = 1, Y = 2 };
        // Point b = new Point(){ X = 2, Y = 3 };
        // Point c = a.Sum(b);
        // Point c = b.Sum(a);
        public Point Sum(Point A)
        {
            return new Point() { X = this.X + A.X, Y = this.Y + A.Y };
        }

        // Point a = new Point(){ X = 1, Y = 2 };
        // Point b = new Point(){ X = 2, Y = 3 };
        // Point c = Point.Sum(a, b)
        //
        static public Point Sum(Point A, Point B)
        {


            return new Point() { X = B.X + A.X, Y = B.Y + A.Y };
        }
        // + - / * < > <= >= == !=  && || ^
        // + - !
        // ++ -- 
        // []
        // += -= /= *= 

        // Point a = new Point(){ X = 1, Y = 2 };
        // Point b = new Point(){ X = 2, Y = 3 };
        // Point res = a + b
        // a+=b;
        static public Point operator +(Point A, Point B)
        {
            return new Point() { X = B.X + A.X, Y = B.Y + A.Y };
        }
        // Point a = new Point(){ X = 1, Y = 2 };
        // Point b = new Point(){ X = 2, Y = 3 };
        // string c = a - b;
        static public string operator -(Point A, Point B) { return ""; }
    }
}
