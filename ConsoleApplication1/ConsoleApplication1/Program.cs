// Code for fibanacci

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 6;
            calFib(len);
        }

        public static void calFib(int len)
        {
            int n1 = 0; int n2 = 1;
            if (len < 1)
                return;
            for (int i = 0; i < len; i++)
            {
                System.Console.WriteLine(n2);
                int next = n1 + n2;
                n1 = n2;
                n2 = next;
            }
        }
    }
}

