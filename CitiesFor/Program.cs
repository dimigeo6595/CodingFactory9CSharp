namespace CitiesFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Athens", "Thessaloniki", "Patras", "Heraklion", "Larissa" };

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}