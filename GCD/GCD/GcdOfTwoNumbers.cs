using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class GcdOfTwoNumbers
    {
        public int Gcd(int numberOne,int numberTwo)
        {
            int remainder = 0;
            while (numberTwo > 0)
            {
                remainder = numberOne % numberTwo;
                if (remainder == 0)
                {
                    return numberTwo;
                }
                numberOne = numberTwo;
                numberTwo = remainder;

            }
            //gcd of any number with 0 is number itself.

            return numberOne;
        }
    }
}
