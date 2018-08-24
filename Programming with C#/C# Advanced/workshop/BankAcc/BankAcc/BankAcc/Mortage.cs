namespace BankAcc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mortage : Account
    {
        public Mortage(Customer client, decimal balance, decimal interestRate, byte contractPeriod)
            : base(client, balance, interestRate, contractPeriod)
        {
        }

        public override decimal CalculateInterest()
        {
            if (this.ContractPeriod >= 12 && this.Client.Type == CustomerType.Company)
            {
                return this.InterestRate * (this.ContractPeriod - 12);

            }
            if (this.ContractPeriod >= 6 && this.Client.Type == CustomerType.Individual)
            {
                return this.InterestRate * (this.ContractPeriod - 6);

            }
            return this.InterestRate * this.ContractPeriod;
        }
    }
}
