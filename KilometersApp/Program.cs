namespace KilometersApp
{
    /// <summary>
    /// Reads distance in kilometers from the console,
    /// converts it to meters, centimeters and miles and prints the result, formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            // Delare and initialize variables
            double kilometers = 0D;
            double meters = 0D;
            double centimeters = 0D;
            double miles = 0D;
            const double MILES_PER_KM = 0.621371;



            // Data endtry, data binding and validation
            Console.WriteLine("Please enter the distance in km: ");
            if (!double.TryParse(Console.ReadLine(), out kilometers) || kilometers <0)
            {
                Console.WriteLine("Invalid input for kilometers.");
                return;
            }

            // Logic and calculations
            meters = kilometers * 1000;
            centimeters = meters * 1000;
            miles = kilometers * MILES_PER_KM;


            // Output
            Console.WriteLine($"{"Kilometers:",-15} {kilometers:N2} km");
            Console.WriteLine($"{"Meters:",-15} {meters:N2} m");
            Console.WriteLine($"{"Centimeters:",-15} {centimeters:N2} cm");
            Console.WriteLine($"{"Miles:",-15} {miles:N2} miles");
        }
    }
}
