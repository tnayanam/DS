// Rotate a Matrix ClockWise
/*
 * 1 2 3
 * 4 5 6
 * 7 8 9
 * 
 * 1 4 7
 * 2 5 8
 * 3 6 9
 * 
 * 7 4 1
 * 8 5 2
 * 9 6 3
 */

using System;
namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 1,2,3 },
                { 4,5,6 },
                { 7,8,9 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Transpose(matrix);
            // transposed matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            ReverseColumn(matrix);

            // rotate matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ReverseColumn(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0, k = 2; j < k; k--, j++)
                {
                    var temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }

        public static void Transpose(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = i; j < 3; j++)
                {
                    var temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
                Console.WriteLine();
            }
        }
    }
}