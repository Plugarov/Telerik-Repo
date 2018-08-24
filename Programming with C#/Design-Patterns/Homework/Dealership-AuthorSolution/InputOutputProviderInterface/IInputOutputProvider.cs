namespace InputOutputProviderInterface
{
    public interface IInputOutputProvider
    {
        void Write(string input);

        string Read();
    }
}
