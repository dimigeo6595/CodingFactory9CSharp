namespace TravellingApp
{
    /// <summary>
    /// Reads the fuel consumption (liters/100km) and the distance (km) from the console, 
    /// calculates the total fuel needed for the trip and the total cost (assuming a fuel price of 1.5 euros per liter) 
    /// and prints the result formatted to 2 decimal places.
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {            
            // Declare and initialize variables
            const double FUEL_PRICE = 1.5D; // Fuel price per liter in euros
            double fuelConsumption = 0D; // Fuel consumption in liters per 100 km
            double distance = 0D; // Distance in kilometers
            double cost = 0D; // Total cost of the fuel for the trip
            double fuelNeeded = 0D; // Total fuel needed for the trip in liters            

            //Data entry, data binding and validation
            Console.WriteLine("Please enter the fuel consuption in lt/100km");

            if (!double.TryParse(Console.ReadLine(), out fuelConsumption) || fuelConsumption < 0)
            {
                Console.WriteLine("Invalid input for fuel consumption.");
                return;
            }

            Console.WriteLine("Please enter the distance in km: ");

            if (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Invalid input for distance.");
                return;
            }

            // Logic and calculations
            fuelNeeded = Math.Round((fuelConsumption / 100) * distance, 2); // Calculate total fuel needed for the trip
            cost = Math.Round(fuelNeeded * FUEL_PRICE, 2); // Calculate total cost of the fuel for the trip

            // Output
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Set output encoding to UTF-8 to support the Euro symbol
            Console.WriteLine($"{"Distance to travel:",-20} {distance:N2}");
            Console.WriteLine($"{"Fuel consumption:",-20} {fuelConsumption:N2}");
            Console.WriteLine($"{"Fuel needed:",-20} {fuelConsumption:N2}");
            Console.WriteLine($"{"Fuel price:",-20} {FUEL_PRICE:N2}");
            Console.WriteLine($"{"Total cost:",-20} {cost:N2} \u20AC");
        }
    }
}
