public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount(string name = "Unnamed Savings Account", double balance = 0.0, double interestRate = 0.0)
        : base(name, balance)
    {
        this.InterestRate = interestRate;
    }

    public override bool Deposit(double amount)
    {
        if (base.Deposit(amount))
        {
            Balance += amount * (InterestRate / 100);
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"[SavingsAccount: {Name}, Balance: {Balance}, InterestRate: {InterestRate}%]";
    }
}
