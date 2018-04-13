// Anagram
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "Listen";
            //string str2 = "Silent";

            //string str1 = "Rooo";
            //string str2 = "ooR";

            string str1 = "Lisn";
            string str2 = "Sile";


            bool isAnagram = checkAnagram(str1.ToUpper(), str2.ToUpper());

            System.Console.WriteLine("Palindrome: " + isAnagram);
        }

        public static bool checkAnagram(string str1, string str2)
        {

            if (str1 == null || str2 == null)
                return false;

            if (str1.Length != str2.Length)
                return false;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var c in str1)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] = dict[c] + 1;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            foreach (var c in str2)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] = dict[c] - 1;
                }
                else
                    return false;
            }

            foreach(var c in dict)
            {
                if (c.Value > 0)
                    return false;
            }
            return true;
        }
    }
}











