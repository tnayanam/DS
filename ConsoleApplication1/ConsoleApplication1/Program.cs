using System;
using System.Collections.Generic;

// Inorder Traversal of BST is always in increasing order

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
        public int FindMin(BstNode root)
        {
            if (root == null)
                return -1;
            if (root.left == null)
                return root.data;
            return FindMin(root.left);
        }

        // For Binary Tree
        public void PreOrder(BstNode root)
        {
            if (root == null)
                return;
            System.Console.Write(root.data + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        // For Binary Tree
        public void InOrder(BstNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            System.Console.Write(root.data + " ");
            InOrder(root.right);
        }

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
            System.Console.WriteLine();
            System.Console.WriteLine(bstTree.Contains(root, 15));
            System.Console.WriteLine();
            bstTree.LevelOrderTraversal(root);
            System.Console.WriteLine();
            Console.WriteLine(bstTree.IsBinarySearchTree(root));
        }
    }
}