using System;

namespace MainSolution
{
	class Program
	{
        // Function print matrix in spiral form
        static void spiralPrint(int[,] matrix)
        {
            int k = 0;
            int m = matrix.GetUpperBound(0); // row end position
            int l = 0;
            int n = matrix.GetUpperBound(1); // column end position

            while (k <= m && l <= n)
            {
                // Print first row.
                for (int i = l; i <= n; i++)
                {
                    Console.Write(matrix[k, i] + " ");
                }
                k++;
                // Print last column
                for (int i = k; i <= m; i++)
                {
                    Console.Write(matrix[i, n] + " ");
                }
                n--;
                if (k <= m)
                {
                    // Print last row
                    for (int i = n; i >= l; i--)
                    {
                        Console.Write(matrix[m, i] + " ");
                    }
                    m--;
                }
                if (l <= n)
                {
                    for (int i = m; i >= k; i--)
                    {
                        Console.Write(matrix[i, l] + " ");
                    }
                    l++;
                }

            }
        }

        // Driver program
        public static void Main()
		{
			int R = 3;
			int C = 6;
			int[,] a = { {1, 2, 3, 4, 5, 6},
					{7, 8, 9, 10, 11, 12},
					{13, 14, 15, 16, 17, 18}
					};
			spiralPrint(a);


		}
	}
}