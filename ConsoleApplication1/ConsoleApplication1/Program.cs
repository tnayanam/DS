// Quick Sort
// In Place
// O(nlogn) avergae time conplxity
// O(n2) worsrt case time coplexity which can be avoided with a doog pivot
// Not stable

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 7, 8, 9, 2, 8, 7 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                System.Console.Write(item);
            }
        }

        public static void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end) return;
            else
            {
                int pIndex = Partition(arr, start, end);
                QuickSort(arr, start, pIndex - 1);
                QuickSort(arr, pIndex + 1, end);
            }
        }

        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int pIndex = start;
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex++;
                }
            }
            int tem = arr[pIndex];
            arr[pIndex] = arr[end];
            arr[end] = tem;

            return pIndex;
        }
    }
}


// use randomized partition to avoid worst case.