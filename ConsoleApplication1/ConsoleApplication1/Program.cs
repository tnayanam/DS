// insertion and deletion is easy as we dont need to copy and shift rest of the elements just like in an array
namespace ConsoleApplication1
{
    // Node Class
    public class Node
    {
        public Node Next;
        public Node Prev;
        public int value;
        public Node(int d)
        {
            value = d;
            Next = null;
            Prev = null;
        }
    }

    // LinkList Class
    public class LinkedList
    {
        public Node head;
        public int length;

        public LinkedList()
        {
            length = 0;
            head = null;
        }

        // Add Node at last
        public void AddAtLast(int data)
        {
            Node newNode = new Node(data);
            Node curr = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = newNode;
                newNode.Prev = curr;
            }
        }

        // Show all Nodes
        public void Show()
        {
            Node curr = head;
            if (head == null)
                System.Console.WriteLine("No Node found");
            else
            {
                while (curr != null)
                {
                    System.Console.Write(curr.value + " ");
                    curr = curr.Next;
                }
                System.Console.WriteLine("---------------------------");

            }
        }

        // Show length of linkedlist
        public int Length()
        {
            Node curr = head;
            if (head == null)
            {
                length = 0;
            }
            else
            {
                while (curr != null)
                {
                    length++;
                    curr = curr.Next;
                }
            }
            return length;
        }
        // Delete a node matching number if it exists
        public void Del(int num)
        {
            Node curr = head;
            // if first node itself is to be deleted
            if (curr != null && curr.value == num)
            {
                head = head.Next;
                return;
            }
            while (curr != null && curr.value != num)
            {
                curr = curr.Next;
            }
            if (curr == null)
                return;

            if (curr.Next != null)
            {
                curr.Next.Prev = curr.Prev;

            }
            if (curr.Prev != null)
            {
                curr.Prev.Next = curr.Next;
            }
        }

        // Add node in the beginning
        public void AddInBeg(int data)
        {
            Node curr = new Node(data);
            curr.Next = head;
            if (head != null)
                head.Prev = curr;
            head = curr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            System.Console.WriteLine("Empty Linklist");
            l1.Show();
            System.Console.WriteLine("Deletion");
            l1.Del(3); // deletion from empty linlist
            System.Console.WriteLine("Length of eppty linklist");
            l1.Length();
            System.Console.WriteLine("3 added in the begiiinig");
            l1.AddInBeg(3);
            System.Console.WriteLine("5 added in the begiiinig");
            l1.AddInBeg(5);
            l1.Show();
            l1.Del(3);
            l1.AddAtLast(6);
            l1.AddAtLast(8);
            l1.AddInBeg(3);
            l1.Del(8);
            l1.Show();
            l1.Show();
            System.Console.WriteLine("Length: " + l1.Length());
        }
    }
}
