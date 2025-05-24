using OnlinePayment;

namespace LibraryTests;

public class PaymentTests
{
    [Fact]
    public void ProcessPayment_ReturnsTrue_AndPrintsOutput()
    {
        var payment = new Payment();

        using var sw = new StringWriter();
        Console.SetOut(sw);

        var result = payment.ProcessPayment(200m);

        Assert.True(result);
        Assert.Contains("Processing payment of 200", sw.ToString());
    }

    [Fact]
    public void TransactionDetails_ReturnsExpectedString()
    {
        var payment = new Payment();
        var details = payment.TransactionDetails();
        Assert.Equal("Transaction ID: 12345", details);
    }
}
