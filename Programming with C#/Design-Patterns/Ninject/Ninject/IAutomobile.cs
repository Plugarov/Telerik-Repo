namespace Ninject
{
    public interface IAutomobile
    {
        void Drive(string input);

        string Brand { get; set; }

        string Model { get; set; }

        int Price { get; set; }
    }
}