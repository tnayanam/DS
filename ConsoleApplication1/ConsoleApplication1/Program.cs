// Swap two numbers w/0 temp

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            a = a + b;
            b = a - b;
            a = a - b;

            System.Console.WriteLine("a : " + a);
            System.Console.WriteLine("b : " + b);
        }
    }
}

