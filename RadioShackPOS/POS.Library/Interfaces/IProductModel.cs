namespace POS.Library.Interfaces
{
    public interface IProductModel
    {
        string Category { get; }
        string Name { get; }
        string Description { get; }
        float Price { get; }

    }
}
