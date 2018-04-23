using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    public static bool Check(string str)
    {
        Stack<char> st = new Stack<char>();

        foreach (var item in str)
        {
            if (item == '[' || item == ']')
            {

                if (item == '[')
                {
                    st.Push(item);
                }
                else if (st.Count == 0)
                {
                    return false;
                }
                else if (item == ']')
                {
                    if (st.Peek() == '[')
                    {
                        st.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        if (st.Count != 0)
            return false;

        return true;
    }


    static void Main(string[] args)
    {


        String str = "[[Thias is a ]] test";

        Console.Write(Check(str));

    }
}


