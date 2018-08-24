namespace Computers.Interfaces
{
    public interface IRam
    {
        int Amount { get; }

        void SaveValue(int newValue);

        int LoadValue();
    }
}
