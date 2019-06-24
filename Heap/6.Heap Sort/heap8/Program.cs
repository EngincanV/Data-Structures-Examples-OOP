using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heap8
{
    class Program
    {
        static void Heapify(int[] arr, int size, int index)
        {
            int smallest = index;
            int leftChild = (2 * index) + 1;
            int rightChild = (2 * index) + 2;

            if (leftChild < size && arr[leftChild] < arr[smallest])
                smallest = leftChild;

            if (rightChild < size && arr[rightChild] < arr[smallest])
                smallest = rightChild;

            if(smallest != index)
            {
                int temp = arr[index];
                arr[index] = arr[smallest];
                arr[smallest] = temp;

                Heapify(arr, size, smallest);
            }
        }

        static void HeapSort(int[] arr, int size)
        {
            for (int i = (size / 2) - 1; i >= 0; i--)
                Heapify(arr, size, i);

            for(int i = size - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        public static void printArray(int[] arr, int size)
        {
            for(int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 3, 2, 9 };
            int size = arr.Length;

            HeapSort(arr, size);

            Console.WriteLine("Sorted array is : ");
            printArray(arr, size);

            Console.ReadLine();
        }
    }
}
