
//closest SUM
using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[]  {-4,-1, 1,2}; // for unsorted we might need to apply sort alogorithm before.
            List<int> lst = new List<int>();
            Console.WriteLine(prefix(numArr, target: 1));
            
        }
        public static int prefix(int[] nums, int target)
        {
            var result = 0;
            var minDiff = int.MaxValue;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var j = i + 1;
                var k = nums.Length - 1;
                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    var diff = Math.Abs(sum - target);
                    if (minDiff > diff)
                    {
                        result = sum;
                        minDiff = diff;
                    }
                    else if (sum < target)
                    {
                        j++;
                    }
                    else if (sum > target)
                    {
                        k--;
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            return result;
        }
    }
}


