using System;
using System.Collections.Generic;
using System.Text;

namespace FinancesExtended
{
    internal class Wallet
    {
        private string description;
        private int balance;


        public Wallet (string discription, int balance)
        {
           this.description = discription;
           this.balance = balance;
        }
    }

   
}
