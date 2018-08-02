using System;

namespace POS.Library
{
    public class Cash
    {
        public Cash(float total, float tender)
        {
            _total = total;
            _tender = tender;
        }

        private static float _total { get; set; }
        private static float _tender { get; set; }
        private static float Change { get; set; }

        public static float MakeChange()
        {
            var change = _total - _tender;
            return change;
        }
    }
}