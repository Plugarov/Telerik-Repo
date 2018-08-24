namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IFurniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            set
            {
                Validator.CheckMinimumValue(value, 0);
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}", this.NumberOfLegs);
        }
    }
}
