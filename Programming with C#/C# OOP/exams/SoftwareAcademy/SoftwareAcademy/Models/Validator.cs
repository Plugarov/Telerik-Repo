namespace SoftwareAcademy.Models
{
    using System;

    public static class Validator
    {
        public static void checkIfNullOrEmpty(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
        }

        public static void checkIfNullObj(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
