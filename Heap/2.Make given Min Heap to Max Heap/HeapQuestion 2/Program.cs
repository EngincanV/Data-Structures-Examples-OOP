using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapQuestion_2
{
    class Program
    {
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; ++i)
                Console.Write(arr[i] + " ");
        }

        static void MaxHeapify(int []arr, int index , int size)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2; 

            int largest = index; 

            if (leftChild < size && arr[leftChild] > arr[index])
                largest = leftChild; 
            if (rightChild < size && arr[rightChild] > arr[largest])
                largest = rightChild; 

            if(largest != index)
            {
                int temp = arr[index];
                arr[index] = arr[largest]; 
                arr[largest] = temp; 
                MaxHeapify(arr, largest, size);
            }
        }

        static void convertMaxHeap(int []arr, int size)
        {
            for (int i = (size - 2) / 2; i >= 0; --i)
                MaxHeapify(arr, i, size);
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 9, 6, 8, 20, 10, 12, 18, 9 };
            int size = arr.Length;

            Console.WriteLine("Min heap : ");
            printArray(arr, size);

            convertMaxHeap(arr, size);
            Console.WriteLine();

            Console.WriteLine("Max heap : ");
            printArray(arr, size);

            Console.ReadLine();
        }
    }
}
