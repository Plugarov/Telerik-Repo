
namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Generics;

    enum Gender
    {
        male,
        female
    }

    class Cat
    {
        private static Gender newGender;
        private Gender gender;

        public Gender getGender
        {
            get { return this.gender; }
        }

        public Cat(Gender gender)
        {
            this.gender = gender;
        }


        public static Cat operator +(Cat item1, Cat item2)
        {
            if (item1.gender == item2.gender)
            {
                throw new Exception();
            }
            else
            {
                RandomGenderGenerator();
                return new Cat(newGender);
            }
        }

        private static void RandomGenderGenerator()
        {
            Random rand = new Random();
            int index = rand.Next(0, 2);
            newGender = (Gender)index;
        }
    }
}

