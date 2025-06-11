public class CheckingAccount : Account
{
    private const double WithdrawalFee = 1.5;

    public CheckingAccount(string name = "Unnamed Checking Account", double balance = 0.0)
        : base(name, balance)
    {
    }

    public override bool Withdraw(double amount)
    {
        double totalAmount = amount + WithdrawalFee;
        return base.Withdraw(totalAmount);
    }

    public override string ToString()
    {
        return $"[CheckingAccount: {Name}, Balance: {Balance}]";
    }
}
