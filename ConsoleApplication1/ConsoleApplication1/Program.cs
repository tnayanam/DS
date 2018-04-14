// Remove duplicate

using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 ="silent";
            string str2 = "listen";

            //The author didn't mention anything about case sensitivity. If you want to: .Equals(str2, StringComparison.OrdinalIgnoreCase)
            if (string.Join("", str1.Reverse()) == str2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}



