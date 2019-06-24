using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST3
{
    public class BinaryTree
    {
        public Node root;

        public bool isBST(Node root, Node left, Node right)
        {
            if (root == null)
                return true;

            if (left != null && root.data < left.data)
                return false;

            if (right != null && root.data > right.data)
                return false;

            return isBST(root.left, left, root) && isBST(root.right, root, right);
        }
    }
}
