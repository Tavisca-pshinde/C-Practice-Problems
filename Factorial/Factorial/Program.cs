using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class FactorialOfNo
    {
        static int number;
        static int factorial=1;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no:");
            number = Convert.ToInt32(Console.ReadLine());
            for(int iterator=2; iterator <= number; iterator++)
            {
                factorial *= iterator;
            }
            Console.WriteLine("Factorial:{0}",factorial);

        }
    }
}
