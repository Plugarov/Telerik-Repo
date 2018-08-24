namespace Ninject
{
    public interface IAutomobileFactory
    {
        IAutomobile CreateAutomobile(string brand, string model, int price);
    }
}
