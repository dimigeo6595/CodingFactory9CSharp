using System;
using System.Collections.Generic;
using System.Text;

namespace PointApp.Model
{
    internal class Point2D : Point
    {
        public int Y { get; set; }

        public Point2D() : //base() // Call the base class constructor
        {
            //Y = 0; // Initialize Y to 0
        }

        public Point2D(int x, int y) : base(x) // Call the base class constructor to initialize X
        {
            Y = y; // Initialize Y with the provided value
        }

        public override string ToString() => $"Point2D(X: {X}, Y: {Y})"; // Expression body for concise string representation

        public override void Move5() // Override the base class method to move both X and Y by 5
        {
            base.Move5(); // Call the base class method to move X by 5
            Y += 5; // Move Y by 5
        }

    }
}
