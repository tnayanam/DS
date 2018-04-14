// Replace space with %20

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 3, 4, 1, 2, 6, 4 }; // 6,4,3,4,1,2
            int pivot = 4;

            for (int i = 0; i < pivot; i++) // O(pivot*n)
            {

                rotateArrayByOne(ref arr);
            }
            foreach (var ar in arr)
            {
                System.Console.WriteLine(ar + " ");
            }

        }

        public static void rotateArrayByOne(ref int[] arr)
        {
            int len = arr.Length;
            int temp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[len - 1] = temp;
        }
    }
}

