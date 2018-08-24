namespace WarMachines.Machines
{
    using System;

    public static class Validator
    {
        public static void checkIfNullObj(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
        }

        public static void checkIfNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
        }

        public static void checkIfPositive(double value, string msg = "Must be more than 0")
        {
            if (value < 1)
            {
                throw new Exception(msg);
            }
        }
    }
}
