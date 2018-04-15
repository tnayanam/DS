// Code for fibanacci
// Nth Fibonacci Series

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 5;
            System.Console.WriteLine(calFib(len));
        }

        public static int calFib(int len)
        {
            if (len <= 1)
                return len;
            return calFib(len - 1) + calFib(len - 2);
        }
    }
}

