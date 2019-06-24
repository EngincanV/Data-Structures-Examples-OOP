using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heap
{
    class Program
    {
        public static int sumNodes(int size)
        {
            Heap h = new Heap(size);
            int sumOfNodes = 0;
            for (int i = 0; i < size; i++)
            {
                h.Insert(i);
            }
            for (int i = 0; i < size; i++)
                sumOfNodes += h.heapArray[i].Key;
            
            return sumOfNodes;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Total : " + sumNodes(11));
            Console.ReadLine();
        }
    }
}
