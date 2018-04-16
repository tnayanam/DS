namespace ConsoleApplication1
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        public static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode head = new ListNode(0);
            ListNode curr = head;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);

            }

            head = head.next;
            return head;
        }
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode res = addTwoNumbers(l1, l2);
            while (res != null)
            {
                System.Console.Write(res.val + " ");
                res = res.next;
            }
        }
    }
}
