using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapQuestion_1
{
    public class Node
    {
        public int Key;
        public Node left;
        public Node right;

        public Node(int key)
        {
            this.Key = key;
            this.left = null;
            this.right = null;
        }
    }
}
