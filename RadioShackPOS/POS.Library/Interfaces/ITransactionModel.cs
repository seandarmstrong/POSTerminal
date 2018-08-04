namespace POS.Library.Transactions
{
    public interface ITransactionModel
    {
        float Total { get; set; }

        void Transaction(float Total);

    }
}
