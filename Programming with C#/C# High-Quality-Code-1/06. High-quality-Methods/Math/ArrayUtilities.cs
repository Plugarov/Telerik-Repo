namespace Math
{
    using System;

    public class ArrayUtilities
    {
        static int FindMax(params int[] elements)
        {
            int largestNumber;

            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Passed arguments is null or empty.");
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    largestNumber = elements[i];
                }

                return largestNumber;
            }
        }
    }
}