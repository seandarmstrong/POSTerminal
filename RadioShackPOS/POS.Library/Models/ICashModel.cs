using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Library.Transactions;

namespace POS.Library.Models
{
    interface ICashModel : ITransactionModel
    {
        // Signatures
        string Tender { get; }
        float Change { get; }
        // Methods
        string MakeChange(float total);
    }
}
