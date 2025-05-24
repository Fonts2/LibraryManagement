using LibraryManagement;

namespace LibraryCart;

public class Cart : ICart
{
    private readonly List<IProduct> products = new();

    public void AddProduct(IProduct product) => products.Add(product);
    public void RemoveProduct(IProduct product) => products.Remove(product);

    public void Checkout()
    {
        if (products.Count == 0)
            Console.WriteLine("Cart is empty. No order placed.");

        Console.WriteLine($"Order has been placed with {products.Count} item(s).");
    }

    public IReadOnlyList<IProduct> GetProducts() => products.AsReadOnly();
}
