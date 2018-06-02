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
            return root; // this is important
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
        }
    }
}