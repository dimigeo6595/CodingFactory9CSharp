using System;
using System.Collections.Generic;
using System.Text;

namespace PointApp.Model
{
    internal class Point
    {
        public int X { get; set; }
        

        public Point() 
        { 

        }

        public Point(int x) 
        {
            X = x; 
        }

        public override string ToString() => $"Point(X: {X})";

        public virtual void Move5() // virtual method that can be overridden in derived classes
        {
            X += 5;
        }


    }
}
