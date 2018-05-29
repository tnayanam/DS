using System;
namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            string str1 = "11";
            string str2 = "11";
            Console.WriteLine(AddBinary(str1, str2));
        }
        public static string AddBinary(string str1, string str2)
        {
            string res = "";
            int carryOver = 0;
            int i1 = str1.Length - 1;
            int j1 = str2.Length - 1;
            while(i1>=0 || j1>=0 || carryOver == 1)
            {
                carryOver += ((i1 >= 0) ? str1[i1] - '0' : 0);
                carryOver += ((j1 >= 0) ? str2[j1] - '0' : 0);
               // for 1 and 3 we need below, for TWO res will be zero but carryOver will be 1. 
                res = (char)(carryOver % 2 + '0') + res; // again converting the integer to actgual ASCII value and then converting it to character
                // basically we got integer 1 and we need to convert it to character 1. and ascii value for charaqcter 1 in 49. 
                carryOver = carryOver / 2; // because for 1 it will be 0 for 3 and 2 it will be 1;
                i1--;j1--;
            }
            return res;
        }
    }
}
