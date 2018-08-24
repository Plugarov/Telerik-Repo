namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IChair, IConvertibleChair
    {
        private decimal normalStateHeight;

        private bool chairState;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.normalStateHeight = height;
            this.chairState = true;
            Convert();
        }

        public bool IsConverted
        {
            get
            {
                return this.chairState;
            }
        }

        public void Convert()
        {
            this.chairState = !this.chairState;
            if (!this.chairState)
            {
                base.Height = normalStateHeight;
            }
            else
            {
                base.Height = (decimal)0.10;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0} ", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
