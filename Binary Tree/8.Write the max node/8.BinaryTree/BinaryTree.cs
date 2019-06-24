using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BinaryTree
{
    public class BinaryTree
    {
        public Node root;

        public int findMax(Node node)
        {
            if (node == null)
                return 0;

            int rootData = node.Data;
            int leftChild = findMax(node.left);
            int rightChild = findMax(node.right);

            if(leftChild > rightChild)
            {
                rootData = leftChild;
            }

            if(rightChild > rootData)
            {
                rootData = rightChild;
            }
            return rootData;
        }
    }
}
