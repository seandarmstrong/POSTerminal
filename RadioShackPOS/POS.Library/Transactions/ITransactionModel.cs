using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library.Transactions
{
    public interface ITransactionModel
    {
        float Total { get; set; }

        void Transaction(float Total);

    }
}
