using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }
    }

    public class BstTree<T>
    {
        public Node<T> Insert(Node<T> root, T val)
        {
            Node<T> curr = new Node<T>();
            curr.data = val;
            curr.next = null;
            if(root==null)
                root = curr;
            else
            {
                Node<T> temp1 = root;
                while (temp1.next != null)
                {
                    temp1 = temp1.next;
                }
                temp1.next = curr;
            }
            return root;
        }
    }

    // Linlist for String and Integer both.

    class Program
    {
        static void Main(string[] args)
        {
            Node<int> rootint = null;
            BstTree<int> numList = new BstTree<int>();
            rootint = numList.Insert(rootint, 10);
            rootint = numList.Insert(rootint, 20);
            rootint = numList.Insert(rootint, 30);
            rootint = numList.Insert(rootint, 40);

            Node<string> rootstr = null;
            BstTree<string> stringList = new BstTree<string>();
            rootstr = stringList.Insert(rootstr, "A");
            rootstr = stringList.Insert(rootstr, "B");
            rootstr = stringList.Insert(rootstr, "C");
            rootstr = stringList.Insert(rootstr, "D");

            // Benefits of Generics
            /*
             * Limitation of not having generics was suppose we have an arraylist which allows value and reference type both
             * 
             * 
             */
            ArrayList a1 = new ArrayList();
            a1.Add("hello");
            ArrayList a2 = new ArrayList();
            a2.Add(2);
            // Problem no 1: But this convenience comes at a cost . Now so far so good but the problem is now how array list works is it upcasts everything to Object. If items are value
            // types then they need to be boxed into Object when added to arraylist. and it needs to be unboxed when retrieved. both boxing and unboxing (++) is time taking operation
            // Problem no 2: it does not provide compile type checking
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            // Add an integer to the list.
            list.Add(3);
            // Add a string to the list. This will compile, but may cause an error later.
            list.Add("It is raining in Redmond.");
            int t = 0;
            // This causes an InvalidCastException to be returned.
            foreach (int x in list)
            {
                t += x;
            }
            // Although perfectly acceptable and sometimes intentional if you are creating a heterogeneous collection, combining strings and ints in a single ArrayList is more likely to be a programming error, and this error will not be detected until runtime.
            // Now with new .Net we have as below
            // The .NET Framework 2.0 way to create a list
            List<int> list1 = new List<int>();
            // No boxing, no casting:
            list1.Add(3);
            // Compile-time error:
            // list1.Add("It is raining in Redmond.");
            // Also now no boxing and unboxing is required. in case of integer values. (++)
        }
    }
}


