// factorial using recursion

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            System.Console.WriteLine(calFac(num));
        }

        public static int calFac(int num)
        {
            if (num == 1)
                return 1;
            return num * calFac(num - 1);
        }
    }
}

