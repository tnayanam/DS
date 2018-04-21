using System.Linq;

namespace ConsoleApplication1
{
    public class Node
    {
        static void Main(string[] args)
        {
            System.Random rnd = new System.Random();

            var numbers = Enumerable.Range(1, 52).OrderBy(r => rnd.Next(1, 52)).ToArray();

            int[] numb = Enumerable.Range(1, 52).ToArray();

            foreach (var item in numbers)
            {
                System.Console.Write(item + " ");
            }


            foreach (var item in numb)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}


