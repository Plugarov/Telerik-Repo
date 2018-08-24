namespace HumanCreator
{
    class HumanFactory
    {
        public HumanFactory() { }

        public void CreateHuman(int age, string name, Gender gender)
        {
            Human human = new Human(age, name, gender);

            return human;
        }
    }
}