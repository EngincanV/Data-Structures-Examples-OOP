using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapQuestion_1
{
    public class Is_BinaryTree_MaxHeap
    {
        public int countNodes(Node root)
        {
            if (root == null)
                return 0;
            return (1 + countNodes(root.left) + countNodes(root.right));
        }

        private bool isCompleteUtil(Node root, int index, int number_nodes)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            if (root == null)
                return true;

            if (index >= number_nodes)
                return false;

            return isCompleteUtil(root.left, leftChild, number_nodes) &&
                   isCompleteUtil(root.right, rightChild, number_nodes);
        }

        private bool isHeapUtil(Node root)
        {
            if (root.left == null && root.right == null)
                return true;

            if(root.right == null)
            {
                return root.Key >= root.left.Key;
            }
            else
            {
                if (root.Key >= root.left.Key && root.Key > root.right.Key)
                    return isHeapUtil(root.left) && isHeapUtil(root.right);
                else
                    return false;
            }
        }

        public bool isHeap(Node root)
        {
            if (root == null)
                return true;
            
            int node_count = countNodes(root);

            if (isCompleteUtil(root, 0, node_count) && isHeapUtil(root))
                return true;
            else
                return false;
        }
    }
}
