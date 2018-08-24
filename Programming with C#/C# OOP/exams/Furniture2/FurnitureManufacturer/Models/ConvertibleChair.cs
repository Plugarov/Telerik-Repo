namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IChair, IConvertibleChair
    {
        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            Convert();
        }

        public bool IsConverted { get; private set; }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
            if (this.IsConverted)
            {
                //TODO something
            }
            else
            {
                //TODO eleseing
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
