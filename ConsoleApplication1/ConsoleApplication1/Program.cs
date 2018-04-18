
//4 SUM O(N*N*N)
using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2 , 10, 20, 30, 40};
            int len = arr.Length;
            int sum = 91;
            for (int i = 0; i < len - 3; i++)
            {
                for (int j = i+1; j < len - 2; j++)
                {
                    int tempsum = arr[i] + arr[j];
                    int low = j + 1;
                    int high = len - 1;
                    while(low<high)
                    {
                        if(tempsum + arr[low] + arr[high] > sum)
                        {
                            high--;
                        }
                        else   if(tempsum + arr[low] + arr[high] < sum)
                        {
                            low++;
                        }
                        else
                        {
                            Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[low] + " " + arr[high]);
                            return;
                        }
                    }
                }
            }
        }
    }
}


