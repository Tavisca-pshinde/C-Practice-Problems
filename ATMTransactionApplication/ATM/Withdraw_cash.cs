using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTransactionApplication
{
    class Withdraw_cash
    {
        double amount;
        double currentBal;
        public void WithdrawCash()
        {
            Console.WriteLine("ENTER AMOUNT YOU WANT TO WITHDRAW Rs:");
            amount = Convert.ToDouble(Console.ReadLine());
            CheckBal CheckAmount = new CheckBal();
            if (amount > CheckAmount.initialAmount)
            {
                Console.WriteLine("YOUR BALANCE IS LESS THAN ENTERED AMOUNT");
            }
            else
            {
                Console.WriteLine("COLLECT YOUR CASH");
                CheckBal CurrentBalance = new CheckBal();
                currentBal = CurrentBalance.initialAmount-amount;
                Console.WriteLine("Your new balance is {0}", currentBal);
            }
        }
    }
}
