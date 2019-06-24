using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BinaryTree
{
    class Program
    {
        static int count = 0;

        static Node newNode(int data)
        {
            Node root = new Node();
            root.Data = data;
            root.left = null;
            root.right = null;
            return root;
        }

        static void NthInorder(Node root, int n)
        {
            if (root == null)
                return;

            if(count <= n)
            {
                NthInorder(root.left, n);
                count++;

                if(count == n)
                    Console.Write(root.Data + " ");
                
                NthInorder(root.right, n);
            }
        }

        static void Main(string[] args)
        {
            /*
                        10
                       /  \
                     20    30
                    /  \
                  40    50
             * InOrder --> 40 20 50 10 30
             */
            Node root = newNode(10);
            root.left = newNode(20);
            root.right = newNode(30);
            root.left.left = newNode(40);
            root.left.right = newNode(50);

            int n = 4;
            NthInorder(root, n);

            Console.ReadLine();
        }
    }
}
