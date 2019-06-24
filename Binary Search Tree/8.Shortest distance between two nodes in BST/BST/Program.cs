using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static Node newNode(int key)
        {
            Node newNode = new Node();
            newNode.key = key;
            newNode.left = null;
            newNode.right = null;
            return newNode;
        }

        static Node Insert(Node root, int key)
        {
            if (root == null)
            {
                root = newNode(key);
            }
            else if (root.key < key)
                root.right = Insert(root.right, key);
            else if (root.key > key)
                root.left = Insert(root.left, key);
            return root;
        }

        static int distanceFromRoot(Node root, int x)
        {
            if (root.key == x)
                return 0;
            else if (root.key > x)
            {
                return 1 + distanceFromRoot(root.left, x);
            }
            else
                return 1 + distanceFromRoot(root.right, x);
        }

        static int distanceBetween(Node root, int a, int b)
        {
            if (root == null)
                return 0;

            if (root.key > a && root.key > b)
                return distanceBetween(root.left, a, b);
            if (root.key < a && root.key < b)
                return distanceBetween(root.right, a, b);

            if(root.key >= a && root.key <= b)
            {
                return distanceFromRoot(root, a) + distanceFromRoot(root, b);
            }
            return 0;
        }

        static int findDistWrapper(Node root, int a, int b)
        {
            int temp = 0;
            if(a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            return distanceBetween(root, a, b);
        }

        static void Main(string[] args)
        {
            /*
                       5
                   2      12
                1    3   9   21
                           19  25 
             */

            Node root = null;
            root = Insert(root, 5);
            Insert(root, 2);
            Insert(root, 12);
            Insert(root, 1);
            Insert(root, 3);
            Insert(root, 9);
            Insert(root, 21);
            Insert(root, 19);
            Insert(root, 25);

            int a = 1, b = 25;

            Console.WriteLine("Distance between " + a + " and " + b + " in above BST is : " + findDistWrapper(root, 1, 25));
            Console.ReadKey();
        }
    }
}
