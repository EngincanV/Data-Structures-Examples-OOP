using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BinaryTree_ArrayImplementation_
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeArray bt = new BinaryTreeArray(6, "A");
            bt.set_Left("B", 0);
            bt.set_Right("C", 0);
            bt.set_Left("D", 1);
            bt.set_Right("E", 1);
            bt.set_Left("F", 2);
            bt.print_Tree();

            Console.ReadLine();
        }
    }
}
