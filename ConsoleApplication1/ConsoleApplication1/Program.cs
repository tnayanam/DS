<<<<<<< HEAD
﻿// Remove duplicate

using System;
=======
﻿// Reverse
using System.Collections.Generic;
>>>>>>> 746eedfe824aceb079a60aee550b6805ab86b04a
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
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

>>>>>>> 746eedfe824aceb079a60aee550b6805ab86b04a
    }
}



<<<<<<< HEAD
=======








>>>>>>> 746eedfe824aceb079a60aee550b6805ab86b04a
