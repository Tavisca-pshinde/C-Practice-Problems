using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTransactionApplication
{
    class CheckBal
    {
        public int initialAmount = 1000;
        public void CheckBalance()
        {
            Console.WriteLine("YOUR BALANCE Rs.{0}",initialAmount);
        }
    }
}
