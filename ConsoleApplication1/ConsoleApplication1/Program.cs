// longest substring sequence
// O(n)

// HashSet is just like List only difference is it does not allow duplicate valuse
// Add method returns false if duplicate valuess are returned.

using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        //abcade
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("abcba"));
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int i = 0;
            int j = 0;
            int maxLength = 0;
            HashSet<int> h1 = new HashSet<int>();
            int n = s.Length;
            while (i < n && j < n)
            {
                if (h1.Add(s[j]))
                {
                    j++;
                    maxLength = Math.Max(maxLength, j - i);
                }
                else
                {
                    h1.Remove(s[i]);
                    i++;
                }
            }
            return maxLength;
        }
    }
}
