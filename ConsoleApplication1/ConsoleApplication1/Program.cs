using System;

public class Program
{
    public static int RemoveElement(int[] nums, int val)
    {

        if (nums.Length == 0)
        {
            return 0;
        }
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
        int num = 5;
        int newLen = RemoveElement(arr, num);
        for (int i = 0; i < newLen; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}