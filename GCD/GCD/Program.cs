using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static int firstNumber;
        static int secondNumber;
        static int numberOne;
        static int numberTwo;
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Enter First no:");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no:");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            if(numberOne>numberTwo)
            {
                firstNumber = numberOne;
                secondNumber = numberTwo;
            }
            else
            {
                firstNumber = numberTwo;
                secondNumber = numberOne;

            }
            GcdOfTwoNumbers gcd = new GcdOfTwoNumbers();
            result=gcd.Gcd(firstNumber,secondNumber);
            Console.WriteLine("GCD:{0}",result);
        }
    }
}
