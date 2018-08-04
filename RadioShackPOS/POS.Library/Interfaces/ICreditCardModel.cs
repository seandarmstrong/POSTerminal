using POS.Library.Transactions;

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