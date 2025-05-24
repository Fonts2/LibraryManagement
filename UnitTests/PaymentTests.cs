using OnlinePayment;

namespace LibraryTests;

public class PaymentTests
{
    [Fact]
    public void ProcessPayment_WithPositiveAmount_ReturnsTrue()
    {
        var payment = new Payment();
        Assert.True(payment.ProcessPayment(100m));
    }

    [Fact]
    public void GetPaymentMessage_ReturnsCorrectString()
    {
        var payment = new Payment();
        var msg = payment.GetPaymentMessage(100m);
        Assert.Equal("Processing payment of 100 UAH...", msg);
    }
}
