using System;

// 1 1 2 3 5 8 13 21 34 55 89
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CalcFib(6));
            CalcSeries(6);
            Console.WriteLine();
            Console.WriteLine(FindNthNum(6));
        }
        public static int CalcFib(int num)
        {
            if (num <= 1)
                return num;
            return CalcFib(num - 1) + CalcFib(num - 2);
        }
        public static void CalcSeries(int num)
        {
            Console.WriteLine();
            int sum = 0;
            int n1 = 0;
            int n2 = 1;
            for (int i = 0; i < num; i++)
            {
                Console.Write(n2 + " ");
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }
        }
        // DP
        public static int FindNthNum(int num)
        {
            int[] arr1 = new int[num + 2];
            arr1[0] = 0;
            arr1[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                arr1[i] = arr1[i - 1] + arr1[i - 2];
            }
            return arr1[num];
        }
    }
}
