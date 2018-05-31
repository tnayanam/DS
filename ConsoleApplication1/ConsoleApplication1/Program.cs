namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            int[,] matrix = new int[,]
                             {
                                {1,  2,  3},
                                {4,  5,  6},
                                {7,  8,  9},
                                {10, 11, 12},
                                {13, 14, 15}
                             };
            System.Console.WriteLine(Search(matrix,1));
        }

        public static bool Search(int[,] matrix, int num)
        {
            int rowCount = matrix.GetUpperBound(0);
            int i = 0;
            int j = matrix.GetUpperBound(1);
            while (i <= rowCount && j >= 0)
            {
                if (num > matrix[i, j] )
                {
                    i++;
                }
                else if (num < matrix[i, j])
                {
                    j--;
                }
                else
                    return true;
            }
            return false;
        }
    }
}
