namespace BankAcc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main()
        {
            List<Account> accounts = new List<Account>()
            {
                new Deposit(new Customer("Joro", CustomerType.Individual), 1000, 1, 12),
                new Deposit(new Customer("IvaLTD", CustomerType.Company), 1000, 1, 4),
                new Loan(new Customer("Zlatka", CustomerType.Individual), 1000, 1, 12),
                new Loan(new Customer("Ivan", CustomerType.Individual), 1000, 1, 5),
                new Mortage(new Customer("TediLTD", CustomerType.Company), 1000, 1, 5),
                new Mortage(new Customer("Merone", CustomerType.Company), 1000, 1, 25),
            };

            Bank DSK = new Bank(accounts);
            DSK.Accounts[0].Balance += 3000;
            DSK.Accounts[1].Balance += 5000;

            foreach (Account ac in DSK.Accounts)
            {
                Console.WriteLine("- - -");
                Console.WriteLine(ac.ToString());
            }
        }
    }
}
