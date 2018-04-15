// BInary search


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 4, 5, 6, 7, 8, 9 };
            int ser = 3;
            if (BinSearch(arr, 0, arr.Length - 1, ser))
            {
                System.Console.WriteLine("FOund");
            }
            else
                System.Console.WriteLine("NOt found");

        }

        public static bool BinSearch(int[] arr, int start, int end, int ser)
        {
            if (start > end)
            {
                return false;
            }
            int mid = (start + end) / 2;
            if (arr[mid] > ser)
            {
                return BinSearch(arr, start, mid - 1, ser);
            }
            else if (arr[mid] < ser)
            {
                return BinSearch(arr, mid + 1, end, ser);
            }
            else
            {
                return true;
            }
        }
    }
}


// use randomized partition to avoid worst case.