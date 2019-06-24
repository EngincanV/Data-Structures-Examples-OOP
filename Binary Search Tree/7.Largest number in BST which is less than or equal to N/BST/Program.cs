using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static Node newNode(int item)
        {
            Node newNode = new Node();
            newNode.key = item;
            newNode.left = null;
            newNode.right = null;
            return newNode;
        }

        static Node insert(Node node, int key)
        {
            if (node == null)
                return newNode(key);
            if (key < node.key)
                node.left = insert(node.left, key);
            else if (key > node.key)
                node.right = insert(node.right, key);

            return node;
        }

        public static int findMaxforN(Node root, int n)
        {
            if (root == null)
                return -1;

            if (root.key == n)
                return n;

            else if(root.key <= n)
            {
                int max = findMaxforN(root.right, n);
                if (max == -1)
                    return root.key;
                else
                    return max;
            }

            else if(root.key > n)
            {
                return findMaxforN(root.left, n);
            }
            return -1;
        }

        static void Main(string[] args)
        {
            /*
                        5
                     2     12
                   1   3  9   21
                             19  25
             */
            int n = 4;

            Node root = null;
            root = insert(root, 5);
            insert(root, 2);
            insert(root, 1);
            insert(root, 3);
            insert(root, 12);
            insert(root, 9);
            insert(root, 21);
            insert(root, 19);
            insert(root, 25);

            Console.WriteLine(findMaxforN(root, n));
            Console.ReadLine();
        }
    }
}
