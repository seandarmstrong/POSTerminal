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

        private float _total { get; set; }
        private float _tender { get; set; }
        private float Change { get; set; }

        public static float MakeChange()
        {
            throw new NotImplementedException();
        }
    }
}