namespace PocoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student alice = new Student();
            Student bob = new();    //C# 9.0 or later allows target-typed new expressions
            var julia = new Student();  // C# 3.0 or later allows var for implicit typing

            Teacher teacher = new (1, "Μάκης", "Καπέτης");   // Overloaded constructor with parameters
            Teacher teacher2 = new() { Id = 2, Firstname = "Ελένη", Lastname = "Παπαδοπούλου" }; // Object initializer syntax

            // Student student = new() { Id = 1, Firstname = "Αλίκη", Lastname = "Παπαδοπούλου" }; // Object initializer syntax




        }
    }
}
