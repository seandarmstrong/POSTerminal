using POS.Library.Transactions;

namespace POS.Library
{
    public interface ICheckModel : ITransactionModel
    {
        // Signature
        string CheckNumber { get; }
        // Method
        string GetCheckNumber();
    }
}