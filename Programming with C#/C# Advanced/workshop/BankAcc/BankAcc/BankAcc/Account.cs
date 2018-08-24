namespace BankAcc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Account : IDepositable
    {
        private Customer client;
        private decimal balance;
        private decimal interestRate;
        private byte contractPeriod;
        private DateTime createDate;

        public Account(Customer client, decimal balance, decimal interestRate, byte contractPeriod)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.contractPeriod = contractPeriod;
            this.CreateDate = DateTime.Now;
        }

        public Account(Customer client, decimal balance, decimal interestRate)
        {
            this.client = client;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public Customer Client { get => client; set => client = value; }

        public decimal Balance { get => balance; set => balance = value; }

        public decimal InterestRate { get => interestRate; set => interestRate = value; }

        public DateTime CreateDate { get => createDate; set => createDate = value; }

        public byte ContractPeriod { get => contractPeriod; set => contractPeriod = value; }

        public void MakeDeposit(int amount)
        {
            balance += amount;
        }

        public override string ToString()
        {
            return string.Format(
                $"Account type: {this.GetType().Name }\n" +
                $"Account owner: { this.client.Type }\n" +
                $"Client: {this.client.Name }\n" +
                $"Balance: {this.balance } \n" +
                $"Interest rate : {this.InterestRate }\n" +
                $"Create date: { this.createDate.ToShortDateString() } \n" +
                $"Calculated iterest: {this.CalculateInterest()}");

        }
        public abstract decimal CalculateInterest();
    }
}
