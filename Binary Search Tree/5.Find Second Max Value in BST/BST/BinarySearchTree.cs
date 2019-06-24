using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BinarySearchTree
    {
        public Node root;

        public void Insert(int data)
        {
            root = insertRec(root, data);
        }
        private Node insertRec(Node current, int data)
        {
            if(current == null)
            {
                current = new Node(data);
                return current;
            }

            if (data < current.data)
            {
                current.left = insertRec(current.left, data);
            }
            else
            {
                current.right = insertRec(current.right, data);
            }
            return current;
        }

        public Node findSecondLargest(Node root)
        {
            Node temp = root;

            if(temp.right != null)
            {
                if(temp.right.right == null)
                {
                    temp = root;
                }
                while (temp.right.right != null)
                {
                    temp = temp.right;
                }

                if (temp.right.left != null && temp.right.left.right == null)
                    temp = temp.right.left;

                if (temp.right != null && temp.right.left != null && temp.right.left.right != null)
                {
                    temp = temp.right.left.right;
                    while (temp.right != null)
                        temp = temp.right;
                }
            }

            else
            {
                if (temp.left.right == null)
                    temp = temp.left;
                else
                {
                    temp = temp.left;
                    while(temp.right != null)
                    {
                        temp = temp.right;
                    }
                }
            }

            
            return temp;
        }
    }
}
