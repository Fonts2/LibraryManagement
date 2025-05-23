using LibraryManagement;

namespace LibraryCart;

public class Cart : ICart
{
    private readonly List<IProduct> products = new();

    public void AddProduct(IProduct product) => products.Add(product);
    public void RemoveProduct(IProduct product) => products.Remove(product);
    public void Checkout() => Console.WriteLine("Order has been placed.");
}
