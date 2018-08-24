namespace BankAcc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer 
    {
        private string name;
        private CustomerType type;

        public Customer(string name, CustomerType type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name { get => this.name; set => this.name = value; }

        internal CustomerType Type { get => this.type; set => this.type = value; }
    }
}
