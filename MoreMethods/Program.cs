namespace MoreMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            result = Add(1, 2, 3); // 6
            DateTime dateTime = GetDateTime(); // 2024-06-01T00:00:00Z

        }


        // Its is like overloading the method.
        public static int Add(params int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        public static DateTime GetDateTime(int year = 1970, int month = 1, int day = 1,
            int min = 0, int sec = 0, int ms = 0)
        {
            return new DateTime(year, month, day, min, sec, ms, DateTimeKind.Utc);
        }


        // Overloading methods: same method name but different parameters
        public static void SayHello(string message)
        {
            Console.WriteLine(message);
        }

        public static void SayHello()
        {
            Console.WriteLine("Coding");
        }
    }
}