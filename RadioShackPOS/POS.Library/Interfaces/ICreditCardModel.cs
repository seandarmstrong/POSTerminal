using POS.Library.Transactions;
using System;

namespace POS.Library
{
    public interface ICreditCardModel : ITransactionModel
    {
        // Signatures
        string CreditCardNumber { get; }
        string ExpirationDate { get; }
        string CVV { get; }
        // Methods
        string AskForCCNumber();
        string AskForCVV();
    }
}