namespace ProductsVat
{
    /// <summary>
    /// Reads the price of a product and the VAT rate from the console, calculates the VAT (24%) amount and the total price, and prints the results formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declare and initialize variables
            double price = 0D;
            const double VAT_RATE = 0.24D;
            double vatAmount = 0D;
            double finalPrice = 0D;

            // Data entry, data binding and validation
            Console.WriteLine("Plase enter the price of the product: ");

            if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Invalid input for price.");
                return;
            }
             

            //Logic and calculations
            vatAmount = price * VAT_RATE;
            finalPrice = price + vatAmount;

            //Output
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Set output encoding to UTF-8 to support the Euro symbol
            Console.WriteLine($"{"Price before VAT:",-20} {price:N2} \u20AC");
            Console.WriteLine($"{"VAT amount:",-20} {vatAmount:N2} \u20AC");
            Console.WriteLine($"{"Total price:",-20} {finalPrice:N2} \u20AC");

        }
    }
}
