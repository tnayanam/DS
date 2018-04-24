using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
        int max_so_far = arr[0];
        int curr_max = arr[0];
        int start = 0;
        int end = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i] + curr_max)
                curr_max = arr[i];
            else
                curr_max = arr[i] + curr_max;

            if (max_so_far < curr_max)
                max_so_far = curr_max;
        }
        Console.Write(max_so_far);
    }
}


