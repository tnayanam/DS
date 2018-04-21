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
    public class Main1
    {
        public static Node Sort(Node head1, Node head2)
        {
            Node sortedHead = new Node(0);
            Node n3 = sortedHead;
            Node start1 = head1;
            Node start2 = head2;
            while (start1 != null && start2 != null)
            {
                if (start1.data > start2.data)
                {
                    n3.Next = new Node(start2.data);
                    start2 = start2.Next;
                }
                else
                {
                    n3.Next = new Node(start1.data);
                    start1 = start1.Next;
                }
                n3 = n3.Next;
            }

            while (start1 != null)
            {
                n3.Next = new Node(start1.data);
                n3 = n3.Next;
                start1 = start1.Next;
            }

            while (start2 != null)
            {
                n3.Next = new Node(start2.data);
                n3 = n3.Next;
                start2 = start2.Next;
            }
            return sortedHead.Next;
        }

        static void Main(string[] args)
        {
            Node head1 = new Node(1);
            head1.Next = new Node(5);
            head1.Next.Next = new Node(6);
            Node head2 = new Node(0);
            head2.Next = new Node(7);
            //head2.Next.Next = new Node(8);
            Node start = Sort(head1, head2);
            while (start != null)
            {
                System.Console.Write(start.data + " ");
                start = start.Next;
            }
        }
    }
}


