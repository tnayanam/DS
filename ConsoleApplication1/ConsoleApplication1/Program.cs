// Move all zeroes to the end to the array 
// time complexity is O(n) space is O(n)

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[9] { 0, 0, 1, 0, 2, 5, 8, 9, 0 };
            int[] arr2 = new int[9];

            for (int i = 0, j = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
            }

            foreach (var item in arr2)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

