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
            Node start = new Node(0);
            start.Next = head;
            Node fast = head;
            Node slow = head;
            for (int i = 0; i < fromLast; i++)
            {
                fast = fast.Next;
            }
            if (fast == null)
            {
                head = head.Next;
            }
            else
            {
                while (fast.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
                slow.Next = slow.Next.Next;
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
            n1.Next.Next.Next.Next.Next.Next = new Node(7);
            n1.Next.Next.Next.Next.Next.Next.Next = new Node(8);
            Node curr = n1;
            while (curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.Next;
            }
            Node head = RemoveNodeFromList(n1, 8);
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


