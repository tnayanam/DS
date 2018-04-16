
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index1 = -1;
            int index2 = -1;
            int sum = 10;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    index1 = i;
                    index2 = dict[arr[i]];
                    break;
                }
                dict[sum - arr[i]] = i;
            }
            System.Console.WriteLine("Index1: {0} and Index2: {1}", index1, index2);
        }
    }
}
