// Reverse an integer

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(5225));
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int rev = 0;
            int orig = x;

            while (x != 0)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }
            return (rev == orig) ? true : false;

        }
    }
}


