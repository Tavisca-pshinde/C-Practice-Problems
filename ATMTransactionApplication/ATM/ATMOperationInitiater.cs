using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTransactionApplication
{
    class ATMOperationInitiater
    {
        static void Main(string[] args)
        {
            ATMOperation Operation = new ATMOperation();
            Operation.ChoiceSlection();
        }
    }
}
