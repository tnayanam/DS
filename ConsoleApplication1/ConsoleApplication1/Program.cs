using System.Collections.Generic;

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
    public static Node Merge(List<Node> l1)
    {
        if (l1.Count == 1)
            return l1[0];
        int right = l1.Count - 1;
        while (right != 0)
        {
            l1[0] = MergeLL(l1[0], l1[right]);
            right--;
        }
        return l1[0];
    }

    public static Node MergeLL(Node tmphead1, Node tmphead2)
    {
        Node dummy = new Node(0);
        Node mainHead = dummy;
        while (tmphead1 != null && tmphead2 != null)
        {
            if (tmphead1.data > tmphead2.data)
            {
                dummy.Next = tmphead2;
                dummy = dummy.Next;
                tmphead2 = tmphead2.Next;
            }
            else if (tmphead1.data < tmphead2.data)
            {
                dummy.Next = tmphead1;
                dummy = dummy.Next;
                tmphead1 = tmphead1.Next;
            }
        }
        while (tmphead1 != null)
        {
            dummy.Next = tmphead1.Next;
            dummy = dummy.Next;
            tmphead1 = tmphead1.Next;
        }
        while (tmphead2 != null)
        {
            dummy.Next = tmphead2.Next;
            dummy = dummy.Next;
            tmphead2 = tmphead2.Next;
        }
        return mainHead.Next;
    }

    static void Main(string[] args)
    {
        Node head1 = new Node(2);
        head1.Next = new Node(3);
        head1.Next.Next = new Node(5);
        head1.Next.Next = new Node(8);
        head1.Next.Next.Next = new Node(9);

        Node head2 = new Node(1);
        head2.Next = new Node(4);
        head2.Next.Next = new Node(6);
        head2.Next.Next.Next = new Node(11);

        Node head3 = new Node(7);
        head3.Next = new Node(10);
        head3.Next.Next = new Node(12);
        head3.Next.Next = new Node(13);
        head3.Next.Next.Next = new Node(14);

        List<Node> l1 = new List<Node>();
        l1.Add(head1);
        l1.Add(head2);
        l1.Add(head3);
        Node finalHead = Merge(l1);
        while (finalHead != null)
        {
            System.Console.Write(finalHead.data + " ");
            finalHead = finalHead.Next;
        }
    }
}