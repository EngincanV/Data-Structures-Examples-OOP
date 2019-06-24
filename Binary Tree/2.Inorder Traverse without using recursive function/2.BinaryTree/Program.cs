using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        1
                     2     3
                   4   5
             */
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            tree.TraversalWithoutRecursion(tree.root);
            Console.ReadLine();
        }
    }
}
