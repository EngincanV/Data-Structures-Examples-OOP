using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap6
{
    class Program
    {
        public static int findMinElement(int[] arr, int size)
        {
            Heap h = new Heap(size);
            for(int i = 0; i <size; i++)
            {
                h.Insert(arr[i]);
            }
            int minElement = arr[0];
            for(int i = 0; i < h.heapArray.Length; i++)
            {
                minElement = Math.Min(minElement, h.heapArray[i].Key);
            }
            return minElement;
        }

        public static int findMaxElement(int[] arr, int size)
        {
            Heap h = new Heap(size);
            for (int i = 0; i < size; i++)
            {
                h.Insert(arr[i]);
            }
            int maxElement = arr[0];
            for (int i = 0; i < h.heapArray.Length; i++)
            {
                maxElement = Math.Max(maxElement, h.heapArray[i].Key);
            }
            return maxElement;
        }

        static void Main(string[] args)
        {
            int[] heap = { 10, 25, 22, 45, 50, 30, 35, 63, 65, 81, 8 };

            Console.WriteLine("Min : " + findMinElement(heap, heap.Length).ToString());
            Console.WriteLine("Max : " + findMaxElement(heap, heap.Length).ToString());

            Console.ReadLine();
        }
    }
}
