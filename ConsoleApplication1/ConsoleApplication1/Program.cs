using System;
// Convert character 1 to actual value as 1
namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            char t = '1';
            Console.WriteLine(Convert.ToInt32(t)); // 49 -- Ascii value 
            int res = t - '0';
            Console.WriteLine(res); // 0 is 48 so 49-48 = 1
        }
    }
}
