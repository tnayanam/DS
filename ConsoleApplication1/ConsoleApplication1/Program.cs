using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 9;
            int end = 12;
            int index = end - start + 2;
            int firstRow = 9;
            int firstColumn = 9;

            int[,] matrix = new int[index, index];

            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        matrix[i, j] = 0;
                        continue;
                    }
                    if (i == 0)
                    {
                        matrix[i, j] = firstRow;
                        firstRow++;
                    }
                    else if (j == 0)
                    {
                        matrix[i, j] = firstColumn;
                        firstColumn++;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, 0] * matrix[0, j];
                    }
                }
            }
            //output
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < index; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }
}