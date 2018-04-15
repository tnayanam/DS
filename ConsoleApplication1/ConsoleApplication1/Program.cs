// Quick Sort
// In Place
// o(n)


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 7, 8, 9, 2, 8, 7 };
            int ser = 7;
            foreach (var item in arr)
            {
                if (item == ser)
                {
                    System.Console.WriteLine("found");
                    break;
                }
            }
        }
    }
}


// use randomized partition to avoid worst case.