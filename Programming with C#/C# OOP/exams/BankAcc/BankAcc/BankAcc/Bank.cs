namespace BankAcc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bank 
    {
        private List<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }

        public Bank(List<Account> list)
        {
            this.accounts = list;
        }

        public List<Account> Accounts { get => accounts; set => accounts = value; }
    }
}
