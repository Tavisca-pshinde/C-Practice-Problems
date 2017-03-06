using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSorting
{
    class SelectionSort
    {
        public int[] Sort(int[] arr, int n)
        {
            int index, smallest, iterator, temp;
            for (index = 0; index < (n - 1); index++)
            {
                smallest = index;
                for (iterator = index + 1; iterator < n ; iterator++)
                {
                    if (arr[smallest] > arr[iterator])
                    {
                        smallest = iterator;
                    }
                }
                if (smallest != index)
                {
                    temp = arr[index];
                    arr[index] = arr[smallest];
                    arr[smallest] = temp;
                }
            }
            return arr;
        }

        public void Display(int[] arr,int n)
        {
            Console.WriteLine("Sorted array:");
            for(int i=0; i < n ; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }
    }
}
