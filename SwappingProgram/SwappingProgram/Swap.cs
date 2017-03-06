using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingProgram
{
    
    class Swap
    {
        
        public void SwapTwoNumber(int firstNumber,int secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First number:{0}",firstNumber);
            Console.WriteLine("Second number:{0}",secondNumber);

        }
    }
}
