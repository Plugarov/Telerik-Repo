namespace HumanCreator
{
    using System;

    class HumanFactoryDemo
    {
        public void Main(int age)
        {
            var humanFactory = new HumanFactory();

            int age = 20;
            string name = "Joro";
            Gender gender = Gender.StrongMan;

            var human = humanFactory.CreateHuman(age, name, gender);

            if (Joro.Age % 2 == 0)
            {
                human.Name = "Батката";
                human.Gender = Gender.StrongMan;
            }
            else
            {
                human.Name = "Мацето";
                human.Gender = Gender.BeautifulWoman;
            }

            Console.log(human);
        }
    }
}