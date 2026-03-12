using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityApp
{
    internal static class HelloUtil
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye, {name}!");
        }



    }
}
