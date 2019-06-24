using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BST
{
    public class BinarySearchTree
    {
        public Node head;

        public Node Insert(Node node, int data)
        {
            if (node == null)
                return new Node(data);

            else
            {
                if (data <= node.Data)
                {
                    node.left = Insert(node.left, data);
                }
                else
                    node.right = Insert(node.right, data);
            }
            return node;
        }

        public int minValue(Node node)
        {
            Node current = node;
            while (current.left != null)
                current = current.left;
            return current.Data;
        }
    }
}
