using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Program
    {
        public static bool Check(string str)
        {
            Stack<char> st = new Stack<char>();
            foreach (var item in str)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    st.Push(item);
                }
                else if(st.Count == 0)
                {
                    return false;
                }
                else
                {
                    if (item == ')')
                    {
                        if (st.Peek() == '(')
                        {
                            st.Pop();
                        }
                        else
                            return false;
                    }
                    if (item == '}')
                    {
                        if (st.Peek() == '{')
                        {
                            st.Pop();
                        }
                        else
                            return false;
                    }
                    if (item == ']')
                    {
                        if (st.Peek() == '[')
                        {
                            st.Pop();
                        }
                        else
                            return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string str = "((}))";
            System.Console.WriteLine(Check(str));
        }
    }
}


