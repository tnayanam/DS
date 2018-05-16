// Transpose of a MATRIX
/*
 * 1 2 3
 * 4 5 6
 * 7 8 9
 * 
 * 1 4 7
 * 2 5 8
 * 3 6 9
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

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
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