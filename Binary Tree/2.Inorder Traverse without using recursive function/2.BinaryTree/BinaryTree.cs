using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryTree
{
    public class BinaryTree
    {
        public Node root;

        public void TraversalWithoutRecursion(Node root)
        {
            Node current = root;
            Node prevCurrent = null;

            if (root == null)
                return;

            while(current != null)
            {
                if(current.left == null)
                {
                    Console.Write(current.data + " ");
                    current = current.right;
                }

                else
                {
                    prevCurrent = current.left;
                    while (prevCurrent.right != null && prevCurrent.right != current)
                        prevCurrent = prevCurrent.right; 

                    if(prevCurrent.right == null)
                    {
                        prevCurrent.right = current;
                        current = current.left;
                    }

                    else
                    {
                        prevCurrent.right = null;
                        Console.Write(current.data + " ");
                        current = current.right;
                    }/* End of if condition pre->right == NULL */
                }/* End of if condition current->left == NULL*/
            }

        }
    }
}
