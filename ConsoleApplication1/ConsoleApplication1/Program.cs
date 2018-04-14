// Merge Two Sorted Arrays


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 5, 8, 9 };
            int[] arr2 = new int[5] { 1, 2, 3,8,10 };

            int[] arr3 = new int[10];

            for (int i = 0, j = 0, k = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (j == arr1.Length)
                {
                    arr3[i] = arr2[k];
                    k++;
                }
                else if (k == arr2.Length)
                {
                    arr3[i] = arr1[j];
                    j++;
                }
                else if (arr1[j] <= arr2[k])
                {
                    arr3[i] = arr1[j];
                    j++;
                }
                else if (arr1[j] > arr2[k])
                {
                    arr3[i] = arr2[k];
                    k++;
                }
            }

            foreach (var item in arr3)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

