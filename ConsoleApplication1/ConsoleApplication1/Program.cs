using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 0, 0, 0, 2, 1 };
        int low = 0;
        int mid = 0;
        int high = arr.Length - 1;
        int temp = 0;
        while (mid <= high)
        {
            switch (arr[mid])
            {
                case 0:
                    temp = arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    mid++;
                    low++;
                    break;
                case 1:
                    mid++;
                    break;
                case 2:
                    temp = arr[mid];
                    arr[mid] = arr[high];
                    arr[high] = temp;
                    high--;
                    break;
            }
        }

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}


