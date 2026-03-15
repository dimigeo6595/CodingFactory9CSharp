using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new(15); //new Point(15);
            Point p2 = new Point2D(15, 18);
            Point p3 = new Point3D(15, 18, 20);

            DoMove5(p1);
            DoMove5(p2);
            DoMove5(p3);
        }

        public static void DoMove5(Point p)
        {
            p.Move5(); // Polymorphic call to the appropriate Move5 method based on the actual type of the object (Point, Point2D, or Point3D).
                       // Late binding (dynamic dispatch) is used to determine which Move5 method to invoke at runtime.
        }

        public static void DoPrint(Point p)
        {
            Console.WriteLine(p.ToString()); 
        }

    }
}
