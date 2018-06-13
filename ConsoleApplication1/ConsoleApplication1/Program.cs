using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }
    }

    public class BstTree<T>
    {
        public Node<T> Insert(Node<T> root, T val)
        {
            Node<T> curr = new Node<T>();
            curr.data = val;
            curr.next = null;
            if(root==null)
                root = curr;
            else
            {
                Node<T> temp1 = root;
                while (temp1.next != null)
                {
                    temp1 = temp1.next;
                }
                temp1.next = curr;
            }
            return root;
        }
    }

    // Linlist for String and Integer both.

    class Program
    {
        static void Main(string[] args)
        {
            Node<int> rootint = null;
            BstTree<int> numList = new BstTree<int>();
            rootint = numList.Insert(rootint, 10);
            rootint = numList.Insert(rootint, 20);
            rootint = numList.Insert(rootint, 30);
            rootint = numList.Insert(rootint, 40);

            Node<string> rootstr = null;
            BstTree<string> stringList = new BstTree<string>();
            rootstr = stringList.Insert(rootstr, "A");
            rootstr = stringList.Insert(rootstr, "B");
            rootstr = stringList.Insert(rootstr, "C");
            rootstr = stringList.Insert(rootstr, "D");
        }
    }
}
