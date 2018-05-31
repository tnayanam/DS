using System;

namespace MainSolution
{
    class Program
    {
        public static void Main()
        {

            int[] arr = new int[] { 3,8,1,2,5,-9,7};
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item +  "  ");
            }
        }
    }
}