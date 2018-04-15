// Merge Sort
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 5, 4, 3, 2, 7, 8, 4 };
            mergeSort(arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];
            i = 0; // Initial index of first subarray
            j = 0; // Initial index of second subarray
            k = l; // Initial index of merged subarray // because we will have one as sorted.
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public static void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
    }
}

