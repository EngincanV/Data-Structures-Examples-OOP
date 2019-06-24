using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST1
{
    public class BSTtoBinaryTree
    {
        public Node root;
        Sum add = new Sum();

        public virtual void addSmallerUtil(Node node, Sum sum)
        {
            if (node == null)
                return;

            addSmallerUtil(node.left, sum);

            sum.addValue = sum.addValue + node.Data;

            node.Data = sum.addValue;

            addSmallerUtil(node.right, sum);
        }

        public virtual Node addSmaller(Node node)
        {
            addSmallerUtil(node, add);
            return node;
        }

        public virtual void printInOrder(Node node)
        {
            if (node == null)
                return;
            printInOrder(node.left);
            Console.Write(node.Data + " ");
            printInOrder(node.right);
        }
    }
}
