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
        public bool PastDueDate(string expDate)
        {
            string[] temp = expDate.Split('/');
            string sMM = temp[0];
            string sYY = temp[1];
            int iMM = int.Parse(sMM);
            int iYY = int.Parse(sYY);

            DateTime expirationDate = new DateTime(iYY,iMM,01).AddMonths(1).AddDays(-1).AddYears(2000);
            var expired = DateTime.Compare(expirationDate, DateTime.Now);
            if(expired < 0)
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