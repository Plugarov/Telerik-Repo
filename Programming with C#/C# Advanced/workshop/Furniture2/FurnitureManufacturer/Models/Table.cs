namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, IFurniture, ITable
    {
        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; }

        public decimal Width { get; }

        public decimal Area { get => this.Length * this.Width; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Length: {0}, Width: {1}",
                this.Length,
                this.Width);
        }
    }
}