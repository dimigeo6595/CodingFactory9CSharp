namespace LinqArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [5, 3, 8, 1, 9, 2];

            int min = arr.Min();
            int max = arr.Max();
            double average = arr.Average();
            int sum = arr.Sum();
            int count = arr.Count();
            int countGreaterThan3 = arr.Count(x => x > 3);

            var filtered = arr.Where(x => x > 3).ToArray(); // filter elements greater than 3
            var doubled = arr.Select(x => x * 2).ToArray(); // Map
            var sorted = arr.OrderBy(x => x).ToArray(); // Sort in ascending order
            var sortedDescending = arr.OrderByDescending(x => x).ToArray(); // Sort in descending order
            bool any = arr.Any(x => x > 8); // Check if any element is greater than 8
            bool allGreaterThan0 = arr.All(x => x > 0); // Check if all elements are greater than 0
            int first = arr.First(X => X > 4); // Get the first element greater than 4
            int last = arr.Last(X => X > 4); // Get the last element greater than 4




        }
    }
}
