using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            Node root = new Node(3);
            root.left = new Node(2);
            root.right = new Node(5);
            root.left.left = new Node(1);
            root.left.right = new Node(4);

            if(bt.isBST(root, null, null))
                Console.WriteLine("is BST");
            else
                Console.WriteLine("Not a BST");

            Console.ReadLine();

        }
    }

}
