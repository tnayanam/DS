// O(m+n) 
namespace ConsoleApplication1
{
    class Program
    {
        public static void findMedian(int[] arr3)
        {
            int mid = arr3.Length / 2;
            double median;
            System.Console.WriteLine(arr3[mid]);
            System.Console.WriteLine(arr3[mid - 1]);
            System.Console.WriteLine((arr3[mid] + arr3[mid - 1]) / 2);
            if (mid % 2 == 0)
            {
                median = (double)(arr3[mid] + arr3[mid - 1]) / 2;
            }
            else
            {
                median = arr3[mid];
            }
            System.Console.WriteLine("the median is: " + median);
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3 };
            int[] arr2 = new int[] { 2, 4 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    j++;
                }
                k++;
            }

            while (i < arr1.Length)
            {
                arr3[k] = arr1[i];
                i++;
                k++;
            }

            while (j < arr2.Length)
            {
                arr3[k] = arr2[j];
                j++;
                k++;
            }

            findMedian(arr3);
        }
    }
}
