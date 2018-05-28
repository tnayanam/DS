using System;

namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            int num = 24;
            for (int i = 1; i <= num / 2; i++)
            {
                if ((i * i) <= num && (i+1) * (i+1) > num)
                {
                    Console.Write(i);
                    break;
                }
            }
        }
    }
}
