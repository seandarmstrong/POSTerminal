using System;
using System.Text.RegularExpressions;
using System.Globalization;


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
        // checks if the cc date is is before todays date.
        public bool PastDueDate(DateTime expDate)
        {
            //DateTime expirationDate = DateTime.ParseExact("expDate", "MMyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(expirationDate + "and" + DateTime.Now);
            var expired = DateTime.Compare(expDate, DateTime.Now);
            if(expired >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // validate cvv on credit card example(123)
        public bool IsValidCVV(string cvv)
        {
            var regx = new Regex(@"^[0-9]{3}$");
            return regx.IsMatch(cvv);
        }
        // validate check number example(1234)
        public bool IsValidCheckNumber(string checkNumber)
        {
            var regx = new Regex(@"^[0-9]{4}$");
            return regx.IsMatch(checkNumber);
        }

        public bool IsVailidCashFormat(string payment)
        {
            var regx = new Regex(@"^[0-9]+\.([0-9]{2})$");
            return regx.IsMatch(payment.ToString());
        }
        public int IsValidateUserInput(string input)
        {
            int userInput;
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("That is not a valid input");
                return IsValidateUserInput(Console.ReadLine());
            }
            bool success = int.TryParse(input, out userInput);

            if (success == true)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                return IsValidateUserInput(Console.ReadLine());
            }
        }
    }
}