using System;

namespace Ninject
{
    public class Automobile : IAutomobile
    {
        public Automobile(string brand, string model, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public void Drive(string input)
        {
            Console.WriteLine(input);
        }
    }
}
