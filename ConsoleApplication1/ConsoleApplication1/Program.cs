namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            // matrix
            int[,] matrix = new int[,]
            {
    {1,0,1,1},
    {1,1,1,0},
    {0,1,1,1},
    {1,1,1,1},
    {1,1,1,1}
            };
            bool firstColumn = false;
            bool firstRow = false;
            int rowLength = matrix.GetLength(0);
            int columnLength = matrix.GetLength(1);
            //check first column 0
            for (int i = 0; i < rowLength; i++)
            {
                if (matrix[i, 0] == 0)
                    firstColumn = true;
            }
            //check first row 0
            for (int i = 0; i < columnLength; i++)
            {
                if (matrix[0, i] == 0)
                    firstRow = true;
            }
            // mark first row and first column as ZERO
            for (int i = 1; i < rowLength; i++)
            {
                for (int j = 1; j < columnLength; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, 0] = 0;
                        matrix[0, j] = 0;
                    }
                }
            }
            // make all rows and columns zero based on mark
            for (int i = 1; i < rowLength; i++)
            {
                for (int j = 1; j < columnLength; j++)
                {
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            // make firstrow and firstcolumn as 0 based	 on bool
            for (int i = 0; i < columnLength; i++)
            {
                if (firstColumn)
                    matrix[0, i] = 0;
            }

            // make firstcolumn and firstcolumn as 0 based	 on bool
            for (int i = 0; i < rowLength; i++)
            {
                if (firstRow)
                    matrix[i, 0] = 0;
            }

            for (int i = 0; i < rowLength; i++)
            {
                for(int j = 0;j<columnLength;j++)
                {
                    System.Console.Write(matrix[i,j] + "    ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
