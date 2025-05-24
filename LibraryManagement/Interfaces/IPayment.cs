namespace LibraryManagement;

public interface IPayment
{
    bool ProcessPayment(decimal amount);
    string GetPaymentMessage(decimal amount);
    string TransactionDetails();
}
