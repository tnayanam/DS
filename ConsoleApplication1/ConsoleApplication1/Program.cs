using System;
using System.Collections.Generic;

// Inorder Traversal of BST is always in increasing order

namespace MainSolution
{
    // we always need the address of the Root Node come what may!!!!!
    public class BstNode
    {
        public int data { get; set; }
        public BstNode left { get; set; }
        public BstNode right { get; set; }
        public BstNode(int value)
        {
            data = value;
        }
    }

    public class BstTree
    {
        // For BST
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

        // For BST
        public int FindMax(BstNode root)
        {
            if (root == null)
                return -1;
            if (root.right == null)
                return root.data;
            return FindMax(root.right);
        }

        // For BST
        public BstNode FindMinNode(BstNode root)
        {
            if (root == null)
                return null;
            if (root.left == null)
                return root;
            return FindMinNode(root.left);
        }

        // For BST
        public int FindMin(BstNode root)
        {
            if (root == null)
                return -1;
            if (root.left == null)
                return root.data;
            return FindMin(root.left);
        }

        //This is called Depth First Traversal
        // For Binary Tree
        public void PreOrder(BstNode root)
        {
            if (root == null)
                return;
            System.Console.Write(root.data + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        // This is called Depth First Traversal
        // For Binary Tree
        public void InOrder(BstNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            System.Console.Write(root.data + " ");
            InOrder(root.right);
        }

        // This is called Depth First Traversal
        // For Binary Tree
        public void PostOrder(BstNode root)
        {
            if (root == null)
                return;
            PostOrder(root.left);
            PostOrder(root.right);
            System.Console.Write(root.data + " ");
        }

        // For BST
        public bool Contains(BstNode root, int data)
        {
            if (root == null)
                return false;
            if (data > root.data)
                return Contains(root.right, data);
            else if (data < root.data)
                return Contains(root.left, data);
            else
                return true;

        }

        // For BST
        // Deletion of node and then making it BST again
        public BstNode Delete(BstNode root, int numToDelete)
        {
            if (root == null)
                return null;
            if (numToDelete > root.data)
                root.right = Delete(root.right, numToDelete);
            else if (numToDelete < root.data)
                root.left = Delete(root.left, numToDelete);
            else // number is found now delete it
            {
                // case 1: // No Child
                if (root.right == null && root.left == null)
                {
                    root = null;
                }
                // only left child
                else if (root.right == null)
                {
                    BstNode temp = root;
                    root = root.left;
                    temp = null;
                }
                // only right child
                else if (root.left == null)
                {
                    BstNode temp = root;
                    root = root.right;
                    temp = null;
                }
                else
                {
                    BstNode temp = FindMinNode(root.right);
                    root.data = temp.data;
                    root.right = Delete(root.right, temp.data);
                }
            }
            return root;
        }

        // For Binary Tree
        public int GetHeight(BstNode root)
        {
            if (root == null)
                return -1; // height of empty tree
            var leftHeight = GetHeight(root.left);
            var rightHeight = GetHeight(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        // This is called Breadth First Traversal
        // For Binary Tree
        public void LevelOrderTraversal(BstNode root)
        {
            Queue<BstNode> q1 = new Queue<BstNode>();

            if (root == null)
                return;
            q1.Enqueue(root);
            while (q1.Count != 0)
            {
                BstNode node = q1.Peek();
                System.Console.Write(node.data + " ");
                if (node.left != null) q1.Enqueue(node.left);
                if (node.right != null) q1.Enqueue(node.right);
                q1.Dequeue();
            }
        }

        public bool IsBinarySearchTree(BstNode root)
        {
            return CheckBST(root, Int32.MinValue, Int32.MaxValue);
        }

        public bool CheckBST(BstNode root, int minValue, int maxValue)
        {
            if (root == null)
                return true;
            if (root.data > minValue && root.data < maxValue && CheckBST(root.left, minValue, root.data) && CheckBST(root.right, root.data, maxValue))
                return true;
            else
                return false;
        }

        // For Binary Tree
        public void traverseSpiral(BstNode root)
        {
            Stack<BstNode> st1 = new Stack<BstNode>();
            Stack<BstNode> st2 = new Stack<BstNode>();
            st1.Push(root);

            while (st1.Count > 0 || st2.Count > 0)
            {
                while (st1.Count > 0)
                {
                    BstNode n = st1.Pop();
                    Console.Write(n.data + " ");
                    // IMP: order of insertion should be different in 2 stacks
                    if (n.left != null) st2.Push(n.left);
                    if (n.right != null) st2.Push(n.right);

                }
                while (st2.Count > 0)
                {
                    BstNode n = st2.Pop();
                    Console.Write(n.data + " ");
                    if (n.right != null) st1.Push(n.right);
                    if (n.left != null) st1.Push(n.left);
                }
            }
        }

        // For Binary Tree
        public void ZigZagTraversal(BstNode root)
        {
            if (root == null)
                return;
            Stack<BstNode> Curr = new Stack<BstNode>();
            Stack<BstNode> Nxt = new Stack<BstNode>();
            bool leftToRight = true;
            Curr.Push(root);
            while (Curr.Count != 0)
            {
                BstNode b1 = Curr.Peek();
                Curr.Pop();
                if (b1 != null)
                {
                    Console.Write(b1.data + " ");
                    if (leftToRight)
                    {
                        if (b1.left != null)
                            Nxt.Push(b1.left);
                        if (b1.right != null)
                            Nxt.Push(b1.right);
                    }
                    else
                    {
                        if (b1.right != null)
                            Nxt.Push(b1.right);
                        if (b1.left != null)
                            Nxt.Push(b1.left);
                    }
                }
                if (Curr.Count == 0)
                {
                    leftToRight = !leftToRight;
                    Curr = Nxt;
                    Nxt = new Stack<BstNode>();
                }
            }
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
            root = bstTree.Insert(root, 3);
            root = bstTree.Insert(root, 2);
            root = bstTree.Insert(root, 13);
            root = bstTree.Insert(root, 23);
            root = bstTree.Insert(root, 9);
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
            System.Console.WriteLine();
            System.Console.WriteLine(bstTree.Contains(root, 15));
            System.Console.WriteLine();
            bstTree.LevelOrderTraversal(root);
            System.Console.WriteLine();
            Console.WriteLine(bstTree.IsBinarySearchTree(root));
            System.Console.WriteLine();
            bstTree.ZigZagTraversal(root);
            System.Console.WriteLine();
            bstTree.traverseSpiral(root);
            System.Console.WriteLine();
            Console.WriteLine("Height is: " + bstTree.GetHeight(root));
            System.Console.WriteLine();
            bstTree.Delete(root, 2); // no child
            System.Console.WriteLine("InOrder - removed 2");
            bstTree.InOrder(root);
            bstTree.Delete(root, 23); // no child
            System.Console.WriteLine("InOrder - removed 23");
            bstTree.InOrder(root);
            bstTree.Delete(root, 12); // both child
            System.Console.WriteLine("InOrder - removed 12");
            bstTree.InOrder(root);
            bstTree.Delete(root, 15); // left child
            System.Console.WriteLine("InOrder - removed 15");
            bstTree.InOrder(root);
            bstTree.Delete(root, 7); // both child
            System.Console.WriteLine("InOrder - removed 7");
            bstTree.InOrder(root);
            bstTree.Delete(root, 10); // both child and root
            System.Console.WriteLine("InOrder - removed 10");
            bstTree.InOrder(root);
        }
    }
}