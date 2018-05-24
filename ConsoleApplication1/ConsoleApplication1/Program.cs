// Sub String Occurence Count

using System;

namespace ConsoleApplication1
{
    class Program
    {
        //abcade
        static void Main(string[] args)
        {
            string longstr = "tanuj is a good is id sis";
            string smallstr = "is";
            int i = 0;
            int j = 0;
            int count = 0;
            while ((i = longstr.IndexOf(smallstr,i))!=-1)
            {
                i = i + smallstr.Length;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}