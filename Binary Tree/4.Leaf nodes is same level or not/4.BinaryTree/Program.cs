using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        12
                      5    
                    3   9
                  1    1
             */
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(12);
            tree.root.left = new Node(5);
            tree.root.left.left = new Node(3);
            tree.root.left.right = new Node(9);
            tree.root.left.left.left = new Node(1);
            tree.root.left.right.left = new Node(1);

            if(tree.check(tree.root))
                Console.WriteLine("Yaprak dugumler aynı seviyede");
            else
                Console.WriteLine("Yaprak dugumler aynı seviyede degil");
        }
    }
}
