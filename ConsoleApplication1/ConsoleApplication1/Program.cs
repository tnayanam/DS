
//4 SUM O(N*N) Tuple and dictionary
using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2 , 10, 20, 30, 40};
            Dictionary<int, Tuple<int, int>> dict = new Dictionary<int, Tuple<int, int>>();
            int len = arr.Length;
            int sum = 91;
            for (int i = 0; i < len-1; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (!dict.ContainsKey(arr[i] + arr[j]))
                    dict.Add((arr[i] + arr[j]), new Tuple<int, int>(i, j));
                }
            }
            for(int i =0;i<dict.Count ; i++)
            {
                  for (int j = i+1; j < len; j++)
                  {
                      int tempsum = arr[i] + arr[j];
                      if(dict.ContainsKey(sum - tempsum))
                      {
                          Tuple<int, int> t1 = new Tuple<int, int>(dict[sum - tempsum].Item1,dict[sum - tempsum].Item2);
                          Console.WriteLine(t1.Item1);
                          Console.WriteLine(t1.Item2);
                          Console.WriteLine(j);
                          Console.WriteLine(i);
                          return;
                      }
                  }
            }
        }
    }
}


