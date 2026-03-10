namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(a, b);
            Console.WriteLine($"a: {a}, b: {b}");

            SwapRef(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");

        }

        /// <summary>
        /// Attempts to swap the values of two integers passed as parameters. The original values of the arguments are
        /// not modified outside the method.
        /// </summary>
        /// <remarks>Because the parameters are passed by value, this method does not modify the original
        /// variables provided by the caller. To swap values outside the method, use parameters passed by reference
        /// (with the 'ref' keyword).</remarks>
        /// <param name="a">The first integer value to attempt to swap.</param>
        /// <param name="b">The second integer value to attempt to swap.</param>
        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        /// <summary>
        /// The Original variables are modified
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Swaps the values of two integers passed as parameters and returns the swapped values as a tuple. 
        /// The original parameters are passed by reference, allowing the caller to see the changes outside the method. 
        /// The method returns a tuple containing the swapped values, which can be used for further processing if needed.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static (int, int) SwapWithTuple(ref int a, ref int b)
        {
            return (b, a);
        }

    }
}
