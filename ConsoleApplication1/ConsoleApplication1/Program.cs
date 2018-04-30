// Jump 2
//For example:
//* Given array A = [2, 3, 1, 1, 4]
using System;

namespace MainSolution
{
    class Program
    {
        public static int findMinJump(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            int lastReach = 0;
            int reach = 0;
            int steps = 0;
            for (int i = 0; i <= reach && i < arr.Length; i++)
            {
                if (i > lastReach)
                {
                    steps++;
                    lastReach = reach;
                }
                reach = Math.Max(reach, arr[i] + 1);
            }

            if (reach < arr.Length - 1) return 0;
            return steps;
        }
        public static void Main()
        {
            int[] arr = new int[] { 2, 3, 1, 1, 4 };

            Console.WriteLine(findMinJump(arr));
        }
    }
}