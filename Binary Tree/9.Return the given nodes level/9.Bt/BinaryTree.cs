using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Bt
{
    public class BinaryTree
    {
        public Node root;

        public int getLevelUtil(Node node, int data, int level)
        {
            if (node == null)
                return 0;

            if (node.Data == data)
                return level;

            int downLevel = getLevelUtil(node.left, data, level + 1);
            if(downLevel != 0)
            {
                return downLevel;
            }

            downLevel = getLevelUtil(node.right, data, level + 1);
            return downLevel;
        }

        public int getLevel(Node node, int data)
        {
            return getLevelUtil(node, data, 0);
        }
    }
}
