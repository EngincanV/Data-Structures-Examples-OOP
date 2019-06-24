using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapQuestion_1
{
    class Program
    {
        static public Node Dugumler()
        {
            Node root = new Node(10);
            root.left = new Node(9);
            root.right = new Node(8);
            root.left.left = new Node(7);
            root.left.right = new Node(6);
            root.right.left = new Node(5);
            root.right.right = new Node(4);
            root.left.left.left = new Node(3);
            root.left.left.right = new Node(2);
            root.left.right.left = new Node(1);
            return root;
        }
        static void Main(string[] args)
        {
            Is_BinaryTree_MaxHeap bt = new Is_BinaryTree_MaxHeap();

            if (bt.isHeap(Dugumler()))
                Console.WriteLine("Given binary tree is heap.");
            else
                Console.WriteLine("Given binary tree is not heap");

            Console.ReadLine();

        }
    }
}
