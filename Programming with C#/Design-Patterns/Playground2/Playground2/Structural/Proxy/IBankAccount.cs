namespace Playground2.Structural.Proxy
{
    public interface IBankAccount
    {
        bool Deposit(decimal amount);

        bool Withdraw(decimal amount);

        decimal CurrentBallance();
    }
}
