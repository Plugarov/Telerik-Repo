namespace Homework
{
    public class ConsoleLogger
    {
        public void LogBooleanValueAsString(bool booleanValue)
        {
            string booleanValueAsString = booleanValue.ToString();
            Console.WriteLine(booleanValueAsString);
        }
    }
}