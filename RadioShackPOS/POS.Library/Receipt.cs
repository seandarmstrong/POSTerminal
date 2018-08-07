using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Library;

namespace POS.Library
{
    public class Receipt
    {
        // these are overloads of the same method to handle different transactions

        // display check receipt
        public void DisplayReceipt(Check check)
        {
            Console.WriteLine($"Total paid by check with check #{check.CheckNumber}");
        }
        // display cash receipt
        public void DisplayReceipt(Cash cash)
        {
            Console.WriteLine("Total paid by cash. Your change was {0:C}", Math.Round(cash.Change, 2));
        }
        // display credit card receipt
        public void DisplayReceipt(CreditCard cc)
        {
            var lastFour = cc.CreditCardNumber.Substring(8, 4);
            Console.WriteLine($"Total paid by credit card with credit card #xxxx-xxxx-xxxx-{lastFour}");
        }

        
    }
}
