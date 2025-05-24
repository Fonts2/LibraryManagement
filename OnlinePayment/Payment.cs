using LibraryManagement;

namespace OnlinePayment;

public class Payment : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        return amount > 0;
    }

    public string GetPaymentMessage(decimal amount)
    {
        return $"Processing payment of {amount} UAH...";
    }

    public string TransactionDetails() => $"Transaction ID: 12345";
}
