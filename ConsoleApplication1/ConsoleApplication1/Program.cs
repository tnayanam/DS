// Longest common prefix O(n*N)
// 3 SUM
// Find one triplet
using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[] { 1, 4, 45, 6, 10, 8 }; // for unsorted we might need to apply sort alogorithm before.
            List<int> lst = new List<int>();
            lst = prefix(numArr, num:12);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> prefix(int[] arr, int num)
        {
            int j = 0;    
            int len = arr.Length - 2;
            List<int> lst = new List<int>();
            for (int i = 0; i <len; i++ )
            {
                int low = i+1;
                int high = arr.Length - 1;
                while(low<=high)
                {
                    if(arr[i] + arr[low] + arr[high] == num)
                    {
                        lst.Add(arr[i]);
                        lst.Add(arr[low]);
                        lst.Add(arr[high]);
                        return lst;
                    }
                    else if (arr[i] + arr[low] + arr[high] > num)
                        high--;
                    else
                        low++;
                }
            }
            return lst;
        }
    }
}


