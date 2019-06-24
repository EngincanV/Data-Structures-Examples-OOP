using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST4
{
    class Program
    {
        static void evenNode(Node root)
        {
            if(root != null)
            {
                evenNode(root.left);
                if(root.Data % 2 == 0)
                    Console.Write(root.Data + " ");
                evenNode(root.right);
            }
        }

        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node root = null;

            root = tree.Insert(root, 5);
            tree.Insert(root, 3);
            tree.Insert(root, 2);
            tree.Insert(root, 4);
            tree.Insert(root, 7);
            tree.Insert(root, 6);
            tree.Insert(root, 8);

            evenNode(root);

            Console.ReadLine();
        }
    }
}
