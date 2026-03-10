namespace ExpressionBodyMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        //Expression-bodied method for a simple addition operation
        public static int Add(int a, int b) => a + b;

        public static int Factorial(int n) => n == 0 ? 1 : n * Factorial(n - 1);

        public static bool IsPrime(int n) => n >= 2 && Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i != 0);
    }
}
