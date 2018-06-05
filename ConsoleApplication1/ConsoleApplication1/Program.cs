public class Node
{
    public int data { get; set; }
    public Node next { get; set; }
}

public class LL
{

    public Node Reverse(Node root)
    {
        Node prev = null;
        Node next = null;
        Node curr = root;
        while(curr!=null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        root = prev;
        return root;
    }

    public Node Insert(Node root, int num)
    {
        Node temp = new Node();
        temp.data = num;
        temp.next = null;
        if (root == null)
        {
            root = temp;
        }
        else
        {
            Node temp1 = root;
            while (temp1.next != null)
            {
                temp1 = temp1.next;
            }
            temp1.next = temp;
        }
        return root;
    }
}

public class Program
{
    public static void Main()
    {
        Node root = null;
        LL l1 = new LL();
        root = l1.Insert(root, 1);
        root = l1.Insert(root, 2);
        root = l1.Insert(root, 3);
        root = l1.Insert(root, 4);
        root = l1.Insert(root, 5);
        root = l1.Insert(root, 6);
        root = l1.Insert(root, 7);
        root = l1.Insert(root, 8);
        root = l1.Reverse(root);
    }
}
