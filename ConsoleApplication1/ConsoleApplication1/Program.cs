// Replace space with %20

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "abab";
            int cw = 0;
            for (int i = 1; i < value.Length; i++)
            {
                for (int j = 0; j <= value.Length - i; j++)
                {
                    System.Console.WriteLine(value.Substring(j, i));
                }
            }

            System.Console.WriteLine(cw);

        }
    }
}

