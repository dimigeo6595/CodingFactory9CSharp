using System;
using System.Collections.Generic;
using System.Text;

namespace PointApp.Model
{
    internal class Point3D : Point2D
    {
        public int Z { get; set; }

        public Point3D() : base()
        {

        } 

        public Point3D(int x, int y, int z) : base(x, y) // Call the base class constructor to initialize X and Y
        {
            Z = z;
        }

        public override string ToString() => $"Point3D(X: {X}, Y: {Y}, Z: {Z})";

        public override void Move5()
        {
            base.Move5(); // Move X and Y by 5 using the base class method
            Z += 5; // Move Z by 5
        }



    }
}
