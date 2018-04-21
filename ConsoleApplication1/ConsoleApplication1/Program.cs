// Remove nth node from last

using System;
namespace ConsoleApplication1
{
    public class Node
    {
        public int data;
        public Node Next;
        public Node(int value)
        {
            data = value;
            Next = null;
        }
    }

    public class Program
    {
        public static Node RemoveNodeFromList(Node head, int fromLast)
        {
            Node curr = head;
            int lenOfLL = 0;
            while (curr != null)
            {
                lenOfLL++;
                curr = curr.Next;
            }
            Node temp = head;
            Node old = head;
            if (lenOfLL < fromLast || fromLast < 1)
                return null;
            else if (lenOfLL == fromLast)
            {
                head = head.Next;
            }
            else
            {
                for (int i = 0; i < lenOfLL - fromLast; i++)
                {
                    old = temp;
                    temp = temp.Next;
                }
                old.Next = temp.Next;
            }
            return head;
        }
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            n1.Next = new Node(2);
            n1.Next.Next = new Node(3);
            n1.Next.Next.Next = new Node(4);
            n1.Next.Next.Next.Next = new Node(5);
            n1.Next.Next.Next.Next.Next = new Node(6);
            Node curr = n1;
            while (curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.Next;
            }
            Node head = RemoveNodeFromList(n1, 3);
            Console.WriteLine(" ");
            curr = head;

            while (curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.Next;
            }
        }
    }
}


