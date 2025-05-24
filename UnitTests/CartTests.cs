using BookProduct;
using LibraryCart;

namespace LibraryTests;

public class CartTests
{
    [Fact]
    public void Checkout_ReturnsCorrectMessage_WhenCartIsNotEmpty()
    {
        var cart = new Cart();
        var book = new Book { Title = "Test", Author = "Author" };
        cart.AddProduct(book);

        var result = cart.Checkout();
        Assert.Equal("Order has been placed with 1 item(s).", result);
    }

    [Fact]
    public void Checkout_ReturnsEmptyMessage_WhenCartIsEmpty()
    {
        var cart = new Cart();
        var result = cart.Checkout();
        Assert.Equal("Cart is empty. No order placed.", result);
    }
}
