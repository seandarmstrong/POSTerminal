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
        public Check Check { get; set; }
        public Cash Cash { get; set; }
        public CreditCard CreditCard { get; set; }

        public string GetCheckNumber()
        {
            return Check.CheckNumber;
        }

        public void DisplayReceipt(Check check)
        {
            Console.WriteLine(check.CheckNumber);
        }

        
    }
}
