using CollectionsSort;

namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];


            var allNumbers = from num in numbers select num;    // Returns IEnumerable<int> with all numbers
            foreach (var num in allNumbers)
            {
                Console.WriteLine(num);
            }


            // Filtering with Where
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;    // Returns IEnumerable<int> with even numbers

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }


            //Terminal operations
            List<int> evenNumbers2 = (from num in numbers
                                      where num % 2 == 0
                                      select num).ToList();

            var oddNumbers = (from num in numbers
                              where num % 2 != 0
                              select num).ToArray();
        }

        //Filtering with Where
        public static int[] FilterEvenToArray(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 == 0
            //        select num).ToArray();

            return [ ..from num in arr
                    where num % 2 == 0
                    select num ];       //Auto return type 

        }

        public static List<int> FilterEvenToList(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 == 0
            //        select num).ToList();

            return [ ..from num in arr
                    where num % 2 == 0
                    select num ];       //Auto return type 

        }



        //Mapping with Select
        public static int[] MapOddToDouble(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 != 0
            //        select num * 2).ToArray();

            return [ ..from num in arr
                    where num % 2 != 0
                    select num * 2 ];       //Auto return type with spreading operator

        }

        public static List<int> MapOddToDoubleToList(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 != 0
            //        select num * 2).ToList();

            return [ ..from num in arr
                    where num % 2 != 0
                    select num * 2 ];       //Auto return type with spreading operator

        }



        // Pagination with Skip and Take
        public static int[] GetPage(int[] arr, int pageNumber, int pageSize)
        {
            return (from num in arr select num).Skip((pageSize - 1) * pageSize).Take(pageSize).ToArray();

        }

        public static Student[] GetStudentPage(Student[] students, int page, int pageSize)
        {
            return (from s in students select s)
                .OrderBy(s => s.Lastname)
                .ThenBy(s => s.Firstname)
                .Skip((page - 1) * pageSize)
                .ToArray();
        }


        // Reduce with Aggregate
        public static int sumAll(int[] arr)
        {
            //return (from num in arr select num).Sum(); // Query syntax with Sum
            //return arr.Sum(); // Method syntax with Sum
            //return arr.Count(); // Method syntax with Count
            //return arr.Max(); // Method syntax with Max
            //return arr.Min(); // Method syntax with Min
            return arr.Min(); // Method syntax with Min
        }


        public static double averageAll(int[] arr)
        {
            //return (from num in arr select num).Average(); // Query syntax with Average
            return arr.Average(); // Method syntax with Average]

        }

        //Sort
        public static int[] SortAscending(int[] arr)
        {
            return [.. from num in arr orderby num ascending select num]; // Query syntax with orderby ascending
        }

        public static int[] SortDescending(int[] arr)
        {
            return [.. from num in arr orderby num descending select num]; // Query syntax with orderby ascending
        }

        public static int[] ReverseArray(int[] arr)
        {
            return [.. (from num in arr select num).Reverse()]; // Query syntax with Reverse
        }

        public static int[] DistinctArray(int[] arr)
        {
            return [.. (from num in arr select num).Distinct()]; // Query syntax with Distinct
        }

        public static bool AllGT(int[] arr, int num)
        {
            return arr.All(n => n > num);
        }

        public static bool AnyGT(int[] arr, int num)
        {
            return arr.Any(n => n > num);
        }
    }

}
