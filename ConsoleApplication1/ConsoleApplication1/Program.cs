using System;

public class Program
{
    public static int removeDupe(int[] arr)
    {
        int j = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] != arr[i + 1])
            {
                j++;
                arr[j] = arr[i + 1];
            }
        }
        return j;
    }

    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
        int newLen = removeDupe(arr);
        for (int i = 0; i <= newLen; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}