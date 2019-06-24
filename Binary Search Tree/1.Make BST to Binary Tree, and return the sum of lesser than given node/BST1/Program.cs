using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST1
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTtoBinaryTree tree = new BSTtoBinaryTree();
            tree.root = new Node(9);
            tree.root.left = new Node(6);
            tree.root.right = new Node(15);

            Console.WriteLine("Original BST");
            tree.printInOrder(tree.root);
            Node node = tree.addSmaller(tree.root);
            Console.WriteLine("");
            Console.WriteLine("BST To binary tree");
            tree.printInOrder(node);

            Console.ReadLine();
        }
    }
}
