// 1 1 2 3 5 8 13 21 34 55 89
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "throttle";
            System.Console.WriteLine (Non(str));
        }

        public static char FirstNonRepeatingCharacter(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                    dict[str[i]] = dict[str[i]] + 1;
                else
                    dict[str[i]] = 1;

            }

            foreach (var item in dict)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return ' ';
        }
    }
}
