using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Bt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                            3
                           / \ 
                          2   5
                         / \
                        1   4
             */
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(3);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(4);

            int level = tree.getLevel(tree.root, 4);
            if(level == 0)
                Console.WriteLine("Node is not found");
            else
                Console.WriteLine("Level : " + level);

            Console.ReadLine();
        }
    }
}
