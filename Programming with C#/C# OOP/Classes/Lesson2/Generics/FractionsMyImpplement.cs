
namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct FractionsMyImpl
    {
        private long numerator;
        private long denumerator;

        public FractionsMyImpl(long numerator, long denumerator)
        {
            long gld = GetCommonDevisor(numerator, denumerator);
            this.numerator = numerator / gld;
            this.denumerator = denumerator / gld;
        }

        public long getNumerator
        {
            get { return this.numerator; }
        }

        public long getDenumerator
        {
            get { return this.denumerator; }
        }

        public static long GetCommonDevisor(long firstNum, long secondNum)
        {
            long newNum = firstNum;
            while (newNum > 0)
            {
                newNum = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = newNum;
            }
            return firstNum;
        }

        public static FractionsMyImpl operator *(FractionsMyImpl firstFraction, FractionsMyImpl secondFraction)
        {
            long num = firstFraction.getNumerator * secondFraction.getNumerator;
            long denum = firstFraction.getDenumerator * secondFraction.getDenumerator;
            return new FractionsMyImpl(num, denum);
        }

    }
}
