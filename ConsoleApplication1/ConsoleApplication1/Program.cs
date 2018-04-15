// BInary searchO(logn)


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 4, 5, 6, 7, 8, 9 };
            int ser = 7;
            int index = BinSearch(arr, 0, arr.Length - 1, ser);
            if(index ==-1)
                System.Console.WriteLine("Not FOund");
            
            else
                System.Console.WriteLine("found: " + index);

        }

        public static int BinSearch(int[] arr, int start, int end, int ser)
        {
            if (start > end)
            {
                return -1;
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
                return mid;
            }
        }
    }
}


// use randomized partition to avoid worst case.