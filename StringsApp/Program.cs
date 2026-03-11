namespace StringsApp
{
    /// <summary>
    /// String are immutable and are interned by the .NET runtime,
    /// meaning that identical string literals are stored only once in memory and reference the same object.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str1 = "hello";
            string? str2 = "hello";
            string? str3 = new string("hello");

            Console.WriteLine(str1[0]); // 'h' (indexing)

            //string equality
            Console.WriteLine(str1 == str2); // true (value equality)
            Console.WriteLine(str1.Equals(str2)); // true (value equality)


            // reference equality
            Console.WriteLine(object.ReferenceEquals(str1, str2)); // true (string literals are interned by the compiler, so str1 and str2 reference the same object in memory)
            Console.WriteLine(object.ReferenceEquals(str1, str3)); // false (str3 is a new string object created at runtime, so it does not reference the same object as str1)

            // Compare strings
            Console.WriteLine(string.Compare(str1, str3)); // 0 (str1 and str3 have the same value, so they are considered equal)
            Console.WriteLine(str1.CompareTo(str2)); // 0 (str1 and str2 have the same value, so they are considered equal)
            int resultEqualsIgnoreCase = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase); // 0 (str1 and str2 have the same value, so they are considered equal, ignoring case)

            // concatenation
            string? result = str1 + " " + str2; // concatenation using the + operator
            string? result2 = string.Concat(str1, " ", str2); // concatenation using the Concat method

            //ToUpper and ToLower
            string? upper = str1.ToUpper(); // convert to uppercase HELLO
            string? lower = str1.ToLower(); // convert to lowercase hello

            Console.WriteLine(str1.ToUpper() == str2.ToUpper()); // normalized comparison, true

            //Substring
            string? sub = str1.Substring(0, 2); // "he" startIndex, length
            string? part = str1.Substring(2); // "llo" startIndex to the end of the string

            //indexOf, lastIndexOf
            int index = str1.IndexOf('l'); // 2 (first occurrence of 'l')
            int lastIndex = str1.LastIndexOf('l'); // 3 (last occurrence of 'l')

            //Trim
            string? padded = "  hello  ";
            string? trimmed = padded.Trim(); // "hello" removes leading and trailing whitespace



        }
    }
}
