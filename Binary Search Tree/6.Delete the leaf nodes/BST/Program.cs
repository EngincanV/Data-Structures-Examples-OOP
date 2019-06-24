using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static Node newNode(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.left = null;
            newNode.right = null;
            return newNode;
        }

        static Node Insert(Node root, int data)
        {
            if (root == null)
                return newNode(data);
            if (data < root.Data)
                root.left = Insert(root.left, data);
            else if (data > root.Data)
                root.right = Insert(root.right, data);
            return root;
        }

        static void inOrder(Node root)
        {
            if(root != null)
            {
                inOrder(root.left);
                Console.Write(root.Data + " ");
                inOrder(root.right);
            }
        }

        static Node leafDelete(Node root)
        {
            if (root.left == null && root.right == null)
                return null;

            root.left = leafDelete(root.left);
            root.right = leafDelete(root.right);

            return root;
        }

        static void Main(string[] args)
        {
            /*              20
                       10         30
                    5     15   25    35
            */
            Node root = null;
            root = Insert(root, 20);
            Insert(root, 10);
            Insert(root, 5);
            Insert(root, 15);
            Insert(root, 30);
            Insert(root, 25);
            Insert(root, 35);

            inOrder(root);
            Console.WriteLine();
            leafDelete(root);
            Console.WriteLine("In order after deleting the leaf nodes : ");
            inOrder(root);

            Console.ReadLine();
            
        }
    }
}
