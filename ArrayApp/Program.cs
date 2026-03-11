using System.Security.Cryptography.X509Certificates;

namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = new int[5]; // array of 5 integers
            arr[0] = 1;

            int[] arr2 = new int[] { 1, 2, 3, 4, 5 }; // array of 5 integers with initializer

            int[] arr3 = { 1, 2, 3, 4, 5 }; // array of 5 integers with initializer (shorter syntax)

            int[] numbers = [1, 2, 3, 4, 5]; // array of 5 integers with initializer (C# 14.0 syntax) 

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //2D array
            int[,] matrix =
            {
                { 1, 2, 3 },
                {4, 5, 6},
                {7, 8, 9 }
            };


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[][] jaggedArray = new int[3][];
            int[][] jagged = [[1, 2], [3, 4], [5, 6]];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j] + " ");
                }
            }

            //Array methods
            int[] arr4 = { 5, 2, 9, 1, 5 };
            Array.Sort(arr4); // Shorts the array in ascending order
            Array.Reverse(arr4); // Reverses the order of the elements in the array
            int index = Array.IndexOf(arr4, 3); // Returns the index of the first occurrence of the value 3 in the array

            int[] copy = new int[arr4.Length];
            Array.Copy(arr4, copy, arr4.Length); // Copies the elements of arr4 to copy 
        }

        public static int GetMinPosition(int[] arr)
        {
            int minPos = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minPos])
                {
                    minPos = i;
                }
            }
            return minPos;

        }

        public static bool IsSymmetric(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
