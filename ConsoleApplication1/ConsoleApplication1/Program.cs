// number of max count in a string

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A new worwld";
            int[] arr = new int[256];
            int max = 0;
            char max1 = ' ';
            foreach (var item in str)
            {
                arr[item] = arr[item] + 1;
            }

            for (int i = 0; i < 256; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    max1 = (char)i;
                }
            }
            System.Console.WriteLine(max1.ToString());
        }
    }
}

