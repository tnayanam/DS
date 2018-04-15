// Ways to clinmb a stair when you can climb 1 or 2 steps.
// its factorial of steps + 1

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 4;
            System.Console.WriteLine(calFib(len + 1));
        }

        public static int calFib(int len)
        {
            if (len <= 1)
                return len;
            return calFib(len - 1) + calFib(len - 2);
        }
    }
}

