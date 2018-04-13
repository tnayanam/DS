// Reverse
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Tanuj";
            //int len = str.Length;
            // Strings are Immutable so we can only read from string we cannot change it
            //for (int i = 0; i < len/2; i++)
            //{
            //    char temp;
            //    temp = str[i];
            //    str[i] = str[len - i - 1];
            //    str[len - 1 - i] = temp;
            //}

            string str1 = "Hello";
            string str2 = "";

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 += str1[i];
            }
            System.Console.WriteLine(str2);
        }

    }
}











