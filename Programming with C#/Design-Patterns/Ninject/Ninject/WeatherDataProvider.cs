namespace Ninject
{
    public class WeatherDataProvider : IWeatherDataProvider
    {
        private IInputOutputProvider inputOutputProvider;

        public WeatherDataProvider(IInputOutputProvider inputOutputProvider)
        {
            this.inputOutputProvider = inputOutputProvider;
        }

        public void DisplayWeatherInformation(string input)
        {
            this.inputOutputProvider.Write(input);
        }
    }
}
