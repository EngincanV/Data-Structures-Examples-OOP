using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinarySearchTree
{
    class Program
    {
        static bool isNodeExists(Node node, int key)
        {
            if (node == null)
                return false;

            if (node.Data == key)
                return true;

            bool forLeftTree = isNodeExists(node.left, key);

            bool forRightTree = isNodeExists(node.right, key);

            return (forLeftTree || forRightTree);
        }

        static void Main(string[] args)
        {
            /*
                              0
                           /     \
                          1       2
                         / \     / \
                        3   4   5   6
                       /   / \
                      7    8  9
             */
            Node root = new Node(0);
            root.left = new Node(1);
            root.left.left = new Node(3);
            root.left.left.left = new Node(7);
            root.left.right = new Node(4);
            root.left.right.left = new Node(8);
            root.left.right.right = new Node(9);
            root.right = new Node(2);
            root.right.left = new Node(5);
            root.right.right = new Node(6);

            int key = 4;

            if(isNodeExists(root, key))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadLine();
        }
    }
}
