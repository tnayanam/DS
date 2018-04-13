// Palindrome
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hellolle";
            bool isPalindrome = checkPalin(str);

            System.Console.WriteLine("Palindrome: " + isPalindrome);
        }

        public static bool checkPalin(string str)
        {
            try
            {
                var len = str.Length;

                for (int i = 0; i < len / 2; i++)
                {
                    if (str[i] != str[len - i - 1])
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                return true;
            }
            catch (System.Exception)
            {
                // handle execption there for string null type
                return false;
            }

        }
    }
}











