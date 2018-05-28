using System;

namespace MainSolution
{
	class Program
	{
        public static void Main()
		{
            // Can Jump
            // Could not understand properly
            int[] arr = new int[] {  3, 2, 1, 0, 4};

            int reach = 0;

            for (int i = 0; i <= reach && i < arr.Length; i++)
            {
                reach = Math.Max(arr[i] + i, reach);
            }

            if (reach < arr.Length - 1)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");

        }
    }
}