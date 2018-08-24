namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private string materialType;
        private decimal price;
        private decimal height;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.price = price;
            this.height = height;
            Validator.CheckStringNameMinRequirements(model, 3);
            this.model = model;
            this.materialType = materialType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public string Material
        {
            get
            {
                return this.materialType;
            }
            protected set
            {
                this.materialType = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validator.CheckMinimumValue(value, (decimal)0.00);
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Validator.CheckMinimumValue(value, (decimal)0.00);
                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\nType: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.Model, this.materialType, this.price, this.height);
        }
    }
}
