namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            int[,] matrix = new int[,]{
            {1,2,3},
            {4,5,6},
            {7,8,9}
            };
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            System.Console.WriteLine(NoOfPaths(rows, columns));
        }

        public static int NoOfPaths(int rows, int columns)
        {
            if (rows == 1 || columns == 1)
                return 1;
            else
                return NoOfPaths(rows, columns - 1) + NoOfPaths(rows - 1, columns) + NoOfPaths(rows - 1, columns - 1);
        }
    }
}

// movement can only be right and down and Diagonally