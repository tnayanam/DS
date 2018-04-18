// Reverse an integer

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             Dictionary<char, int> dict = new Dictionary<char, int> { 
            {'M', 1000},
            {'D', 500},
            {'L',100},
            {'X', 10},
            {'V',5},
            {'I',1}
            };

            string s = "IX";
            int i = s.Length-1;
            int ret = dict[s[i]];
            i--;
            while(i>=0)
            {
                if(dict[s[i]] >= dict[s[i+1]])
                {
                    ret = ret + dict[s[i]];
                    i--;
                }
                else
                {
                    ret = ret - dict[s[i]];
                    i--;
                }
        }
    }
}


