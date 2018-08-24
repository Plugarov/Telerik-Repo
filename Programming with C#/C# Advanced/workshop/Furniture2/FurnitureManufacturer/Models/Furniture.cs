namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class Furniture : IFurniture
    {
        private decimal price;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
        }

        public string Model { get; }

        public string Material { get; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                //TODO validation
                this.price = value;
            }
        }

        public decimal Height { get; protected set; }

        public override string ToString()
        {
            return string.Format("\nType: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, 
                this.Model, 
                this.Material, 
                this.Price, 
                this.Height);
        }
    }
}
