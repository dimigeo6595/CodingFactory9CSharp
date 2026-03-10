using System.Numerics;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// Calculates the factorial of a non-negative integer value.
        /// </summary>
        /// <remarks>The factorial of a number n is the product of all positive integers less than or
        /// equal to n. This method supports large values of n by using <see cref="BigInteger"/> to avoid
        /// overflow.</remarks>
        /// <param name="n">The non-negative integer for which to compute the factorial. Must be greater than or equal to 0.</param>
        /// <returns>A <see cref="BigInteger"/> representing the factorial of <paramref name="n"/>. Returns 1 if 
        /// <paramref
        /// name="n"/> is 0.</returns>
        public static BigInteger Factorial(int n)
        {
            BigInteger facto = 1;

            for (int i = 1; i <= n; i++)
            {
                facto *= i;
            }

            return facto;
        }

        public static BigInteger FactorialRecursive(int n)
        {
            //if (n == 0)
            //{
            //    return 1;
            //}
            //return n * FactorialRecursive(n - 1);
            return n == 0 ? 1 : n * FactorialRecursive(n - 1);
        }

        public static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }


        public static bool isPrimeBetter(int n)
        {
            if (n > 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }


        public static int Fibonacci(int n)
        {
            if (n < 0) throw new ArgumentException("Input must be a non-negative integer.");
            if (n == 0) return 0;
            if (n == 1) return 1;
            int a = 0;
            int b = 1;
            int fib = 1;


            for (int i = 1; i < n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }
            return fib;
        }


        public static int ArrayFibonacci(int n)
        {
            if (n < 0) throw new ArgumentException("Input must be a non-negative integer.");
            if (n == 0) return 0;
            if (n == 1) return 1;
            int[] fibs = new int[n + 1];
            fibs[0] = 0;
            fibs[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }
            return fibs[n];

        }

        public static int FibonacciRecursive(int n)
        {
            if (n < 0) throw new ArgumentException("Input must be a non-negative integer.");
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public static int FibonacciMemoized(int n, Dictionary<int, int> memo = null)
        {
            if (n < 0) throw new ArgumentException("Input must be a non-negative integer.");
            if (n == 0) return 0;
            if (n == 1) return 1;
            memo ??= new Dictionary<int, int>();
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }
            int result = FibonacciMemoized(n - 1, memo) + FibonacciMemoized(n - 2, memo);
            memo[n] = result;
            return result;
        }
    }
}
