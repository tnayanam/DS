// Anagram
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Listen";
            string str2 = "Silent";

            //string str1 = "Rooo";
            //string str2 = "ooR";

            //string str1 = "Lisn";
            //string str2 = "Sile";


            bool isAnagram = checkAnagram(str1.ToUpper(), str2.ToUpper());

            System.Console.WriteLine("Palindrome: " + isAnagram);
        }

        public static bool checkAnagram(string str1, string str2)
        {

            if (str1 == null || str2 == null)
                return false;

            if (str1.Length != str2.Length)
                return false;

            int[] arr1 = new int[256];
            int[] arr2 = new int[256];

            foreach (var c in str1) // at tht ASCII place the value is incremented
            {
                arr1[c]++;
            }

            foreach (var c in str2)
            {
                arr2[c]++;
            }

            for (int i = 0; i < 256; i++)
            {
                if (arr1[i] == arr2[i])
                    continue;
                else return false;
            }
            return true;
        }
    }
}











