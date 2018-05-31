using System;

namespace MainSolution
{
    class Program
    {
        public static void Main()
        {
            int start = Int32.MaxValue;
            int end = Int32.MinValue;
            string searchString = "";
            string S = "qasbvgttdf";
            for (int i = 0; i < searchString.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if (searchString[i] == S[j])
                    {
                        if (j < start)
                        {
                            start = j;
                        }
                        if (j > end)
                        {
                            end = j;
                        }
                        break;
                    }
                }
            }
            
            Console.WriteLine(S.Substring(start, end-start+1));
        }
    }
}
