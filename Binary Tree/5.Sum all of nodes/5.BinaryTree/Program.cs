using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BinaryTree
{
    class Program
    {
        static Node newNode(int key)
        {
            Node node = new Node();
            node.Data = key;
            node.left = null;
            node.right = null;
            return node;
        }

        public static int addBT(Node root)
        {
            if (root == null)
                return 0;
            int sum = root.Data;
            sum += addBT(root.left) + addBT(root.right);
            return sum;
        }

        static void Main(string[] args)
        {
            Node root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.left = newNode(4);
            root.left.right = newNode(5);
            root.right.left = newNode(6);
            root.right.right = newNode(7);
            root.right.left.right = newNode(8);

            int sum = addBT(root);
            Console.WriteLine("Sum of all the element is : " + sum);
            Console.ReadLine();
        }
    }
}
