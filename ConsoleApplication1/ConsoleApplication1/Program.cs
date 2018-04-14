// Majority Element

using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 3, 2, 3, 5, 2 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                    dict[item] += 1;
                else
                    dict[item] = 1;
            }

            foreach (var item in dict)
            {
                if (item.Value > arr.Length / 2)
                    System.Console.WriteLine("Majority element found: {0}", item.Key);
            }
        }
    }
}

