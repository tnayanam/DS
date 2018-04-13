// Remove duplicate
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Google";
            RemoveDupe(str);
            RemoveDupe1(str);
        }

        public static void RemoveDupe(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var c in str) // O(N)
            {
                if (dict.ContainsKey(c)) // Dictionary cannot have duplicate keys, So we need to put this check and also then we can increment the value instead of adding s duplicate key which will throw the exception.
                {
                    dict[c] = dict[c] + 1;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            string str1 = "";

            foreach (var f in dict)
            {
                str1 += f.Key;
            }

            System.Console.WriteLine(str1);
        }


        public static void RemoveDupe1(string str)
        {
            string str1 = "";

            foreach (var f in str)
            {
                if (str1.IndexOf(f) == -1)  // index  of character which is not there returns -1
                {
                    str1 += f;
                }
            }

            System.Console.WriteLine(str1);
        }
    }
}

















// ----------------------------------------------------------------------------------------------------------------------------------------------------//

//using System.Collections.Generic;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var str = "Enginner ROom";
//            printDupe(str.ToUpper());
//        }

//        public static void printDupe(string str)
//        {
//            Dictionary<char, int> dict = new Dictionary<char, int>();

//            foreach (var c in str)
//            {
//                if (dict.ContainsKey(c)) // checks if key is already present
//                {
//                    dict[c] = dict[c] + 1; // if present then add one to the value
//                }
//                else
//                {
//                    dict.Add(c, 1); // if first time then simply initialize count to 1
//                }
//            }

//            foreach (var d in dict)
//            {
//                if (d.Value > 1)
//                {
//                    System.Console.WriteLine(d.Key);
//                }
//            }
//        }
//    }
//}
