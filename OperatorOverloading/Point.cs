using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }

        public Point()
        {

        }

        public Point(int x)
        {
            X = x;
        }

        public static Point operator +(Point p1, Point p2) // operator overloading for addition. always public static method with the operator keyword, and the operator symbol as part of the method name.
        {
            return new Point(p1.X + p2.X);
        }

        public static Point operator -(Point p1, Point p2) 
        {
            return new Point(p1.X - p2.X);
        }

        public int CompareTo(Point? other)
        {
            if (other is null) return 1; // Consider null as less than any instance
            return X.CompareTo(other.X);
        }

        public static bool operator ==(Point p1, Point p2) => p1 == p2;
        public static bool operator !=(Point p1, Point p2) => p1 != p2;
        public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;
        public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;
        public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;
        public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;
        




    }
}
