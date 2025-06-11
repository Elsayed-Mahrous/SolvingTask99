public class TrustAccount : SavingsAccount
{
    private const int MaxWithdrawalsPerYear = 3;
    private const double MaxWithdrawalPercent = 0.2;
    private const double BonusThreshold = 5000.0;
    private const double BonusAmount = 50.0;

    private int withdrawalsThisYear = 0;

    public TrustAccount(string name = "Unnamed Trust Account", double balance = 0.0, double interestRate = 0.0)
        : base(name, balance, interestRate)
    {
    }

    public override bool Deposit(double amount)
    {
        if (amount >= BonusThreshold)
            Balance += BonusAmount;

        return base.Deposit(amount);
    }

    public override bool Withdraw(double amount)
    {
        if (withdrawalsThisYear >= MaxWithdrawalsPerYear)
            return false;

        if (amount > Balance * MaxWithdrawalPercent)
            return false;

        if (base.Withdraw(amount))
        {
            withdrawalsThisYear++;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"[TrustAccount: {Name}, Balance: {Balance}, InterestRate: {InterestRate}%, Withdrawals: {withdrawalsThisYear}]";
    }
}
