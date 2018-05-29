namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            char[,] matrix = new char[,]
            {
                {'G','E','E','K','S', 'F', 'O', 'R', 'G', 'E', 'E', 'K', 'S'},
                { 'G','E','E','K','S','Q','U','I','Z','G','E','E','K'},
                {'I','D','E','Q','A','P','R','A','C','T','I','C','E'}
            };
            PatternSearch(matrix, "EEE");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        public static void PatternSearch(char[,] matrix, string word)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (Search2D(matrix, row, col, word))
                    {
                        System.Console.WriteLine("Pattern found at " + row + " " + col);
                    }
                }
            }
        }
        public static bool Search2D(char[,] matrix, int row, int col, string word)
        {
            int[] x = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] y = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
            if (matrix[row, col] != word[0])
                return false;
            int len = word.Length;
            for (int dir = 0; dir < 8; dir++)
            {
                // Initialize starting point for current direction  
                int k, rd = row + x[dir], cd = col + y[dir];
                for (k = 1; k < len; k++)
                {
                    if (rd >= row || rd < 0 || cd >= col || cd < 0)
                        break;
                    if (matrix[rd, cd] != word[k])
                        break;
                    rd += x[dir];
                    cd += y[dir];
                }
                // If all character matched, then value of must
                // be equal to length of word
                if (k == len)
                    return true;
            }
            return false;
        }
    }
}