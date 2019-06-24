using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinaryTree
{
    public class BinaryTree
    {
        public Node root;
        public Leaf myLevel = new Leaf();

        public bool checkUtil(Node node, int level, Leaf leafLevel)
        {
            if (node == null)
                return true;

            if (node.left == null && node.right == null)
            {
                if (leafLevel.leafLevel == 0)
                {
                    leafLevel.leafLevel = level;
                }

                return level == leafLevel.leafLevel;
            }

            return checkUtil(node.left, level + 1, leafLevel) &&
                   checkUtil(node.right, level + 1, leafLevel);
        }

        public bool check(Node node)
        {
            int level = 0;
            return checkUtil(node, level, myLevel);
        }
    }
}
