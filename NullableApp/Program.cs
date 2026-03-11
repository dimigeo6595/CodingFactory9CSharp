namespace NullableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? s = Console.ReadLine(); // posible null value

            if (s != null) // null check
            {
                Console.WriteLine(s.Length);
            }


            Console.WriteLine(s?.Length); // null conditional operator
            Console.WriteLine(s!.Length); // null-forgiving operator, tells the compiler that s is not null, but can throw a NullReferenceException at runtime if s is actually null
            Console.WriteLine(s ?? "default"); // null-coalescing operator, returns the value of s if it is not null, otherwise returns "default"
        }
    }
}
