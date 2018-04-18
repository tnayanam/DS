// Longest common prefix O(n*N)
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "Geeks", "Geeabc", "GeeksfporGeeks" };
            Console.WriteLine(prefix(strs));

        }
        public static string prefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            var longest = "";


            for (int i = 0; i < strs[0].Length; i++ )
            {
                for(int j = 1;j<strs.Length;i++)
                {
                    if(strs[0][i] != strs[j][i] || strs[j].Length == i)
                    {
                        return longest;
                    }
                    longest += strs[0][i];
                }
            }
            return longest;
        }

    }
}


