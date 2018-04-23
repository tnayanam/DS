using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    public static void Print(int[][] arr)
    {

        int n = arr.Length;
        int[] indices = new int[arr.Length];

        while (true)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i][indices[i]] + " ");
            Console.WriteLine(" ");

            int next = arr.Length - 1;

            while (next >= 0 && (indices[next] + 1 >= arr[next].Length))
                next--;

            if (next < 0)
                return;

            indices[next]++;
            for (int i = next + 1; i < n; i++)
            {
                indices[i] = 0;
            }
        }


    }
    static void Main(string[] args)
    {
        int[][] arr = new int[3][];
        arr[0] = new int[] { 1, 2, 3 };
        arr[1] = new int[] { 4, 8 };
        arr[2] = new int[] { 5, 6, 7 };
        Print(arr);
    }
}


