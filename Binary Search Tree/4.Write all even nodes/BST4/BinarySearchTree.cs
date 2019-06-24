using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST4
{
    public class BinarySearchTree
    {
        public Node root;

        public void inOrder(Node root)
        {
            if (root != null)
            {
                inOrder(root.left);
                Console.Write(root.Data + " ");
                inOrder(root.right);
            }
        }

        public Node Insert(Node node, int key)
        {
            if (node == null)
                return new Node(key);

            if (key < node.Data)
                node.left = Insert(node.left, key);
            else
                node.right = Insert(node.right, key);

            return node;
        }
    }
}
