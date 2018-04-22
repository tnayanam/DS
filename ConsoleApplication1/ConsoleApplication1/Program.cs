// test case " "
//             "("
//             ")"
//             "()"
using System;
using System.Collections.Generic;

class Solution
{
    public static int CheckString(string str)
    {
        Stack<int> s1 = new Stack<int>();
        s1.Push(-1);
        int res = 0;
        for (int index = 0; index < str.Length; index++)
        {
            if (str[index] == '(')
            {
                s1.Push(index);
            }
            else
            {
                s1.Pop();
                if (s1.Count != 0)
                {
                    if (res < index - s1.Peek())
                    {
                        res = index - s1.Peek();
                    }
                }
                else
                {
                    s1.Push(index);
                }
            }
        }
        return res;
    }
    static void Main(string[] args)
    {
        string str = "))()()(((())())(()";

        Console.Write(CheckString(str));
    }
}
