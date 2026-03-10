namespace FormatExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Εισάγατε ένα ακέραιο (0 for Quit)");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Εισάγατε τον ακέραιο: {num}");
                    if (num == 0) break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}