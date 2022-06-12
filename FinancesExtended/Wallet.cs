using System;
using System.Collections.Generic;
using System.Text;

namespace FinancesExtended
{
    internal class Wallet
    {
        private string description;
        private int balance;

        public Wallet (string aDesscription, int aBalance)
        {
            description = aDesscription;
            balance = aBalance;
        }
    }

   
}
