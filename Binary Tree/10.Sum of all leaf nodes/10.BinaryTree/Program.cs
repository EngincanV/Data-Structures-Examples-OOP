using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BinaryTree
{
    class Program
    {
        public static int sum = 0;

        public static int leafSum(Node root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                sum += root.Data;

            leafSum(root.left);
            leafSum(root.right);
            return sum;
        }

        static void Main(string[] args)
        {
            /*
                             1
                           /   \
                          2     3
                         / \   / \
                        4   5 6   7
                               \
                                8
             */
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right = new Node(3);
            root.right.right = new Node(7);
            root.right.left = new Node(6);
            root.right.left.right = new Node(8);

            sum = leafSum(root);
            Console.WriteLine(sum);

            Console.ReadLine();

        }
    }
}
