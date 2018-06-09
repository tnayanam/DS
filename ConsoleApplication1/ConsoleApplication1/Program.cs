// Sub String Occurence Count

using System;

namespace ConsoleApplication1
{
    class Program
    {
        //abcade
        static void Main(string[] args)
        {
            string longstr = "taniisujii is a good is id sis iis";
            string smallstr = "iis";
            int i = 0;
            int j = 0;
            int count = 0;
            while (i != longstr.Length)
            {
                if (longstr[i] == smallstr[j])
                    j++;
                else if (longstr[i] != smallstr[j])
                    j = 0;
                if (j == smallstr.Length)
                {
                    count++;
                    j = 0;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}