using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    class Loan : Account
    {
        public Loan(Customer client, decimal balance, decimal interestRate, byte contractPeriod)
            : base(client, balance, interestRate, contractPeriod)
        {
        }

        public override decimal CalculateInterest()
        {
            if (this.ContractPeriod >= 3 && this.Client.Type == CustomerType.Individual)
            {
                return this.InterestRate * (this.ContractPeriod - 3);
            }
            if (this.ContractPeriod >= 2 && this.Client.Type == CustomerType.Company)
            {
                return this.InterestRate * (this.ContractPeriod - 2);
            }
            return this.InterestRate * this.ContractPeriod;
        }
    }
}
