using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    public delegate int AddDelagate(int num1, int num2);

    class Test
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1d6 + 2d20 - 25";
            string[] token = str.Split(' ');
            int length = token.Length;
            int total = ProcessString(token[token.Length - 1]);
            Stack<string> s1 = new Stack<string>();
            for (int i = 0; i < token.Length; i++)
            {
                if (i % 2 != 0)
                {
                    s1.Push(token[i]);
                }
            }
            for (int i = token.Length - 3; i >= 0; )
            {
                var val = ProcessString(token[i]);
                string oper = s1.Pop();
                switch (oper)
                {
                    case "+":
                        total = total + val;

                        break;
                    case "-":
                        total = val - total;
                        break;
                }
                i = i - 2;
            }
            Console.WriteLine("total: " + total);
        }

        public static int ProcessString(string str)
        {
            string[] tok = str.Split('d');
            if (tok.Length == 1)
                return Convert.ToInt32(tok[0]);

            int intial = Convert.ToInt32(tok[0]);
            int end = Convert.ToInt32(tok[1]);
            Random r1 = new Random();
            int randomValue = r1.Next(intial, end);
            Console.WriteLine(randomValue);
            return randomValue;
        }
    }
}


