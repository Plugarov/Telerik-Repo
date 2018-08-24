namespace BankAcc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Deposit : Account, IWithdrawable
    {
        public Deposit(Customer client, decimal balance, decimal interestRate, byte contractPeriod)
            : base(client, balance, interestRate, contractPeriod)
        {
        }

        public override decimal CalculateInterest()
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }
            return this.ContractPeriod * this.InterestRate;

        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
