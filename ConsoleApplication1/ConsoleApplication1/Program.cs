namespace MainSolution
{
    // we always need the address of the Root Node come what may!!!!!
    public class BstNode
    {
        public int data { get; }
        public BstNode left { get; set; }
        public BstNode right { get; set; }
        public BstNode(int value)
        {
            data = value;
        }
    }

    public class BstTree
    {
        public BstNode Insert(BstNode root, int data)
        {
            if (root == null)
            {
                root = new BstNode(data);
                root.left = null;
                root.right = null;
            }
            else if (data > root.data)
            {
                root.right = Insert(root.right, data);
            }
            else
            {
                root.left = Insert(root.left, data);
            }
            return root;
        }

        public int FindMax(BstNode root)
        {
            if (root == null)
                return -1;
            if (root.right == null)
                return root.data;
           return FindMax(root.right);
        }

        public int FindMin(BstNode root)
        {
            if (root == null)
                return -1;
            if (root.left == null)
                return root.data;
            return FindMin(root.left);
        }

        public void PreOrder(BstNode root)
        {
            if (root == null)
                return;
            System.Console.Write(root.data + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void InOrder(BstNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            System.Console.Write(root.data + " ");
            InOrder(root.right);
        }

        public void PostOrder(BstNode root)
        {
            if (root == null)
                return;
            PostOrder(root.left);
            PostOrder(root.right);
            System.Console.Write(root.data + " ");
        }
    }

    class Program
    {
        public static void Main()
        {
            BstNode root = null;
            BstTree bstTree = new BstTree();
            root = bstTree.Insert(root, 10);
            root = bstTree.Insert(root, 12);
            root = bstTree.Insert(root, 7);
            root = bstTree.Insert(root, 8);
            root = bstTree.Insert(root, 15);
            root = bstTree.Insert(root, 11);
            root = bstTree.Insert(root, 6);
            System.Console.WriteLine("PostOrder");
            bstTree.PostOrder(root);
            System.Console.WriteLine();
            System.Console.WriteLine("PreOrder");
            bstTree.PreOrder(root);
            System.Console.WriteLine();
            System.Console.WriteLine("InOrder");
            bstTree.InOrder(root);
            System.Console.WriteLine();
            System.Console.WriteLine("Max element is: " + bstTree.FindMax(root));
            System.Console.WriteLine();
            System.Console.WriteLine("Min element is: " + bstTree.FindMin(root));
        }
    }
}