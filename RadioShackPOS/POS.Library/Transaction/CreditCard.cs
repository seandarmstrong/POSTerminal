namespace POS.Library
{
    public class CreditCard
    {
        public CreditCard(float total, string creditCardNumber, string expDate, string cVV)
        {
            _total = total;
            _creditCardNumber = creditCardNumber;
            _expDate = expDate;
            _cVV = cVV;
        }

        private float _total { set; get; }
        private static string _creditCardNumber { get; set; }
        private static string _expDate { get; set; }
        private static string _cVV { get; set; }

        public static string GetCreditCardNumber()
        {
            return _creditCardNumber;
        }

        public static string GetExpDate()
        {
            return _expDate;
        }

        public static string GetCVVNumber()
        {
            return _cVV;
        }
    }
}