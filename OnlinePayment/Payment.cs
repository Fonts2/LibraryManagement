using LibraryManagement;

namespace OnlinePayment;

public class Payment : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount} UAH...");
        return true;
    }

    public string TransactionDetails() => $"Transaction ID: 12345";
}
