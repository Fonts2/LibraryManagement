namespace LibraryManagement;

public interface ICart
{
    void AddProduct(IProduct product);
    void RemoveProduct(IProduct product);
    string Checkout();
    IReadOnlyList<IProduct> GetProducts();
}
