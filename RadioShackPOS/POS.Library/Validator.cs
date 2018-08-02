using System;
using System.Text.RegularExpressions;

namespace POS.Library
{
    public class Validator
    {
        // validate credit card #'s example(1234123412341234 or 1234 1234 1234 1234)
        public bool ValidCCNumber(string ccNumber)
        {
            var regx = new Regex(@"^[0-9]{4}\s?[0-9]{4}\s?[0-9]{4}\s?[0-9]{4}$");
            return regx.IsMatch(ccNumber);
        }
        // validate cc expiration date example(MM/YY)
        public bool ValidExpDate(string expDate)
        {
            var regx = new Regex(@"^[0-9]{2}/[0-9]{2}$");
            return regx.IsMatch(expDate);
        }
        // validate cvv on credit card example(123)
        public bool ValidCVV(string cvv)
        {
            var regx = new Regex(@"^[0-9]{3}$");
            return regx.IsMatch(cvv);
        }
        // validate check number example(1234)
        public bool ValidCheckNumber(string checkNumber)
        {
            var regx = new Regex(@"^[0-9]{4}$");
            return regx.IsMatch(checkNumber);
        }

    }
}