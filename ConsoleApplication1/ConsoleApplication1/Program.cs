public class Node
{
    public int data;
    public Node Next;
    public Node(int value)
    {
        Next = null;
        data = value;
    }
}
public class Program
{

    public static Node PairWise(Node head)
    {
        var dummy = new Node(0);
        dummy.Next = head;
        head = dummy;
        while (head.Next != null && head.Next.Next != null)
        {
            var tail = head.Next;
            var nextHead = head.Next.Next;
            head.Next = nextHead;
            tail.Next = nextHead.Next;
            nextHead.Next = tail;
            head = tail;
        }
        return dummy.Next;
    }

    static void Main(string[] args)
    {
        Node head1 = new Node(1);
        head1.Next = new Node(2);
        head1.Next.Next = new Node(3);
        head1.Next.Next.Next = new Node(4);
        head1.Next.Next.Next.Next = new Node(5);
        head1.Next.Next.Next.Next.Next = new Node(6);
        Node mainHead = PairWise(head1);
        while (mainHead != null)
        {
            System.Console.Write(mainHead.data + " ");
        }
    }
}