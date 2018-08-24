namespace FurnitureManufacturer.Models
{
    using System;

    public static class Validator
    {
        public static void CheckStringNameMinRequirements(string model, int minimumLength)
        {
            if (string.IsNullOrEmpty(model) || model.Length < minimumLength)
            {
                throw new ArgumentNullException();
            }
        }

        public static void CheckInputLength(int numberToCheck, int min , int max)
        {
        }

        public static void CheckMinimumValue(decimal numberToCheck, decimal minimumValue)
        {
            if (numberToCheck <= (decimal)minimumValue)
            {
                throw new ArgumentNullException();
            }
        }

        public static void CheckStringIfNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException();
            }
        }
    }
}
