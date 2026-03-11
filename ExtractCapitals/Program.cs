using System.Text;

namespace ExtractCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string ExtractCapitalLetters(string? input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
