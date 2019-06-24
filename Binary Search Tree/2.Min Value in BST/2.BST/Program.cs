using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node root = null;
            root = tree.Insert(root, 4);
            tree.Insert(root, 2);
            tree.Insert(root, 1);
            tree.Insert(root, 3);
            tree.Insert(root, 6);
            tree.Insert(root, 5);

            Console.WriteLine("Minimum value of BST is : " + tree.minValue(root));
            Console.ReadLine();
        }
    }
}
