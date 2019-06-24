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

        static void inOrder(Node root)
        {
            if(root != null)
            {
                inOrder(root.left);
                Console.Write(root.key + " ");
                inOrder(root.right);
            }
        }

        static Node Insert(Node node, int key)
        {
            if (node == null)
                return newNode(key);

            if (key < node.key)
                node.left = Insert(node.left, key);
            else
                node.right = Insert(node.right, key);

            return node;
        }

        static void oddNode(Node root)
        {
            if(root != null)
            {
                oddNode(root.left);

                if(root.key % 2 == 1)
                    Console.Write(root.key + " ");

                oddNode(root.right);
            }
        }

        static void Main(string[] args)
        {
            /* Let us create following BST  
                    5  
                   / \  
                 3     7  
                / \   / \  
                2 4   6 8 
            */
            Node root = null;
            root = Insert(root, 5);
            root = Insert(root, 3);
            root = Insert(root, 2);
            root = Insert(root, 4);
            root = Insert(root, 7);
            root = Insert(root, 6);
            root = Insert(root, 8);

            oddNode(root);
            Console.ReadLine();
        }
    }
}
