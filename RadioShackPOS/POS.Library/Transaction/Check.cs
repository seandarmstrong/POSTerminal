namespace POS.Library
{
    public class Check
    {
        public Check(float total, int checkNumber)
        {
            _total = total;
            _checkNumber = checkNumber;
        }

        private float _total;
        private static int _checkNumber;

        public static int GetCheckNumber()
        {
            return _checkNumber;
        }
    }

}