// number of word in a string

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A new world";
            bool ot = true;

            int count = 0;
            foreach (var item in str)
            {
                if (item == ' ')
                {
                    ot = true;
                }
                else if (ot == true)
                {
                    ot = false;
                    count++;
                }
            }

            System.Console.WriteLine(count);
        }
    }
}

