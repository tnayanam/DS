// Reverse an integer

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 549;
            string[] str1 = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] str2 = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "Xc" };
            string[] str3 = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string res = str3[(num % 1000) / 100] + str2[(num % 100) / 10] + str1[num % 10];

        }
    }
}


