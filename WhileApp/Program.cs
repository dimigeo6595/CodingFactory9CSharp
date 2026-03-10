namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int END = 10;
            int sum = 0;
            int i = 1;

            while (i <= END)
            {
                sum += i;
                i++;
            }

            Console.WriteLine($"Το άθροισμα από 1 έως {END} είναι: {sum}");
        }
    }
}