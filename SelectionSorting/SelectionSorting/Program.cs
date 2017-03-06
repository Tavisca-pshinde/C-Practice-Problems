using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            int[] NumberstobeSorted = new int[20];
            try
            {
                //int[] NumberstobeSorted = new int[20];
                Console.WriteLine("Enter size of Numbers:");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Numbers:");
                for (int i = 0; i < n; i++)
                {

                    NumberstobeSorted[i] = Convert.ToInt32(Console.ReadLine());
                }
                SelectionSort sort = new SelectionSort();
                int[] arr = sort.Sort(NumberstobeSorted, n);
                sort.Display(arr, n);
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong input "+e.Message);
            }
            

        }
    }
}
