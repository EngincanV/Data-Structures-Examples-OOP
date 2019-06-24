using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap4
{
    class Program
    {
        static void Heapify(int[] arr, int size, int index)
        {
            int largest = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            if (leftChild < size && arr[leftChild] > arr[largest])
                largest = leftChild;
            if (rightChild < size && arr[rightChild] > arr[largest])
                largest = rightChild;
            if (largest != index)
            {
                int temp;
                temp = arr[index];
                arr[index] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, size, largest);
            }
        }
        static void buildHeap(int []arr, int size)
        {
            int startIndex = (size / 2) - 1;

            for(int i = startIndex; i >= 0; i--)
            {
                Heapify(arr, size, i);
            }
        }

        static void printHeap(int []arr, int size)
        {
            Console.WriteLine("Array representation of Heap is:");

            for(int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17 };
            int size = arr.Length;

            buildHeap(arr, size);
            printHeap(arr, size);

            Console.ReadLine();
        }
    }
}
