namespace Computers.Interfaces
{
    public interface ICpu
    {
        byte NumberOfCores { get; }

        IRam Ram { get; }

        void SquareNumber();

        void Rand(int a, int b);
    }
}
