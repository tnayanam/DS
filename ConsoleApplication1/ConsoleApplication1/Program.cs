using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    public static int[] Find(int[] nums)
    {
        int i = nums.Length - 1;
        while (i > 0 && nums[i - 1] > nums[i])
        {
            i--;
        }
        if (i == 0)
        {
            Array.Reverse(nums);
            return nums;
        }

        Console.WriteLine("Element: " +  nums[i-1]); // now towards right find the just larest element then num[i-1]

        int num = nums[i - 1];
        int diff = Int32.MaxValue;
        int index = 0;
        for(int j = i;j<nums.Length;j++)
        {
            int sub = nums[j] - num;
            if(sub<diff && nums[j] > nums[i-1])
            {
                diff = sub;
                 index = j;
            }
        }
        var temp = nums[index];
        nums[index] = nums[i - 1];
        nums[i - 1] = temp;

        Array.Reverse(nums, i, nums.Length-i );


        return nums;
    }

    static void Main(string[] args)
    {
        int[] arr = new int[] { 5,3,6,8,7,1 };
        Find(arr);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
