using POS.Library.Transactions;

namespace POS.Library
{
    public interface ICashModel : ITransactionModel
    {
        // Signatures
        float Tender { get; }
        float Change { get; }
        // Methods
        //string MakeChange(float total);
    }
}
