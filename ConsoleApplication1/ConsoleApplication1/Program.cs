// Move all zeroes to the end to the array 
// time complexity is O(n) space is O(1)

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[9] { 0, 0, 1, 0, 2, 5, 8, 9, 0 };
            int[] arr2 = new int[9];
            int i = 0;
            int j = 0;
            while (i < arr1.Length)
            {
                if (arr1[i] == 0)
                    i++;
                else
                {
                    arr2[j] = arr1[i];
                    arr1[i] = 0;
                    i++;
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

