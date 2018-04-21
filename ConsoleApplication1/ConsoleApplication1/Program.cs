using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Node
    {

        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            if (n <= 0) return result;
            GenerateParenthesis(n, n, "", result);
            return result;
        }
        private static void GenerateParenthesis(int left, int right, string item, List<string> result)
        {
            if (right < left) return;
            if (left == 0 && right == 0)
            {
                result.Add(item);
            }
            if (left > 0)
            {
                GenerateParenthesis(left - 1, right, item + "(", result);
            }
            if (right > 0)
            {
                GenerateParenthesis(left, right - 1, item + ")", result);
            }

        }
        static void Main(string[] args)
        {
            var list = GenerateParenthesis(3);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}


