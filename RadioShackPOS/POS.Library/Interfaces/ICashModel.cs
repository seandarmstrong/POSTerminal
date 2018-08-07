using POS.Library.Transactions;

namespace POS.Library
{
    public interface ICashModel : ITransactionModel
    {
        // Signatures
        string Tender { get; }
        float Change { get; }
        // Methods
        //string MakeChange(float total);
    }
}
