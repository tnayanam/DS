// Reverse an integer

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 204;
            Console.WriteLine(Reverse(num));
        }

        public static int Reverse(int num)
        {
            if (num > int.MaxValue || num < int.MinValue)
                return 0;
            var integer = Math.Abs(num);
            int newnum = 0;
            while (integer != 0)
            {
                if (newnum > (int.MaxValue - integer % 10) / 10)
                {
                    return 0;
                }
                newnum = newnum * 10 + integer % 10;
                integer = integer / 10;
            }
            return num > 0 ? newnum : -newnum;
        }
    }
}


