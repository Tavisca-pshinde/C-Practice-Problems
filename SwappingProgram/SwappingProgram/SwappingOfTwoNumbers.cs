using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingProgram
{
    class SwappingOfTwoNumbers
    {
        static int firstNumber;
        static int secondNumber;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Firstnumber:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secondnumber:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Swap SwapNo = new Swap();
            SwapNo.SwapTwoNumber(firstNumber,secondNumber);
        }
    }
}
