// print matrix zig zag order
/*
 * 1 2 3
 * 4 5 6
 * 7 8 9
 */

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,10,11,12 }
            };

            System.Console.WriteLine(matrix.GetUpperBound(0));//2
            System.Console.WriteLine(matrix.GetUpperBound(1));//4

            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    System.Console.Write(matrix[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    if (i % 2 != 0)
                    {
                        System.Console.Write(matrix[i, matrix.GetUpperBound(1) - j] + " ");
                    }
                    else
                    {
                        System.Console.Write(matrix[i, j] + " ");
                    }

                }
                //System.Console.WriteLine();
            }



        }
    }
}