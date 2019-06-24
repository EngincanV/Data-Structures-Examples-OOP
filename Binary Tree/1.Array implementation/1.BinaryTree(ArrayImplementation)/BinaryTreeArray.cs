using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BinaryTree_ArrayImplementation_
{
    public class BinaryTreeArray
    {
        int root = 0;
        string[] str;

        public BinaryTreeArray(int strSize, string key)
        {
            this.str = new string[strSize];
            this.str[root] = key;
        }

        public void set_Left(string key, int index)
        {
            int leftChild = (2 * index) + 1;

            if (str[index] == null)
                Console.WriteLine("Parent bulunamadi, ekleme yapılamaz.");

            else
                str[leftChild] = key;
        }

        public void set_Right(string key, int index)
        {
            int rightChild = (2 * index) + 2;

            if (str[index] == null)
                Console.WriteLine("Parent bulunamadi, ekleme yapılamaz.");

            else
                str[rightChild] = key;
        }

        public void print_Tree()
        {
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] != null)
                    Console.Write(str[i] + " ");
                else
                    Console.Write("-");
            }
        }
    }
}
