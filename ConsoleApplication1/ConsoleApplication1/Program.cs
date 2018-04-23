using System;
using System.Collections.Generic;

class Solution
{
    public static int FindPivot(int[] arr, int num)
    {
        int pivot = arr.Length - 1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                pivot = i;
                break;
            }
            else
            {

            }
        }

        return pivot;
    }

    public static int BinarySearch(int[] arr, int left, int right, int num)
    {
        if (right < left)
            return -1;
        int mid = (left + right) / 2;
        if (arr[mid] == num)
            return mid;
        if (arr[mid] > num)
            return BinarySearch(arr, left, mid - 1, num);
        else
            return BinarySearch(arr, mid + 1, right, num);
    }

    public static int SearchOnPivot(int[] arr, int num)
    {
        int pivot = FindPivot(arr, num);
        int index;
        if (num > arr[0])
        {
            index = BinarySearch(arr, 0, pivot, num);
        }
        else
        {
            index = BinarySearch(arr, pivot + 1, arr.Length - 1, num);
        }
        return index;
    }

    static void Main(string[] args)
    {
        // int[] arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
        int[] arr = new int[] { 4, 5, 6, 7, 8, 9 };
        int num = 7;
        int index = SearchOnPivot(arr, num);
        if (index == -1)
            Console.Write("Element Not Found");
        else
            Console.Write("Num: " + arr[index] + " Index: " + index);
    }
}
