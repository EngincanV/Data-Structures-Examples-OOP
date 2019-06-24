using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap6
{
    public class Heap
    {
        public HeapNode[] heapArray;
        private int currentSize;
        private int maxSize;

        public Heap(int maxSize)
        {
            this.maxSize = maxSize;
            this.currentSize = 0;
            this.heapArray = new HeapNode[maxSize];
        }

        public bool Insert(int value)
        {
            if (currentSize == maxSize)
                return false;
            HeapNode newNode = new HeapNode(value);
            heapArray[currentSize] = newNode;
            MoveToUp(currentSize);
            currentSize++;
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;

            HeapNode bottom = heapArray[currentSize];

            while(index > 0 && heapArray[parent].Key < bottom.Key)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
    }
}
