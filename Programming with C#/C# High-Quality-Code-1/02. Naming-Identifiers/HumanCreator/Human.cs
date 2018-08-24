namespace HumanCreator
{
    public class Human
    {
        private Gender gender;
        private string name;
        private int age;

        public Human(int age, string name, Gender gender)
        {
            this.age = age;
            this.name = name;
            this.gender = gender;
        }

        public Gender Gender()
        {
            return this.gender;
        }

        public void Gender(Gender value)
        {
            this.gender = value;
        }

        public string Name()
        {
            return this.name;
        }

        public void Name(string value)
        {
            this.name = value;
        }

        public int Age()
        {
            return this.age;
        }

        public void Age(int value)
        {
            this.age = value;
        }

        public override string ToString()
        {
            return base.ToString($"Introduce " +
                $"{this.name} the " +
                $"{this.gender} who is " +
                $"{this.age} years old.");
        }
    }
}