namespace Ninject
{
    public interface IInputOutputProvider
    {
        string Read();

        void Write(string input);
    }
}