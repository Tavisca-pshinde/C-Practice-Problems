using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTransactionApplication
{

    class ATMOperation
    {
        int pinNumber,choice;
        public void ChoiceSlection()
        {
            Console.WriteLine("Enter your pin to access your account:");
            pinNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***Welcome to ATM***");
            do
            {
                
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Withdraw Cash");
                Console.WriteLine("3.Deposit Cash");
                Console.WriteLine("4.Quit");
                choice= Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                            CheckBal Bal = new CheckBal();
                            Bal.CheckBalance();
                            break;
                    case 2:
                            Withdraw_cash Cash = new Withdraw_cash();
                            Cash.WithdrawCash();
                            break;
                    case 3:
                            Deposit_Cash Dcash = new Deposit_Cash();
                            Dcash.DepositCash();
                            break;
                    case 4:
                            Console.WriteLine("REMOVE YOUR CARD");
                            break;
                    default:
                            Console.WriteLine("Enter valid choice");
                            break;
                }
            } while (choice!=4);
        }
    }
}
