using LibraryManagement;

namespace LibraryCart;

public class Cart : ICart
{
    private readonly List<IProduct> products = new();

    public void AddProduct(IProduct product) => products.Add(product);
    public void RemoveProduct(IProduct product) => products.Remove(product);

    public string Checkout()
    {
        if (products.Count == 0)
            return "Cart is empty. No order placed.";

        return $"Order has been placed with {products.Count} item(s).";
    }

    public IReadOnlyList<IProduct> GetProducts() => products.AsReadOnly();
}
