using System;

namespace MainSolution
{
	class Program
	{
        public static void Main()
		{
            string str = "tanuj is a good boys    ";
            bool spaceFound = false;
            str = str.Trim();
            int i = 0;
            int j = 0;
            while (i < str.Length)
            {
                if (str[i] == ' ')
                {
                    spaceFound = true;
                }
                else
                {
                    if (spaceFound)
                    {
                        spaceFound = false;
                        j = i;
                    }
                }
                i++;
            }

            Console.WriteLine(i - j);

        }
    }
}