using System.Text;

namespace MethodChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Checks if a int is even
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }


        // Calculate the Max of two ints
        public static int Max(int a, int b)
        {
            //return a > b ? a : b;
            return Math.Max(a, b);
        }

        // Calculates the area of a circle
        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Convert Celsius to Fahrenheit f = (c * 9/5) + 32
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Returns repeated string n times
        public static string RepeatString(string str, int n)
        {
            StringBuilder sb = new();       // C# 9.0 new()

            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}