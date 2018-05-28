using System;

namespace MainSolution
{
	class Program
	{
        public static void Main()
		{
            string str = "tanuj is a good boys    ";
            bool spaceFound = false;
            string[] strArr = str.Trim().Split(' ');
            Console.WriteLine(strArr[strArr.Length - 1].Length);


        }
    }
}