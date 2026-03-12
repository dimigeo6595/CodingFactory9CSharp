using System.Text.RegularExpressions;

namespace RegExApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool TestCoding(string? s)
        {
            string pattern = @"^coding$";

            if (s == null) return false;

            bool isMatch = Regex.IsMatch(s, pattern);
            return isMatch;
        }

        public static void TestMatch(string? s)
        {
            string pattern = @"^coding$";
            Match match = Regex.Match(s!, pattern);

            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }


        public static void TestMatches(string? s)
        {
            string pattern = @"\d+";

            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }


        public static void TestGroups(string? s)
        {
            string pattern = @"(\d{2})-(\d{2})-(\d{4})";

            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach (Match match in matches)
            {
                for (int i = 1; i < match.Groups.Count; i++)
                {
                    Console.WriteLine($"Group {i}: {match.Groups[i].Value}");
                }
            }
        }

        // Zero-lenght assertions
        public static bool TestPassword(string? s)
        {
            return Regex.IsMatch(s!, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*]).{12,}$");
        }

    }
}