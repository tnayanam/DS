using System;

// To execute C#, please define "static void Main" on a class
// named Solution.
// Insert Position

class Solution
{

    public static int FindIndex(int[] arr, int left, int right, int elem)
    {

        if (left > right)
            return left;

        int mid = (left + right) / 2;

        if (arr[mid] == elem)
            return left;

        if (arr[mid] > elem)
            return FindIndex(arr, left, mid - 1, elem);
        else
            return FindIndex(arr, mid + 1, right, elem);
    }

    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 3, 5, 6 };
        int elem = 2;

        Console.Write(FindIndex(arr, 0, arr.Length - 1, elem));
    }
}


