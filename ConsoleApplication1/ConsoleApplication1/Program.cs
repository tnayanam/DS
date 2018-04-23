using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { -1, -2, 3, 4, 5, -3, 7, -9, 8 };
        int i = 0;
        int j = 0;
        bool pos = false; // we need to detect the change is from positive to negative
        while (i < arr.Length)
        {
            if (arr[i] < 0)
            {
                if (pos == true)
                {
                    var temp = arr[i];
                    for (int k = i; k >= i - j; k--)
                    {
                        arr[k] = arr[k - 1];
                    }
                    arr[j] = temp;
                }
                j++;
                i++;
            }
            else
            {
                i++;
                pos = true;
            }
        }

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}


