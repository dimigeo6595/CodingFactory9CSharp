using System.Text;

namespace StringBuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            string collector = "Numbers: ";
            for (int i = 0; i < 10000; i++)
            {
                collector += i + " "; // inefficient, creates a new string object on each iteration
            }

            Console.WriteLine(collector.Substring(0, 20));
            Console.WriteLine(DateTime.Now);


            Console.WriteLine(DateTime.Now);
            StringBuilder sb = new StringBuilder("Numbers: ");
            for(int i = 0; i < 10000; i++)
            {
                sb.Append(i); // inefficient, creates a new string object on each iteration
            }
            Console.WriteLine(sb.ToString().Substring(0, 20));
            Console.WriteLine(DateTime.Now);
        }
    }
}
