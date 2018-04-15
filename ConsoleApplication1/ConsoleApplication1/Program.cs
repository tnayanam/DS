// factorial using recursion

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 70;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    System.Console.WriteLine("Prime");
                    break;
                }

            }
        }
    }
}

