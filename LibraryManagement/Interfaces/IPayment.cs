namespace LibraryManagement;

public interface IPayment
{
    bool ProcessPayment(decimal amount);
    string TransactionDetails();
}
