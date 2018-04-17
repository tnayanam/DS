// Reverse an integer

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "-1234";
            Console.WriteLine(convertAtoI(str));
        }

        public static int convertAtoI(string str)
        {
            bool isNegative = false;
            int startPoint = 0;
            if (str == null || str.Length == 0)
                return 0;
            str = str.Trim();
            if (str[0] == '-')
            {
                isNegative = true;
                startPoint = 1;
            }

            int num = 0;
            for (int i = startPoint; i < str.Length; i++)
            {
                num = num * 10 + (str[i] - '0');// ascii of 1 is 49 to get actual 1 we need to sbtact it with ascii of 0
            }

            if (isNegative)
                return -num;
            return num;
        }
    }
}


