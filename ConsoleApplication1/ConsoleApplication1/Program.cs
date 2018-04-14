// Replace space with %20

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 5, 7 }; // 23

            int num = 8;
            for (int i = 0, j = arr.Length - 1; i < j;)
            {
                if (arr[i] + arr[j] == num)
                {
                    System.Console.WriteLine("found");
                    break;
                }
                else if (arr[i] + arr[j] > 8)
                    j--;
                else
                    i++;
            }
        }
    }
}

