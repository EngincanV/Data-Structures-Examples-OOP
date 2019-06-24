using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BinarySearchTree
{
    class Program
    {
        public static Node addNode(int data)
        {
            Node temp = new Node();
            temp.Data = data;
            temp.left = null;
            temp.right = null;
            return temp;
        }

        static int sum = 0;

        public static int rightLeafSum(Node root)
        {
            if (root == null)
                return 0;

            if(root.right != null)
            {
                if (root.right.left == null && root.right.right == null)
                    sum += root.right.Data;
            }
            rightLeafSum(root.left);
            rightLeafSum(root.right);

            return sum;
        }

        static void Main(string[] args)
        {
            /*
                            1
                           / \
                          2   3
                         / \   \ 
                        4   5   8
                         \     / \
                          2   6   7
             */

            Node root = addNode(1);
            root.left = addNode(2);
            root.left.left = addNode(4);
            root.left.right = addNode(5);
            root.left.left.right = addNode(2);
            root.right = addNode(3);
            root.right.right = addNode(8);
            root.right.right.left = addNode(6);
            root.right.right.right = addNode(7);

            int sum = rightLeafSum(root);
            Console.WriteLine("Sum of right leaf nodes are : " + sum);

            Console.ReadLine();

        }
    }
}
