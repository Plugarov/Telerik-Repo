namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class AdjustableChair : Chair, IChair, IAdjustableChair
    {
        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) 
            : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            Validator.CheckMinimumValue(height, 0);
            base.Height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
