/**********************************************************************************
*
* 
* Given an unsorted integer array, find the first missing positive integer.
* 
* 
* 
* For example,
* Given [1,2,0] return 3,
* and [3,4,-1,1] return 2.
* 
* 
* 
* Your algorithm should run in O(n) time and uses constant space.
* 
*
**********************************************************************************/

// Smallest positive missing number from an array
// ex: [1,4,5,17] if we look look closely the number can only be in between 1,5 (inclusive), so we can use index.  
// segregate all negative and postivive from an array

using System;

namespace MainSolution
{
    class Program
    {
        public static int Segregate(int[] arr)
        {
            int j = 0;
            int i = 0;
            for (i = 0; i < arr.Length;)
            {
                if (arr[i] > 0) // ideally for segregation we need to have arr[i] >=0 but here we want even 0 to be towards negative side to e treated as negative so we
                                // removes the equal to sign
                {
                    i++;
                }
                else
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                    i++;
                }
            }

            int[] arr2 = new int[i - j]; //now we made the array to be completely positive , it does not even has ZERO
            for (int k = 0; k < arr2.Length; k++)
            {
                arr2[k] = arr[j];
                j++;
            }
            // all positive arrays elements and NOT ZERO
            foreach (var item in arr2)
            {
                System.Console.Write(item + " ");
            }

            System.Console.WriteLine("--------------------");
            return findMissingPositive(arr2);
        }

        /* Find the smallest positive missing number in an array that contains
  all positive integers */
        public static int findMissingPositive(int[] arr2)
        {
            int i;

            // Mark arr[i] as visited by making arr[arr[i] - 1] negative. Note that 
            // 1 is subtracted because index start from 0 and positive numbers start from 1
            for (i = 0; i < arr2.Length; i++)
            {
                if (Math.Abs(arr2[i]) - 1 < arr2.Length && arr2[Math.Abs(arr2[i]) - 1] > 0)
                    arr2[Math.Abs(arr2[i]) - 1] = -arr2[Math.Abs(arr2[i]) - 1];
            }

            // Return the first index value at which is positive
            for (i = 0; i < arr2.Length; i++)
                if (arr2[i] > 0)
                    return i + 1;  // 1 is added becuase indexes start from 0

            return arr2.Length + 1;
        }

        public static void Main()
        {
            int[] arr = new int[] { 0, 10, 2, -10, -20, -3, -1, 5, 6, 78, 12, 1 };
            Console.WriteLine(Segregate(arr));
        }
    }
}