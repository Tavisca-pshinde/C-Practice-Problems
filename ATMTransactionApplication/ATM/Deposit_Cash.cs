using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTransactionApplication
{
    class Deposit_Cash
    {
        double depositcash;
        double currentBal;
        public void DepositCash()
        {
            Console.WriteLine("Enter amount you want deposit");
            depositcash = Convert.ToDouble(Console.ReadLine());
            CheckBal CurrentBalance = new CheckBal();
            currentBal = CurrentBalance.initialAmount+depositcash;
            Console.WriteLine("Your new balance is {0}",currentBal);
        }
    }
}
