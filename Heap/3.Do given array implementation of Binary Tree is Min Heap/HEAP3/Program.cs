using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEAP3
{
    class Program
    {
        public static bool isMinHeap(int[] level)
        {
            int size = level.Length - 1;

            for(int i = (size / 2) - 1 ; i >= 0 ; i--)
            {
                //leftChild = 2 * i + 1
                if (level[i] > level[(2 * i) + 1])
                    return false;

                if((2 * i) + 2 < size)
                {
                    //rightChild = 2 * i + 2
                    if (level[i] > level[(2 * i) + 2])
                        return false;
                }
            }
            return true;
        }

        public static bool isMaxHeap(int[] level2)
        {
            int size = level2.Length - 1;

            for (int i = (size / 2) - 1; i >= 0; i--)
            {
                if (level2[i] >= level2[(2 * i) + 1] && level2[i] > level2[(2 * i) + 2] && i == 0)
                    return true;
                if (level2[i] < level2[(2 * i) + 1] || level2[i] <= level2[(2 * i) + 2])
                    return false;
            }
            return false;
        }

        static void Main(string[] args)
        {
            #region Min Heap
            int[] level = new int[] { 10, 15, 14, 25, 30 };
            if (isMinHeap(level))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            #endregion

            #region Max Heap
            int[] level2 = { 45, 35, 23, 27, 21, 22, 4 };
            if (isMaxHeap(level2))
                Console.WriteLine("Max heap");
            else
                Console.WriteLine("Not"); 
            #endregion

            Console.ReadLine();
        }
    }
}
