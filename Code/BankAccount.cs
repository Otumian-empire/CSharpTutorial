class BankAccount
{
    private double balance = 0;

    public void Deposit(double n)
    {
        this.balance += n;
    }

    public void Withdraw(double n)
    {
        this.balance -= n;
    }

    public double GetBalance()
    {
        return this.balance;
    }
}