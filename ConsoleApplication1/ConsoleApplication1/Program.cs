// Replace space with %20

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A new worwld";
            str = str.Trim();
            str = str.Replace(" ", "%20");
            System.Console.WriteLine(str);

        }
    }
}

