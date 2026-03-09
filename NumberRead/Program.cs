namespace NumberRead
{

    /// <summary>
    /// Safe reading of float and double values from the console using 
    /// TryParse method to handle invalid input gracefully.
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            float floatNum = 0F;
            double doubleNum = 0D;

            Console.WriteLine("Εισάγεται δύο δεκαδικούς");

            if(!float.TryParse(Console.ReadLine(), out floatNum) )
            {
                   Console.WriteLine("Μη έγκυρη είσαοδος για float.");
                return;
            }

            if(!double.TryParse(Console.ReadLine(), out doubleNum) )
            {
                   Console.WriteLine("Μη έγκυρη είσαοδος για double.");
                return;
            }
             
            
            Console.WriteLine($"Float: {floatNum,-6:N2},\t Double: {doubleNum}");



        }
    }
}
