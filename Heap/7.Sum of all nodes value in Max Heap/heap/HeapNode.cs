using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heap
{
    public class HeapNode
    {
        public int Key { get; set; }

        public HeapNode(int key)
        {
            this.Key = key;
        }
    }
}
