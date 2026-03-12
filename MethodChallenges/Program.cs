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


        // Creates a random pin of 4 digits. Random .next(1000, 9999) generates a random number between 1000 and 9999
        public static int GeneratePin()
        {
            Random rand = new();
            return rand.Next(1000, 10000); // 10000 is exclusive, so it generates a number between 1000 and 9999            
        }

        //Filtering even numbers from an array
        public static int[] FilterEven(int[] arr)
        {
            //return arr.Where(num => num % 2 == 0).ToArray();
            return [.. arr.Where(num => num % 2 == 0)]; // Spread > C# 12.0
        }

        // Bubble sort an array of integers
        public static int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);  // tuple swap
                    }
                }
            }
            return arr;
        }


        //Binary search for a target in a sorted array. Returns the index of the target or -1 if not found
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid; // Target found
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }
            return -1; // Target not found
        }



        //Check if two strings are anagrams (contain the same characters in a different order)
        public static bool IsAnagrams(string str1, string str2)
        {
            // Remove whitespace and convert to lowercase
            char[] chars1 = str1.ToLower().ToArray();
            char[] chars2 = str2.ToLower().ToArray();

            // Sort the characters of both strings and compare
            return new string(str1.OrderBy(c => c).ToArray()) == new string(str2.OrderBy(c => c).ToArray());
        }

        // Calculate the commons elements between two arrays of integers
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            //return arr1.Intersect(arr2).ToArray();
            //return [.. arr1.Intersect(arr2)]; // Spread > C# 12.0

            HashSet<int> set1 = [.. arr1];
            HashSet<int> set2 = [.. arr2];

            set1.IntersectWith(set2);
            return [.. set1];
        }
    }
}