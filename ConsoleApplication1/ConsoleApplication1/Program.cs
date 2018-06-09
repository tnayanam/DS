using System.Collections.Generic;
using System.Text;

// 1 1 2 3 5 8 13 21 34 55 89
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc(ab)(a(abbc))ab";
            string abc = "ABC(EF)(E(oppi))AB";
            Stack<int> s1 = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (s1.Count == 0 && str[i] == 'a')
                    sb.Append('A');
                if (s1.Count == 0 && str[i] == 'b')
                    sb.Append('B');
                if (s1.Count == 0 && str[i] == 'c')
                    sb.Append('C');
                if (str[i] == '(')
                {
                    s1.Push('(');
                }
                if(s1.Count==1)
                {
                    if (str[i] == 'a')
                        sb.Append('E');
                    if (str[i] == 'b')
                        sb.Append('F');
                }
                if (str[i] == ')')
                {
                    s1.Pop();
                }
                if (s1.Count == 2)
                {
                    if (str[i] == 'a')
                        sb.Append('o');
                    if (str[i] == 'b')
                        sb.Append('p');
                    if (str[i] == 'c')
                        sb.Append('i');
                }
            }
            System.Console.WriteLine(sb);

        }
    }
}
