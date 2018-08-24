namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IFurniture, IChair
    {
        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}",
                this.NumberOfLegs);
        }
    }
}
