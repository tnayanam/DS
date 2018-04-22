using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    public static int Div(int num, int div)
    {
        if (num < div || div == 0)
            return 0;
        int i = 0;
        while (num >= div)
        {
            num = num - div;
            i++;
        }
        return i;
    }

    static void Main(string[] args)
    {
        int num = 40;
        int div = 8;
        Console.Write("Output: " + Div(num, div));
    }
}
