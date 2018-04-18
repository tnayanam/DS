
//4 SUM O(N*N*N*N)
using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 1, 2 };
            int len = arr.Length;
            int sum = 91;
            for (int i = 0; i < len - 3; i++)
            {
                for (int j = i+1; j < len - 2; j++)
                {
                    for (int k = j+1; k < len - 1; k++)
                    {
                        for (int l = k+1; l < len; l++)
                        {
                            if (sum == arr[i] + arr[j] + arr[k] + arr[l])
                            {
                                Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[k] + " " + arr[l]);
                                break;
                            }
                        }
                    }
                }
            }

        }

    }
}


